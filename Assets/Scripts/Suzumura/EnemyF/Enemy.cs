using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Enemy : MonoBehaviour
{
    private const int obcount = 16;
    [SerializeField] private float spawnRealTime = 0;            // リアルタイム

    // 流し込む配列
    public EnemyData[] enemyData;

    // オリジナルのオブジェクト
    public GameObject originenemy;

    // StageChangerオブジェクト
    public GameObject StageChanger;

    // 出現用
    private GameObject[] enemy = new GameObject[obcount];
    public SpriteRenderer Sprite;

    //private const float spawnRate = 2.0f;       // 出現間隔
    private int i;                              // 配列番号

    // この辺の変数整理が必要
    private Vector3[] prevPosition = new Vector3[obcount];
    private float[] distance_two = new float[obcount];    //二点間の距離を入れる
    private float[] State1time = new float[obcount];
    private float[] PresentLocation = new float[obcount];
    private Vector3[] target1 = new Vector3[obcount];
    private float[] State2time = new float[obcount];
    float angle = 400.0f;
    // オブジェクトの右向き
    private Vector3 _right = Vector3.up;
    // オブジェクトの上向き
    private Vector3 _up = Vector3.right;
    // オブジェクトの正面
    private Vector3 _forward = Vector3.forward;

    // Start is called before the first frame update
    void Start()
    {
        // テキストファイルの読み込みを行ってくれるクラス
        TextAsset textasset = new TextAsset();

        // 親のオブジェクト(StageChanger)を取得
        StageChanger = this.transform.root.gameObject;
        // スクリプト上のNextStageを取得
        StageNo nextStageNo = StageChanger.GetComponent<StageChangerScript>().NextStage;

        // csvファイルを読み込ませる
        // NextStageの番号で読み込むファイルを分岐する
        switch (nextStageNo)
        {
            case StageNo.Stage1_1:
            textasset = Resources.Load("CSVEnemy2", typeof(TextAsset)) as TextAsset;
                break;
            case StageNo.Stage1_2:
                textasset = Resources.Load("CSVEnemy", typeof(TextAsset)) as TextAsset;
                break;

                // ステージが増えたら下に追記

        }
        // CSVSerializerを用いてcsvファイルを配列に流し込む
        enemyData = CSVSerializer.Deserialize<EnemyData>(textasset.text);

        Sprite = GetComponent<SpriteRenderer>();

        spawnRealTime = 0;            // リアルタイム

        for (i = 0; i < obcount; i++)
        {
            target1[i] = new Vector3(enemyData[i].Target1PosX, enemyData[i].Target1PosY, enemyData[i].Target1PosZ);
        }
    }

    // Update is called once per frame
    void Update()
    {
        spawnRealTime += Time.deltaTime;
        for (i = 0; i < obcount; i++)
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
            // 1:Slerpによる二点間の球形移動
            else if (enemyData[i].State == 1)
            {
                // 前フレームのワールド位置
                prevPosition[i] = enemy[i].transform.position;
                //二点間の距離を代入(スピード調整に使う)
                distance_two[i] = Vector3.Distance(
                    new Vector3(enemyData[i].StartPosX, enemyData[i].StartPosY, enemyData[i].StartPosZ),
                    target1[i]
                    );

                // この状態での経過時間を取得
                State1time[i] += Time.deltaTime;

                // 現在の位置
                PresentLocation[i] = (State1time[i] * 500) / distance_two[i];

                enemy[i].transform.position = Vector3.Slerp(
                    new Vector3(enemyData[i].StartPosX, enemyData[i].StartPosY, enemyData[i].StartPosZ),
                    target1[i],
                    PresentLocation[i]
                    );
                //enemy[i].transform.Rotate(0f, 1.0f, 0f);      // おあそび

                // 進行方向に向きを変える
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, prevPosition[i]);

                // positionの値を四捨五入
                Vector3 roundposition;
                roundposition.x = Mathf.Round(enemy[i].transform.position.x);
                roundposition.y = Mathf.Round(enemy[i].transform.position.y);
                roundposition.z = Mathf.Round(enemy[i].transform.position.z);

                // 指定場所についたら次の動きに移行
                if (roundposition == target1[i])
                {
                    enemyData[i].State = 2;
                    State2time[i] = 0;
                }
            }
            // 2:円を描く
            else if (enemyData[i].State == 2)
            {
                // この状態での経過時間を取得
                State2time[i] += Time.deltaTime;

                enemy[i].transform.RotateAround(
                    new Vector3(target1[i].x - 100.0f, target1[i].y, target1[i].z),
                    Vector3.forward,        // Z軸
                    Time.deltaTime * angle
                    );
                // 2周したら次の動きに移行
                if (State2time[i] * angle >= 720.0f)
                {
                    enemyData[i].State = 3;
                }
            }
            // 3:MoveTowardsで目標位置に
            else if (enemyData[i].State == 3)
            {
                // 前フレームのワールド位置
                prevPosition[i] = enemy[i].transform.position;
                // 移動
                enemy[i].transform.position = Vector3.MoveTowards(
                   enemy[i].transform.position,
                   new Vector3(enemyData[i].TargetPosX, enemyData[i].TargetPosY, enemyData[i].TargetPosZ),
                   Time.deltaTime * 800
                   );

                // 進行方向に向きを変える
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, prevPosition[i]);

            }
        }
    }

    // 敵を出現させる関数
    void SpawnNewEnemy(int no)
    {
        // 出現
        enemy[no] = Instantiate(
            originenemy,
            new Vector3(enemyData[no].StartPosX, enemyData[no].StartPosY, enemyData[no].StartPosZ),
            Quaternion.identity,
            transform
            );
        // サイズ設定
        enemy[no].transform.localScale = new Vector3(enemyData[no].Size, enemyData[no].Size, enemyData[no].Size);
        // テクスチャ設定(仮)
        enemy[no].GetComponent<SpriteRenderer>().sprite = enemyData[no].sprite;
    }

    // 進行方向に向きを変える関数
    public Quaternion RotateToMovementDirection(Vector3 newPos, Vector3 oldPos)
    {
        // 移動量を計算
        Vector3 delta = newPos- oldPos;

        // 静止している状態だと、進行方向を特定できないため回転しない
        if (delta == Vector3.zero)
            return Quaternion.identity;

        // 回転補正計算
        Quaternion offsetRot = Quaternion.Inverse(Quaternion.LookRotation(_right, _up));

        // 進行方向（移動量ベクトル）に向くようなクォータニオンを取得
        Quaternion rotation = Quaternion.LookRotation(delta, Vector3.right) * offsetRot;


        // オブジェクトの回転に反映
        return rotation;
    }
}

/*
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
*/