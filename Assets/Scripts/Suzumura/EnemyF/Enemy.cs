using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Enemy : MonoBehaviour
{
    [SerializeField] private float spawnRealTime = 0;            // �^�C�}�[

    // CSV�̃f�[�^�𗬂����ޔz��
    public EnemyData[] enemyData;

    // StageChanger�I�u�W�F�N�g
    public GameObject StageChanger;

    // �I���W�i���̃I�u�W�F�N�g
    public GameObject originenemy;

    public GameObject AppearanceNoticeObj;
    private AppearanceNotice appearanceNotice;

    // �o���p�I�u�W�F�N�g
    private int element;
    [SerializeField] private GameObject[] enemy;
    public SpriteRenderer Sprite;

    //private const float spawnRate = 2.0f;     // �o���Ԋu
    private int i;                              // �z��ԍ�

    float angle = 400.0f;                       // ��]��(2�Ŏg�p��)
    private Vector3 _right = Vector3.up;        // �I�u�W�F�N�g�̉E������������ɕύX
    private Vector3 _up = Vector3.right;        // �I�u�W�F�N�g�̏�������E�����ɕύX
    private Vector3 _forward = Vector3.forward; // �I�u�W�F�N�g�̐���

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
            textasset = Resources.Load("CSV/Enemy2", typeof(TextAsset)) as TextAsset;
                break;
            case StageNo.Stage1_2:
                textasset = Resources.Load("CSV/Enemy", typeof(TextAsset)) as TextAsset;
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
    }

    // Update is called once per frame
    void Update()
    {
        spawnRealTime += Time.deltaTime;    // ���ݎ���
        for (i = 0; i < element; i++)
        {
            // �O�t���[���̃��[���h�ʒu���Ƃ��Ă���
            if (enemyData[i].State != 0) enemyData[i].prevPosition = enemy[i].transform.position;

            // �G���o��
            if (enemyData[i].State == 0)
            {
                // ���ԂɂȂ�����G�o��
                if (spawnRealTime >= enemyData[i].AppearanceTime)
                {
                    SpawnNewEnemy(i);
                    enemyData[i].State = 1;
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

                // ���̏�Ԃł̌o�ߎ��Ԃ��擾
                enemyData[i].State1time += Time.deltaTime;

                // ���݂̈ʒu
                enemyData[i].PresentLocation = (enemyData[i].State1time * 500) / enemyData[i].distance_two;

                // �ړ�
                enemy[i].transform.position = Vector3.Slerp(
                    new Vector3(enemyData[i].StartPosX, enemyData[i].StartPosY, enemyData[i].StartPosZ),
                    enemyData[i].target1,
                    enemyData[i].PresentLocation
                    );
                //enemy[i].transform.Rotate(0f, 1.0f, 0f);      // ��������

                // �i�s�����Ɍ�����ς���
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyData[i].prevPosition);

                // position�̒l���l�̌ܓ�
                Vector3 roundposition;
                roundposition.x = Mathf.Round(enemy[i].transform.position.x);
                roundposition.y = Mathf.Round(enemy[i].transform.position.y);
                roundposition.z = Mathf.Round(enemy[i].transform.position.z);

                // �w��ꏊ�ɂ����玟�̓����Ɉڍs
                if (roundposition == enemyData[i].target1)
                {
                    enemyData[i].State = 2;
                    enemyData[i].State2time = 0;
                }
            }
            // 2:�~��`��
            else if (enemyData[i].State == 2)
            {
                // ���̏�Ԃł̌o�ߎ��Ԃ��擾
                enemyData[i].State2time += Time.deltaTime;

                // �ړ�
                enemy[i].transform.RotateAround(
                    new Vector3(enemyData[i].target1.x - 100.0f, enemyData[i].target1.y, enemyData[i].target1.z),
                    Vector3.forward,        // Z��
                    Time.deltaTime * angle
                    );

                // �i�s�����Ɍ�����ς���
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyData[i].prevPosition);

                // 2�������玟�̓����Ɉڍs
                if (enemyData[i].State2time * angle >= 720.0f)
                {
                    enemyData[i].State = 3;
                }
            }
            // 3:MoveTowards�ŖڕW�ʒu��
            else if (enemyData[i].State == 3)
            {
                // �ړ�
                enemy[i].transform.position = Vector3.MoveTowards(
                   enemy[i].transform.position,
                   new Vector3(enemyData[i].TargetPosX, enemyData[i].TargetPosY, enemyData[i].TargetPosZ),
                   Time.deltaTime * 800
                   );

                // �i�s�����Ɍ�����ς���
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyData[i].prevPosition);

            }
        }
    }

    // �G���o��������֐�
    void SpawnNewEnemy(int no)
    {
        // �o��
        enemy[no] = Instantiate(
            originenemy,
            new Vector3(enemyData[no].StartPosX, enemyData[no].StartPosY, enemyData[no].StartPosZ),
            Quaternion.identity,
            transform
            );
        // �T�C�Y�ݒ�
        enemy[no].transform.localScale = new Vector3(enemyData[no].Size, enemyData[no].Size, enemyData[no].Size);
        // �e�N�X�`���ݒ�(��)
        enemy[no].GetComponent<SpriteRenderer>().sprite = enemyData[no].sprite;

        // �G�\���̃t�F�[�h���n�߂�
        appearanceNotice.StartFade(enemyData[i].Entry, enemyData[i].sideNo);
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