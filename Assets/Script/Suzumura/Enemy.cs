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
    public GameObject enemy;
    public GameObject enemycollision;

    //private const float spawnRate = 2.0f;       // �o���Ԋu(�����ĂȂ�)
    private float spawnRealTime = 0;            // ���A���^�C��
    private int i;                              // �z��ԍ�

    Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        // �e�L�X�g�t�@�C���̓ǂݍ��݂��s���Ă����N���X
        TextAsset textasset = new TextAsset();
        // csv�t�@�C����ǂݍ��܂���
        textasset = Resources.Load("CSVEnemy", typeof(TextAsset)) as TextAsset;
        // CSVSerializer��p����csv�t�@�C����z��ɗ�������
        enemyData = CSVSerializer.Deserialize<EnemyData>(textasset.text);

        targetPosition = new Vector3(0, 1, 0);
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
                    spawnNewEnemy();
                    enemyData[i].State = 1;
                }
            }
            // �G�o�Ă���
            else
            {
                Vector3 pos = new Vector3(enemyData[i].PosX, enemyData[i].PosY, enemyData[i].PosZ);
                transform.position = Vector3.MoveTowards(pos, targetPosition, Time.deltaTime * 50);
            }
        }
    }

    // �G�o��
    void spawnNewEnemy()
    {
        GameObject newenemy = Instantiate(enemy, new Vector3(enemyData[i].PosX, enemyData[i].PosY, enemyData[i].PosZ), Quaternion.identity);
        GameObject newenemycollision = Instantiate(enemycollision, new Vector3(enemyData[i].PosX, enemyData[i].PosY, enemyData[i].PosZ), Quaternion.identity);
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
