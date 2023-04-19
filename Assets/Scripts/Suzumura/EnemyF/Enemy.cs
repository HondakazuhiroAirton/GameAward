using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Enemy : MonoBehaviour
{
    [SerializeField] private float spawnRealTime = 0;            // ���A���^�C��

    // �������ޔz��
    public EnemyData[] enemyData;

    // �I���W�i���̃I�u�W�F�N�g
    public GameObject originenemy;

    // StageChanger�I�u�W�F�N�g
    public GameObject StageChanger;

    // �o���p
    private GameObject[] enemy = new GameObject[4];
    public SpriteRenderer Sprite;

    //private const float spawnRate = 2.0f;       // �o���Ԋu
    private int i;                              // �z��ԍ�

    // ���̕ӂ̕ϐ��������K�v
    private float[] distance_two = new float[4];    //��_�Ԃ̋���������
    private float[] State1time = new float[4];
    private float[] PresentLocation = new float[4];
    private Vector3 target1 = new Vector3(1500.0f, 100.0f, 0.0f);
    private float[] State2time = new float[4];
    float angle = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        // �e�L�X�g�t�@�C���̓ǂݍ��݂��s���Ă����N���X
        TextAsset textasset = new TextAsset();

        // �e�̃I�u�W�F�N�g(StageChanger)���擾
        StageChanger = this.transform.root.gameObject;
        // �X�N���v�g���NextStage���擾
        StageNo nextStageNo = StageChanger.GetComponent<StageChangerScript>().NextStage;

        // csv�t�@�C����ǂݍ��܂���
        // NextStage�̔ԍ��œǂݍ��ރt�@�C���𕪊򂷂�
        switch (nextStageNo)
        {
            case StageNo.Stage1_1:
            textasset = Resources.Load("CSVEnemy", typeof(TextAsset)) as TextAsset;
                break;
            case StageNo.Stage1_2:
                textasset = Resources.Load("CSVEnemy", typeof(TextAsset)) as TextAsset;
                break;

                // �X�e�[�W���������牺�ɒǋL

        }
        // CSVSerializer��p����csv�t�@�C����z��ɗ�������
        enemyData = CSVSerializer.Deserialize<EnemyData>(textasset.text);

        Sprite = GetComponent<SpriteRenderer>();

        spawnRealTime = 0;            // ���A���^�C��
    }

    // Update is called once per frame
    void Update()
    {
        spawnRealTime += Time.deltaTime;
        for (i = 0; i < 4; i++)
        {
            // �G���o��
            if (enemyData[i].State == 0)
            {
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
                distance_two[i] = Vector3.Distance(
                    new Vector3(enemyData[i].StartPosX, enemyData[i].StartPosY, enemyData[i].StartPosZ),
                    new Vector3(enemyData[i].TargetPosX, enemyData[i].TargetPosY, enemyData[i].TargetPosZ)
                    );

                // ���̏�Ԃł̌o�ߎ��Ԃ��擾
                State1time[i] += Time.deltaTime;

                // ���݂̈ʒu
                PresentLocation[i] = (State1time[i] * 1000) / distance_two[i];

                enemy[i].transform.position = Vector3.Slerp(
                    new Vector3(enemyData[i].StartPosX, enemyData[i].StartPosY, enemyData[i].StartPosZ),
                    target1,
                    PresentLocation[i]
                    );
                //enemy[i].transform.Rotate(0f, 1.0f, 0f);      // ��������

                // position�̒l���l�̌ܓ�
                Vector3 roundposition;
                roundposition.x = Mathf.Floor(enemy[i].transform.position.x);
                roundposition.y = Mathf.Floor(enemy[i].transform.position.y);
                roundposition.z = Mathf.Floor(enemy[i].transform.position.z);

                // �w��ꏊ�ɂ����玟�̓����Ɉڍs
                if (roundposition == target1)
                {
                    enemyData[i].State = 2;
                    //State2time[i] = 0;
                }
            }
            // 2:�~��`��
            else if (enemyData[i].State == 2)
            {
                // ���̏�Ԃł̌o�ߎ��Ԃ��擾
                State2time[i] += Time.deltaTime;

                enemy[i].transform.RotateAround(
                    new Vector3(target1.x - 100.0f, target1.y, target1.z),
                    Vector3.forward,        // Z��
                    Time.deltaTime * angle
                    );
                // 2�������玟�̓����Ɉڍs
                if (State2time[i] * angle >= 720.0f)
                {
                    enemyData[i].State = 3;
                }
            }
            // 3:MoveTowards�ŖڕW�ʒu��
            else if (enemyData[i].State == 3)
            {
                enemy[i].transform.position = Vector3.MoveTowards(
                   enemy[i].transform.position,
                   new Vector3(enemyData[i].TargetPosX, enemyData[i].TargetPosY, enemyData[i].TargetPosZ),
                   Time.deltaTime * 1000
                   );
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
    }

    // �i�s�����Ɍ�����ς���֐�
    //Vector3 RotateToMovementDirection()
    //{

    //}
}

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
