using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Enemy2 : MonoBehaviour
{
    // �������ޔz��
    public EnemyData[] enemyData;

    // �I���W�i���̃I�u�W�F�N�g
    public GameObject originenemy;

    // �o���p
    private GameObject[] enemy = new GameObject[4];
    public SpriteRenderer Sprite;

    //[SerializeField] GameObject _parentGameObject;

    //private const float spawnRate = 2.0f;       // �o���Ԋu
    [SerializeField] private float spawnRealTime = 0;            // ���A���^�C��
    private int i;                              // �z��ԍ�

    //��_�Ԃ̋���������
    private float[] distance_two = new float[4];

    // Start is called before the first frame update
    void Start()
    {
        // �e�L�X�g�t�@�C���̓ǂݍ��݂��s���Ă����N���X
        TextAsset textasset = new TextAsset();
        // csv�t�@�C����ǂݍ��܂���
        textasset = Resources.Load("CSVEnemy", typeof(TextAsset)) as TextAsset;
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
            else if (enemyData[i].State == 1)
            {
                //enemy[i].transform.position = Vector3.MoveTowards(
                //   enemy[i].transform.position,
                //   new Vector3(enemyData[i].TargetPosX, enemyData[i].TargetPosY, enemyData[i].TargetPosZ),
                //   Time.deltaTime * 3000
                //   );

                //��_�Ԃ̋�������(�X�s�[�h�����Ɏg��)
                distance_two[i] = Vector3.Distance(
                    new Vector3(enemyData[i].StartPosX, enemyData[i].StartPosY, enemyData[i].StartPosZ),
                    new Vector3(enemyData[i].TargetPosX, enemyData[i].TargetPosY, enemyData[i].TargetPosZ)
                    );

                // ���݂̈ʒu
                float present_Location = (Time.time * 200) / distance_two[i]; // Time.deltaTime���ƃo�O��

                enemy[i].transform.position = Vector3.Slerp(
                    new Vector3(enemyData[i].StartPosX, enemyData[i].StartPosY, enemyData[i].StartPosZ),
                    new Vector3(enemyData[i].TargetPosX, enemyData[i].TargetPosY, enemyData[i].TargetPosZ),
                    present_Location
                    );
                enemy[i].transform.Rotate(0f, 1.0f, 0f);
            }
        }
    }

    // �G���o��������֐�
    void SpawnNewEnemy(int no)
    {
        enemy[no] = Instantiate(
            originenemy,
            new Vector3(enemyData[no].StartPosX, enemyData[no].StartPosY, enemyData[no].StartPosZ),
            Quaternion.identity/*,*/
            //_parentGameObject.transform
            );
        enemy[no].GetComponent<SpriteRenderer>().sprite = enemyData[no].sprite;
    }
}

// CSV��ScriptableObject�ɗ�������
#if UNITY_EDITOR
public class PostEnemy2 : AssetPostprocessor
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
