using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private float spawnRealTime = 0;            // �^�C�}�[

    // CSV�̃f�[�^�𗬂����ޔz��
    [SerializeField] public static EnemyData[] enemyData;

    // StageChanger�I�u�W�F�N�g
    public GameObject StageChanger;

    // �I���W�i���̃I�u�W�F�N�g
    public GameObject originenemy;

    public GameObject AppearanceNoticeObj;
    private AppearanceNotice appearanceNotice;

    // �o���p�I�u�W�F�N�g
    private int element;
    [SerializeField] private static GameObject[] enemy;
    public SpriteRenderer Sprite;

    //private const float spawnRate = 2.0f;     // �o���Ԋu
    private int i;                              // �z��ԍ�

    float angle = 400.0f;                       // ��]��(2�Ŏg�p��)
    private Vector3 _right = Vector3.up;        // �I�u�W�F�N�g�̉E������������ɕύX
    private Vector3 _up = Vector3.right;        // �I�u�W�F�N�g�̏�������E�����ɕύX
    private Vector3 _forward = Vector3.forward; // �I�u�W�F�N�g�̐���

    private Vector3 ViewportLB;     // ��ʂ̍������W
    private Vector3 ViewportRT;     // ��ʂ̉E����W

    private bool PhaseTransition = false;   // �t�F�[�Y�J�ڂ̔��f
    private int CurrentPhase;               // ���݂̃t�F�[�Y

    // ���G�l�~�[�̔ԍ�
    [SerializeField]private static int EnemyIdx;

    //private static EnemyManager _instance;


    // Start is called before the first frame update
    void Start()
    {
        // �e�L�X�g�t�@�C���̓ǂݍ��݂��s���Ă����N���X
        TextAsset textasset = new TextAsset();

        // �e�̃I�u�W�F�N�g(StageChanger)���擾
        StageChanger = this.transform.root.gameObject;
        // �X�N���v�g���NextStage���擾
        StageNo nextStageNo = StageChanger.GetComponent<StageChangerScript>().NextStage;
        Debug.Log(nextStageNo);
        // �g�p����CSV�t�@�C���̍s�����擾
        element = CountNumberofLine.Main(nextStageNo);
        // �z��̗v�f��������
        enemy = new GameObject[element];

        // csv�t�@�C����ǂݍ��܂���
        // NextStage�̔ԍ��œǂݍ��ރt�@�C���𕪊򂷂�
        switch (nextStageNo)
        {
            case StageNo.Stage1_1:
                textasset = Resources.Load("CSV/Enemy11", typeof(TextAsset)) as TextAsset;
                break;
            case StageNo.Stage1_2:
                textasset = Resources.Load("CSV/Enemy12", typeof(TextAsset)) as TextAsset;
                break;

                // �X�e�[�W���������牺�ɒǋL

        }
        // CSVSerializer��p����csv�t�@�C����z��ɗ�������
        enemyData = CSVSerializer.Deserialize<EnemyData>(textasset.text);

        // SpriteRenderer�̏�����
        Sprite = GetComponent<SpriteRenderer>();

        appearanceNotice = AppearanceNoticeObj.GetComponent<AppearanceNotice>();

        // Target1Pos���g���₷���悤�ɒu������
        for (i = 0; i < element; i++)
        {
            enemyData[i].Entry = new Vector3(enemyData[i].EntryPosX, enemyData[i].EntryPosY, enemyData[i].EntryPosZ);
            enemyData[i].target1 = new Vector3(enemyData[i].Target1PosX, enemyData[i].Target1PosY, enemyData[i].Target1PosZ);
        }

        // �r���[�|�[�g�擾
        ViewportLB = Camera.main.ViewportToWorldPoint(new Vector3(-0.1f, -0.1f));
        ViewportRT = Camera.main.ViewportToWorldPoint(new Vector3(1.1f, 1.1f));

        // �ŏ���tPhase1;
        CurrentPhase = 1;

        //if (_instance == null)
        //{
        //    _instance = this;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        spawnRealTime += Time.deltaTime;    // ���ݎ���
        PhaseTransition = true;
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
                    SpawnNewEnemy(i);
                    enemyData[i].State = 1;
                    enemyData[i].Duration = 0.0f;
                }
            }
            // �G�o��
            // 1:Slerp�ɂ���_�Ԃ̋��`�ړ�
            else if (enemyData[i].State == 1)
            {
                //��_�Ԃ̋�������(�X�s�[�h�����Ɏg��)
                enemyData[i].distance_two = Vector3.Distance(
                    new Vector3(enemyData[i].StartPosX, enemyData[i].StartPosY, enemyData[i].StartPosZ),
                    enemyData[i].target1
                    );

                // ���݂̈ʒu
                enemyData[i].PresentLocation = (enemyData[i].Duration * 5) / enemyData[i].distance_two;

                // �ړ�
                enemy[i].transform.position = Vector3.Slerp(
                    new Vector3(enemyData[i].StartPosX, enemyData[i].StartPosY, enemyData[i].StartPosZ),
                    enemyData[i].target1,
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
                if (enemy[i].transform.position == enemyData[i].target1)
                {
                    enemyData[i].State = 2;
                    enemyData[i].Duration = 0;
                }
            }
            // 2:�~��`��
            else if (enemyData[i].State == 2)
            {
                // �ړ�
                enemy[i].transform.RotateAround(
                    new Vector3(enemyData[i].target1.x - 1.0f, enemyData[i].target1.y, enemyData[i].target1.z),
                    Vector3.forward,        // Z��
                    Time.deltaTime * angle
                    );

                // �i�s�����Ɍ�����ς���
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyData[i].prevPosition);

                // 2�������玟�̓����Ɉڍs
                if (enemyData[i].Duration * angle >= 720.0f)
                {
                    enemyData[i].State = 3;
                    enemyData[i].Duration = 0;
                }
            }
            // 3:MoveTowards�ŖڕW�ʒu��
            else if (enemyData[i].State == 3)
            {
                // �ړ�
                enemy[i].transform.position = Vector3.MoveTowards(
                   enemy[i].transform.position,
                   new Vector3(enemyData[i].TargetPosX, enemyData[i].TargetPosY, enemyData[i].TargetPosZ),
                   Time.deltaTime * 8
                   );

                // �i�s�����Ɍ�����ς���
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyData[i].prevPosition);

                // ��莞�Ԍo�߂Ŏ��̓����Ɉڍs
                if (enemyData[i].Duration >= 3.0f)
                {
                    enemyData[i].State = 4;
                    enemyData[i].Duration = 0;
                }
            }
            // 4:�G�������Ă���
            else if (enemyData[i].State == 4)
            {
                // �ړ�
                enemy[i].transform.position = Vector3.MoveTowards(
                   enemy[i].transform.position,
                   new Vector3(enemyData[i].StartPosX, enemyData[i].StartPosY, enemyData[i].StartPosZ),
                   Time.deltaTime * 8
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
            PhaseTransition = false;  // �G���c���Ă���ΑJ�ڂ��Ȃ�
        }

        // �S�Ă̓G���|���ꂽor��ʊO�ɓ������玟�̃t�F�[�Y�Ɉڍs
        if (PhaseTransition)
        {
            CurrentPhase++;
            spawnRealTime = 0;
        }
    }

    // �G���o��������֐�
    void SpawnNewEnemy(int no)
    {
        // ���ɍ��G�l�~�[�̔ԍ����o����
        EnemyIdx = no;
       
        // �o��
        enemy[no] = Instantiate(
            originenemy,
            new Vector3(enemyData[no].StartPosX, enemyData[no].StartPosY, enemyData[no].StartPosZ),
            Quaternion.identity,
            transform
            );
        // ���O������
        enemy[no].name = enemyData[no].name;

        // �T�C�Y�ݒ�
        enemy[no].transform.localScale = new Vector3(enemyData[no].Size, enemyData[no].Size, enemyData[no].Size);
        // �e�N�X�`���ݒ�(��)
        enemy[no].GetComponent<SpriteRenderer>().sprite = enemyData[no].sprite;

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

    // �r�[�����G�ɓ������ē|���ꂽ
    //public static void HitBeam(int enemyIdx)
    //{
    //    DestroyEnemy(enemyIdx);
    //}

    //public static EnemyManager getinstace()
    //{
    //    return _instance;
    //}

    // �G�ԍ��擾
    public static int GetEnemyNo()
    {
        return EnemyIdx;
    }

    // �G���W
    public static Vector3 GetEnemyPos(int no)
    {
        if (enemyData[no].State == -1) return Vector3.zero;
        if (enemyData[no].State == 0) return Vector3.zero;
        //Debug.Log(no);
        //Debug.Log(no + "�Ԃ̌��݂̃X�e�[�g��" + enemyData[no].State);
        return enemy[no].transform.position;
    }


    // �G�폜
    public static void DestroyEnemy(int no)
    {
        enemyData[no].State = -1;
        //Debug.Log(no);
        Destroy(enemy[no]);
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