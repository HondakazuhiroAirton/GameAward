using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Enemy2 : MonoBehaviour
{
    // 流し込む配列
    public EnemyData[] enemyData;

    // オリジナルのオブジェクト
    public GameObject originenemy;

    // 出現用
    private GameObject[] enemy = new GameObject[4];
    public SpriteRenderer Sprite;

    //[SerializeField] GameObject _parentGameObject;

    //private const float spawnRate = 2.0f;       // 出現間隔
    [SerializeField] private float spawnRealTime = 0;            // リアルタイム
    private int i;                              // 配列番号

    //二点間の距離を入れる
    private float[] distance_two = new float[4];

    // Start is called before the first frame update
    void Start()
    {
        // テキストファイルの読み込みを行ってくれるクラス
        TextAsset textasset = new TextAsset();
        // csvファイルを読み込ませる
        textasset = Resources.Load("CSVEnemy", typeof(TextAsset)) as TextAsset;
        // CSVSerializerを用いてcsvファイルを配列に流し込む
        enemyData = CSVSerializer.Deserialize<EnemyData>(textasset.text);

        Sprite = GetComponent<SpriteRenderer>();

        spawnRealTime = 0;            // リアルタイム

    }

    // Update is called once per frame
    void Update()
    {
        spawnRealTime += Time.deltaTime;
        for (i = 0; i < 4; i++)
        {
            // 敵未出現
            if (enemyData[i].State == 0)
            {
                if (spawnRealTime >= enemyData[i].AppearanceTime)
                {
                    SpawnNewEnemy(i);
                    enemyData[i].State = 1;
                }
            }
            // 敵出現
            else if (enemyData[i].State == 1)
            {
                //enemy[i].transform.position = Vector3.MoveTowards(
                //   enemy[i].transform.position,
                //   new Vector3(enemyData[i].TargetPosX, enemyData[i].TargetPosY, enemyData[i].TargetPosZ),
                //   Time.deltaTime * 3000
                //   );

                //二点間の距離を代入(スピード調整に使う)
                distance_two[i] = Vector3.Distance(
                    new Vector3(enemyData[i].StartPosX, enemyData[i].StartPosY, enemyData[i].StartPosZ),
                    new Vector3(enemyData[i].TargetPosX, enemyData[i].TargetPosY, enemyData[i].TargetPosZ)
                    );

                // 現在の位置
                float present_Location = (Time.time * 200) / distance_two[i]; // Time.deltaTimeだとバグる

                enemy[i].transform.position = Vector3.Slerp(
                    new Vector3(enemyData[i].StartPosX, enemyData[i].StartPosY, enemyData[i].StartPosZ),
                    new Vector3(enemyData[i].TargetPosX, enemyData[i].TargetPosY, enemyData[i].TargetPosZ),
                    present_Location
                    );
                enemy[i].transform.Rotate(0f, 1.0f, 0f);
            }
        }
    }

    // 敵を出現させる関数
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

// CSVをScriptableObjectに流し込む
#if UNITY_EDITOR
public class PostEnemy2 : AssetPostprocessor
{
    static void OnPostEnemyAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
    {
        foreach (string str in importedAssets)
        {
            // IndexOfの引数は"/(読み込ませたいファイル名)"
            if (str.IndexOf("/CSVenemy.csv") != -1)
            {
                // エディタ内で読み込むならResource.Loadではなくこちらを使うこともできるよ
                TextAsset textasset = AssetDatabase.LoadAssetAtPath<TextAsset>(str);
                // 同名のScriptableObjectファイルを読み込む、ない場合は新たに作る
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
