using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Enemy : MonoBehaviour
{
    // 流し込む配列
    public EnemyData[] enemyData;

    //オブジェクト
    public GameObject EnemyGroup;
    public GameObject enemytexture;
    public SpriteRenderer Sprite;
    public GameObject enemycollision;
    [SerializeField] GameObject _parentGameObject;

    //private const float spawnRate = 2.0f;       // 出現間隔(つかってない)
    private float spawnRealTime = 0;            // リアルタイム
    private int i;                              // 配列番号

    //Vector3 targetPosition;

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
    }

    // Update is called once per frame
    void Update()
    {
        spawnRealTime += Time.deltaTime;
        for (i = 0; i < 4; i++)
        {
            // 敵未出現の場合
            if (enemyData[i].State == 0)
            {
                // 時間になったら敵の出現
                if (spawnRealTime >= enemyData[i].AppearanceTime)
                {
                    SpawnNewEnemy();
                    enemyData[i].State = 1;
                }
            }
            // 敵出ている
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

    // 敵出現
    void SpawnNewEnemy()
    {
        // 画像作成
        GameObject newenemy = Instantiate(
            enemytexture, 
            new Vector3(enemyData[i].StartPosX, enemyData[i].StartPosY, enemyData[i].StartPosZ), 
            Quaternion.identity,
            _parentGameObject.transform
            );
        // テクスチャ設定
        newenemy.GetComponent<SpriteRenderer>().sprite = enemyData[i].sprite;
        // 当たり判定作成
        GameObject newenemycollision = Instantiate(
        enemycollision, 
            new Vector3(enemyData[i].StartPosX, enemyData[i].StartPosY, enemyData[i].StartPosZ), 
            Quaternion.identity,
            _parentGameObject.transform
            );
    }
}

// CSVをScriptableObjectに流し込む
#if UNITY_EDITOR
public class PostEnemy : AssetPostprocessor
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
