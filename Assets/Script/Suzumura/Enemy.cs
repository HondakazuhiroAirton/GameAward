using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Enemy : MonoBehaviour
{
    // �������ޔz��
    public EnemyData[] enemyData;

    //�I�u�W�F�N�g
    public GameObject EnemyGroup;
    public GameObject enemytexture;
    public SpriteRenderer Sprite;
    public GameObject enemycollision;
    [SerializeField] GameObject _parentGameObject;

    //private const float spawnRate = 2.0f;       // �o���Ԋu(�����ĂȂ�)
    private float spawnRealTime = 0;            // ���A���^�C��
    private int i;                              // �z��ԍ�

    //Vector3 targetPosition;

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
    }

    // Update is called once per frame
    void Update()
    {
        spawnRealTime += Time.deltaTime;
        for (i = 0; i < 4; i++)
        {
            // �G���o���̏ꍇ
            if (enemyData[i].State == 0)
            {
                // ���ԂɂȂ�����G�̏o��
                if (spawnRealTime >= enemyData[i].AppearanceTime)
                {
                    SpawnNewEnemy();
                    enemyData[i].State = 1;
                }
            }
            // �G�o�Ă���
            else if (enemyData[i].State == 1)
            {
                transform.position = Vector3.MoveTowards(
                    transform.position,
                    new Vector3(enemyData[i].TargetPosX, enemyData[i].TargetPosY, enemyData[i].TargetPosZ),
                    Time.deltaTime*30
                    );
            }
        }
    }

    // �G�o��
    void SpawnNewEnemy()
    {
        // �摜�쐬
        GameObject newenemy = Instantiate(
            enemytexture, 
            new Vector3(enemyData[i].StartPosX, enemyData[i].StartPosY, enemyData[i].StartPosZ), 
            Quaternion.identity,
            _parentGameObject.transform
            );
        // �e�N�X�`���ݒ�
        newenemy.GetComponent<SpriteRenderer>().sprite = enemyData[i].sprite;
        // �����蔻��쐬
        GameObject newenemycollision = Instantiate(
        enemycollision, 
            new Vector3(enemyData[i].StartPosX, enemyData[i].StartPosY, enemyData[i].StartPosZ), 
            Quaternion.identity,
            _parentGameObject.transform
            );
    }
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
