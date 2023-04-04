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

    //オリジナルのオブジェクト
    public GameObject enemy;

    //private const float spawnRate = 2.0f;       // 出現間隔
    private float spawnRealTime = 0;            // リアルタイム
    private int i;                              // 配列番号

    // Start is called before the first frame update
    void Start()
    {
        // テキストファイルの読み込みを行ってくれるクラス
        TextAsset textasset = new TextAsset();
        // csvファイルを読み込ませる
        textasset = Resources.Load("CSVEnemy", typeof(TextAsset)) as TextAsset;
        // CSVSerializerを用いてcsvファイルを配列に流し込む
        enemyData = CSVSerializer.Deserialize<EnemyData>(textasset.text);
    }

    // Update is called once per frame
    void Update()
    {
        spawnRealTime += Time.deltaTime;
        for (i = 0; i < 4; i++)
        {
            if (spawnRealTime >= enemyData[i].AppearanceTime)
            {
                if (enemyData[i].Bool == true)
                {
                    spawnNewEnemy();
                    enemyData[i].Bool = false;
                }
            }
        }
    }

    // 敵出現
    void spawnNewEnemy()
    {
        GameObject newenemy = Instantiate(enemy, new Vector3(enemyData[i].PosX, enemyData[i].PosY, enemyData[i].PosZ), Quaternion.identity);
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
