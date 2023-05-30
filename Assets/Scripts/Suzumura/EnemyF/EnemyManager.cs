using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
#if UNITY_EDITOR
using UnityEditor;
#endif

// �t�F�[�Y�񋓌^(Unity�G�f�B�^�[�̃v���_�E���p)
public enum PhaseNo
{
    Phase1 = 1,
    Phase2,
    Phase3,
    Phase4,
    Phase5
}

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private float spawnRealTime = 0;            // �����^�C�}�[

    // CSV�̃f�[�^�𗬂����ޔz��
    [SerializeField] public static EnemyData[] enemyData;
    //[SerializeField] public EnemyData[] enemyData;

    // StageChanger�I�u�W�F�N�g
    public GameObject StageChanger;

    // �I���W�i���̃I�u�W�F�N�g
    public GameObject originenemy;

    public GameObject AppearanceNoticeObj;
    private AppearanceNotice appearanceNotice;
    public GameObject PhaseUI;
    private PhaseManager phase;
    private bool clearflag;
    private bool stopflag;

    // �o���p�I�u�W�F�N�g
    private int element;
    [SerializeField] private static GameObject[] enemy;
    [SerializeField] private static GameObject[] model;
    public SpriteRenderer Sprite;
    public GameObject Parent;

    private int i;                              // �z��ԍ�

    float angle = 400.0f;                       // ��]��(2�Ŏg�p��)
    private Vector3 _right = Vector3.up;        // �I�u�W�F�N�g�̉E������������ɕύX
    private Vector3 _up = Vector3.right;        // �I�u�W�F�N�g�̏�������E�����ɕύX
    private Vector3 _forward = Vector3.forward; // �I�u�W�F�N�g�̐���

    private Vector3 ViewportLB;     // ��ʂ̍������W
    private Vector3 ViewportRT;     // ��ʂ̉E����W

    private bool PhaseTransition = false;   // �t�F�[�Y�J�ڂ̔��f
    private int CurrentPhase;               // ���݂̃t�F�[�Y
    [SerializeField] private bool EnemyAnimation;

    // ���G�l�~�[�̔ԍ�
    [SerializeField] private static int EnemyIdx;

    // Start is called before the first frame update
    void Start()
    {
        // �e�̃I�u�W�F�N�g(StageChanger)���擾
        StageChanger = this.transform.root.gameObject;
        // �X�N���v�g���NextStage���擾
        StageNo nextStageNo = StageChanger.GetComponent<StageChangerScript>().NextStage;
        Debug.Log(nextStageNo);

        // NextStage�̔ԍ��œǂݍ��ރt�@�C���𕪊򂷂�
        switch (nextStageNo)
        {
            case StageNo.Stage1_1:
                enemyData = Stage1_1.enemydatas;
                break;
            case StageNo.Stage1_2:
                enemyData = Stage1_2.enemydatas;
                break;
            case StageNo.Stage1_3:
                enemyData = Stage1_3.enemydatas;
                break;
            case StageNo.Stage1_4:
                enemyData = Stage1_4.enemydatas;
                break;
            case StageNo.Stage1_5:
                enemyData = Stage1_5.enemydatas;
                break;
            case StageNo.Stage2_1:
                enemyData = Stage2_1.enemydatas;
                break;
            case StageNo.Stage2_2:
                enemyData = Stage2_2.enemydatas;
                break;
            case StageNo.Stage2_3:
                enemyData = Stage2_3.enemydatas;
                break;
            case StageNo.Stage2_4:
                enemyData = Stage2_4.enemydatas;
                break;
            case StageNo.Stage2_5:
                enemyData = Stage2_5.enemydatas;
                break;
            case StageNo.Stage3_1:
                enemyData = Stage3_1.enemydatas;
                break;
            case StageNo.Stage3_2:
                enemyData = Stage3_2.enemydatas;
                break;
            case StageNo.Stage3_3:
                enemyData = Stage3_3.enemydatas;
                break;
            case StageNo.Stage3_4:
                enemyData = Stage3_4.enemydatas;
                break;
            case StageNo.Stage3_5:
                enemyData = Stage3_5.enemydatas;
                break;
            case StageNo.Stage4_1:
                enemyData = Stage4_1.enemydatas;
                break;
            case StageNo.Stage4_2:
                enemyData = Stage4_2.enemydatas;
                break;
            case StageNo.Stage4_3:
                enemyData = Stage4_3.enemydatas;
                break;
            case StageNo.Stage4_4:
                enemyData = Stage4_4.enemydatas;
                break;
            case StageNo.Stage4_5:
                enemyData = Stage4_5.enemydatas;
                break;
        }

        // �z��̗v�f��������
        element = enemyData.Length;
        enemy = new GameObject[element];
        model = new GameObject[element];

        // �����ݒ�(Vector3�Ƃ��Ďg���₷���悤�ɂȂ�)
        for (int i = 0; i < enemyData.Length; i++)
        {
            enemyData[i].Start = new Vector3(enemyData[i].StartPosX, enemyData[i].StartPosY, enemyData[i].StartPosZ);
            enemyData[i].Entry = new Vector3(enemyData[i].EntryPosX, enemyData[i].EntryPosY, 0);
            enemyData[i].First = new Vector3(enemyData[i].FirstPosX, enemyData[i].FirstPosY, enemyData[i].FirstPosZ);
            enemyData[i].Target = new Vector3(enemyData[i].TargetPosX, enemyData[i].TargetPosY, enemyData[i].TargetPosZ);
            enemyData[i].Step = 0;
            enemyData[i].State = 0;
            enemyData[i].Duration = 0.0f;

            // �f�t�H���g�f�[�^
            if (enemyData[i].RotateSpeed == 0) enemyData[i].RotateSpeed = angle;
            enemyData[i].Second = new Vector3(enemyData[i].SecondPosX, enemyData[i].SecondPosY, enemyData[i].SecondPosZ);
        }

        appearanceNotice = AppearanceNoticeObj.GetComponent<AppearanceNotice>();
        PhaseUI = GameObject.Find("PhaseGroup");
        phase = PhaseUI.GetComponent<PhaseManager>();

        // �r���[�|�[�g�擾(�G�������鋫�ځA�����L������Ă���)
        ViewportLB = Camera.main.ViewportToWorldPoint(new Vector3(-0.1f, -0.1f));
        ViewportRT = Camera.main.ViewportToWorldPoint(new Vector3(1.1f, 1.1f));

        // �ŏ���Phase1;
        CurrentPhase = 1;
        // �f�o�b�N�p
        CurrentPhase = StageChanger.GetComponent<StageChangerScript>().GetPhaseNo();
        // �t�F�[�Y�Đ�
        phase.PlayPhase(CurrentPhase);

        clearflag = false;
        stopflag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (stopflag) return;
        spawnRealTime += Time.deltaTime;    // ���ݎ���
        PhaseTransition = true;
        EnemyAnimation = false;
        for (i = 0; i < element; i++)
        {
            // �G���폜����Ă����ꍇ�̓X�L�b�v           ���폜�X�e�[�g
            if (enemy[i] == null && enemyData[i].State == -1) continue;

            // ���݂̃t�F�[�Y�ɏo������G�������o��
            if (CurrentPhase != (int)enemyData[i].phase) continue;

            // �G�o�����̋��ʏ���
            if (enemyData[i].State != 0)
            {
                enemyData[i].prevPosition = enemy[i].transform.position;    // �O�t���[���̃��[���h�ʒu���Ƃ��Ă���                                                         
                enemyData[i].Duration += Time.deltaTime;                    // �o�ߎ��Ԃ��擾
            }

            // �G���o��
            if (enemyData[i].State == 0)
            {
                // ���ԂɂȂ�����G�o��
                if (spawnRealTime >= enemyData[i].AppearanceTime)
                {
                    if (enemy[i] == null) SpawnNewEnemy(i);                  // �G�o��
                    enemyData[i].Duration += Time.deltaTime;                 // �o�ߎ��Ԃ��擾

                    // �o���^�C�~���O�������x�点��
                    if (enemyData[i].Duration >= 3.0f)
                    {
                        enemyData[i].State = SetState(i);
                        enemyData[i].Duration = 0.0f;
                    }
                }
            }
            // �G�o��
            // 1:Slerp�ɂ���_�Ԃ̋��`�ړ�
            else if (enemyData[i].State == 1)
            {
                //��_�Ԃ̋�������(�X�s�[�h�����Ɏg��)
                enemyData[i].distance_two = Vector3.Distance(
                    enemyData[i].Start,
                    enemyData[i].First
                    );

                // ���݂̈ʒu
                enemyData[i].PresentLocation = (enemyData[i].Duration * SetData(i)) / enemyData[i].distance_two;

                // �ړ�
                enemy[i].transform.position = Vector3.Slerp(
                    enemyData[i].Start,
                    enemyData[i].First,
                    enemyData[i].PresentLocation
                    );
                //enemy[i].transform.Rotate(0f, 1.0f, 0f);      // ��������

                // �i�s�����Ɍ�����ς���
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyData[i].prevPosition);

                // position�̒l���l�̌ܓ�(���݂͒����s�v�H)
                //Vector3 roundposition;
                //roundposition.x = Mathf.Round(enemy[i].transform.position.x);
                //roundposition.y = Mathf.Round(enemy[i].transform.position.y);
                //roundposition.z = Mathf.Round(enemy[i].transform.position.z);

                // �w��ꏊ�ɂ����玟�̓����Ɉڍs
                if (enemy[i].transform.position == enemyData[i].First)
                {
                    enemyData[i].State = SetState(i);
                    enemyData[i].Duration = 0;
                }
            }
            // 2:�~��`��
            else if (enemyData[i].State == 2)
            {
                // �ړ�
                enemy[i].transform.RotateAround(
                    new Vector3(enemyData[i].First.x + SetData(i), enemyData[i].First.y + enemyData[i].RotateYData, enemyData[i].First.z),
                    Vector3.forward,        // Z��
                    Time.deltaTime * enemyData[i].RotateSpeed
                    );

                // �i�s�����Ɍ�����ς���
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyData[i].prevPosition);

                // 2�������玟�̓����Ɉڍs
                if (Mathf.Abs(enemyData[i].Duration * enemyData[i].RotateSpeed) >= 720.0f)
                {
                    enemyData[i].State = SetState(i);
                    enemyData[i].Duration = 0;
                }
            }
            // 3:MoveTowards�ŖڕW�ʒu��
            else if (enemyData[i].State == 3)
            {
                // �ړ�
                enemy[i].transform.position = Vector3.MoveTowards(
                   enemy[i].transform.position,
                   enemyData[i].Target,
                   Time.deltaTime * SetData(i)
                   );

                // �i�s�����Ɍ�����ς���
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyData[i].prevPosition);

                EnemyAnimation = true;

                // ��莞�Ԍo�߂Ŏ��̓����Ɉڍs
                if (enemyData[i].Duration >= 10.0f)
                {
                    enemyData[i].State = SetState(i);
                    enemyData[i].Duration = 0;
                }
            }
            // 4:�G�������Ă���
            else if (enemyData[i].State == 4)
            {
                // �ړ�
                enemy[i].transform.position = Vector3.MoveTowards(
                   enemy[i].transform.position,
                   enemyData[i].Start,
                   Time.deltaTime * SetData(i)
                   );

                // �i�s�����Ɍ�����ς���
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyData[i].prevPosition);

                // ��ʊO�ɓ�������폜
                if (enemy[i].transform.position.x <= ViewportLB.x ||
                    enemy[i].transform.position.x >= ViewportRT.x ||
                    enemy[i].transform.position.y <= ViewportLB.y ||
                    enemy[i].transform.position.y >= ViewportRT.y)
                {
                    DestroyEnemy(i);
                }
            }
            // 5:���̏�ҋ@
            else if (enemyData[i].State == 5)
            {
                // ��莞�Ԍo�߂Ŏ��̓����Ɉڍs
                if (enemyData[i].Duration >= SetData(i))
                {
                    enemyData[i].State = SetState(i);
                    enemyData[i].Duration = 0;
                }
            }
            // 6:�O�Y�����@3�̍��W�֓�������
            else if (enemyData[i].State == 6)
            {
                // �ړ�
                enemy[i].transform.position = Vector3.MoveTowards(
                   enemy[i].transform.position,
                   enemyData[i].Second,
                   Time.deltaTime * SetData(i)
                   );

                // �i�s�����Ɍ�����ς���
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyData[i].prevPosition);

                EnemyAnimation = true;

                // ��莞�Ԍo�߂Ŏ��̓����Ɉڍs
                if (enemy[i].transform.position == enemyData[i].Second)
                {
                    enemyData[i].State = SetState(i);
                    enemyData[i].Duration = 0;
                }

            }
            //// 9:�����ړ�
            //else if (enemyData[i].State == 9)
            //{
            //    // �ړ�
            //    enemy[i].transform.position = Vector3.MoveTowards(
            //       enemy[i].transform.position,
            //       new Vector3(enemyData[i].FirstPosX, enemyData[i].FirstPosY, enemyData[i].FirstPosZ),
            //       Time.deltaTime * 8
            //       );

            //    // �i�s�����Ɍ�����ς���
            //    enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyData[i].prevPosition);

            //    // �w��ꏊ�ɂ����玟�̓����Ɉڍs
            //    if (enemy[i].transform.position == enemyData[i].First)
            //    {
            //        enemyData[i].State = 10;
            //    }
            //}
            //// 10:�����ړ�
            //else if (enemyData[i].State == 10)
            //{
            //    // �ړ�
            //    enemy[i].transform.position = Vector3.MoveTowards(
            //       enemy[i].transform.position,
            //       new Vector3(enemyData[i].TargetPosX, enemyData[i].TargetPosY, enemyData[i].TargetPosZ),
            //       Time.deltaTime * 8
            //       );

            //    // �i�s�����Ɍ�����ς���
            //    enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyData[i].prevPosition);

            //    // �w��ꏊ�ɂ����玟�̓����Ɉڍs
            //    if (enemy[i].transform.position == enemyData[i].target)
            //    {
            //        enemyData[i].State = 9;
            //    }
            //}


            PhaseTransition = false;  // �G���c���Ă���ΑJ�ڂ��Ȃ�
        }

        // �S�Ă̓G���|���ꂽor��ʊO�ɓ������玟�̃t�F�[�Y�Ɉڍs
        if (PhaseTransition)
        {
            CurrentPhase++;
            phase.PlayPhase(CurrentPhase);
            spawnRealTime = 0;
        }

        if (CurrentPhase == 6)
        {
            clearflag = true;
        }
    }

    // �G���o��������֐�
    void SpawnNewEnemy(int no)
    {
        // �o��
        enemy[no] = Instantiate(
            Resources.Load<GameObject>("enemy"),
            new Vector3(enemyData[no].StartPosX, enemyData[no].StartPosY, enemyData[no].StartPosZ),
            Quaternion.identity,
            transform
            );
        // �C���^�[�t�F�C�X
        enemy[no].GetComponent<EnemyInstance>().EnemyIns(no);
        // ���O������
        enemy[no].name = enemyData[no].name;
        // �T�C�Y�ݒ�
        //enemy[no].transform.localScale = new Vector3(enemyData[no].Size, enemyData[no].Size, enemyData[no].Size);
        // ���f���ݒ�
        model[no] = Instantiate(
            Resources.Load(enemyData[no].model, typeof(GameObject)) as GameObject,
            new Vector3(enemyData[no].StartPosX, enemyData[no].StartPosY, enemyData[no].StartPosZ),
            Quaternion.identity
            );
        Parent = GameObject.Find(enemyData[no].name);
        model[no].transform.parent = Parent.transform;
        // �T�C�Y�ݒ�
        model[no].transform.localScale = new Vector3(enemyData[no].Size, enemyData[no].Size, enemyData[no].Size);
        // �G�\���̃t�F�[�h���n�߂�
        appearanceNotice.StartFade(enemyData[no].Entry, enemyData[no].sideNo);
    }

    // �i�s�����Ɍ�����ς���֐�
    public Quaternion RotateToMovementDirection(Vector3 newPos, Vector3 oldPos)
    {
        // �ړ��ʂ��v�Z
        Vector3 delta = newPos - oldPos;

        // �Î~���Ă����Ԃ��ƁA�i�s���������ł��Ȃ����߉�]���Ȃ�
        if (delta == Vector3.zero)
            return Quaternion.identity;

        // ��]�␳�v�Z
        Quaternion offsetRot = Quaternion.Inverse(Quaternion.LookRotation(_right, _up));

        // �i�s�����i�ړ��ʃx�N�g���j�Ɍ����悤�ȃN�H�[�^�j�I�����擾
        Quaternion rotation = Quaternion.LookRotation(delta, Vector3.right) * offsetRot;


        // �I�u�W�F�N�g�̉�]�ɔ��f
        return rotation;
    }

    //�G�ԍ��擾
    public static int GetEnemyNo()
    {
        return EnemyIdx;
    }

    // �G�폜
    public static void DestroyEnemy(int no)
    {
        enemyData[no].State = -1;
        Destroy(enemy[no]);
    }

    // ���̃X�e�[�g���Z�b�g
    public int SetState(int no)
    {
        enemyData[no].Step++;
        switch (enemyData[no].Step)
        {
            case 1: return enemyData[no].NextStep1;
            case 2: return enemyData[no].NextStep2;
            case 3: return enemyData[no].NextStep3;
            case 4: return enemyData[no].NextStep4;
            case 5: return enemyData[no].NextStep5;
            default: return -1;
        }
    }

    // �X�e�[�g�ɑ΂���f�[�^���Z�b�g
    public float SetData(int no)
    {
        switch (enemyData[no].Step)
        {
            case 1: return enemyData[no].Data1;
            case 2: return enemyData[no].Data2;
            case 3: return enemyData[no].Data3;
            case 4: return enemyData[no].Data4;
            case 5: return enemyData[no].Data5;
            default: return 0;
        }
    }

    public bool getclearflag()
    {
        return clearflag;
    }

    public void EnemyMoveStop()
    {
        stopflag = true;
    }

    public EnemyCategory GetBulletType(int no)
    {
        return enemyData[no].category;
    }

    public bool EnemyAnimationFlug()
    {
        return EnemyAnimation;
    }

    public int textcount()
    {
       return CurrentPhase;
    }

}


/*
// CSV��ScriptableObject�ɗ�������
#if UNITY_EDITOR
public class PostEnemy : AssetPostprocessor
{
    static void OnPostEnemyAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
    {
        foreach (string str in importedAssets)
        {
            // IndexOf�̈�����"/(�ǂݍ��܂������t�@�C����)"
            if (str.IndexOf("/CSVenemy.csv") != -1)
            {
                // �G�f�B�^���œǂݍ��ނȂ�Resource.Load�ł͂Ȃ���������g�����Ƃ��ł����
                TextAsset textasset = AssetDatabase.LoadAssetAtPath<TextAsset>(str);
                // ������ScriptableObject�t�@�C����ǂݍ��ށA�Ȃ��ꍇ�͐V���ɍ��
                string assetfile = str.Replace(".csv", ".asset");
                EnemyDataBase md = AssetDatabase.LoadAssetAtPath<EnemyDataBase>(assetfile);
                if (md == null)
                {
                    md = new EnemyDataBase();
                    AssetDatabase.CreateAsset(md, assetfile);
                }
                md.datas = CSVSerializer.Deserialize<EnemyData>(textasset.text);
                EditorUtility.SetDirty(md);
                AssetDatabase.SaveAssets();
            }
        }
    }
}
#endif
*/
