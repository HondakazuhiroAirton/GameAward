using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private float spawnRealTime = 0;            // タイマー

    // CSVのデータを流し込む配列
    [SerializeField] public static EnemyData[] enemyData;

    // StageChangerオブジェクト
    public GameObject StageChanger;

    // オリジナルのオブジェクト
    public GameObject originenemy;

    public GameObject AppearanceNoticeObj;
    private AppearanceNotice appearanceNotice;
    public bool clearflag;

    // 出現用オブジェクト
    private int element;
    [SerializeField] private static GameObject[] enemy;
    [SerializeField] private static GameObject[] model;
    public SpriteRenderer Sprite;
    public GameObject Parent;

    //private const float spawnRate = 2.0f;     // 出現間隔
    private int i;                              // 配列番号

    float angle = 400.0f;                       // 回転量(2で使用中)
    private Vector3 _right = Vector3.up;        // オブジェクトの右向き→上向きに変更
    private Vector3 _up = Vector3.right;        // オブジェクトの上向き→右向きに変更
    private Vector3 _forward = Vector3.forward; // オブジェクトの正面

    private Vector3 ViewportLB;     // 画面の左下座標
    private Vector3 ViewportRT;     // 画面の右上座標

    private bool PhaseTransition = false;   // フェーズ遷移の判断
    private int CurrentPhase;               // 現在のフェーズ

    // 作るエネミーの番号
    [SerializeField]private static int EnemyIdx;


    // Start is called before the first frame update
    void Start()
    {
        // テキストファイルの読み込みを行ってくれるクラス
        TextAsset textasset = new TextAsset();

        // 親のオブジェクト(StageChanger)を取得
        StageChanger = this.transform.root.gameObject;
        // スクリプト上のNextStageを取得
        StageNo nextStageNo = StageChanger.GetComponent<StageChangerScript>().NextStage;
        Debug.Log(nextStageNo);
        // 使用するCSVファイルの行数を取得
        element = CountNumberofLine.Main(nextStageNo);
        // 配列の要素数を決定
        enemy = new GameObject[element];
        model = new GameObject[element];

        // csvファイルを読み込ませる
        // NextStageの番号で読み込むファイルを分岐する
        switch (nextStageNo)
        {
            case StageNo.Stage1_1:
                textasset = Resources.Load("CSV/Enemy11", typeof(TextAsset)) as TextAsset;
                break;
            case StageNo.Stage1_2:
                textasset = Resources.Load("CSV/Enemy12", typeof(TextAsset)) as TextAsset;
                break;
            case StageNo.Stage1_3:
                textasset = Resources.Load("CSV/Enemy13", typeof(TextAsset)) as TextAsset;
                break;
            case StageNo.Stage1_4:
                textasset = Resources.Load("CSV/Enemy14", typeof(TextAsset)) as TextAsset;
                break;
            case StageNo.Stage1_5:
                textasset = Resources.Load("CSV/Enemy15", typeof(TextAsset)) as TextAsset;
                break;
            case StageNo.Stage2_1:
                textasset = Resources.Load("CSV/Enemy21", typeof(TextAsset)) as TextAsset;
                break;
            case StageNo.Stage2_2:
                textasset = Resources.Load("CSV/Enemy22", typeof(TextAsset)) as TextAsset;
                break;
            case StageNo.Stage2_3:
                textasset = Resources.Load("CSV/Enemy23", typeof(TextAsset)) as TextAsset;
                break;
            case StageNo.Stage2_4:
                textasset = Resources.Load("CSV/Enemy24", typeof(TextAsset)) as TextAsset;
                break;
            case StageNo.Stage2_5:
                textasset = Resources.Load("CSV/Enemy25", typeof(TextAsset)) as TextAsset;
                break;
            case StageNo.Stage3_1:
                textasset = Resources.Load("CSV/Enemy31", typeof(TextAsset)) as TextAsset;
                break;
            case StageNo.Stage3_2:
                textasset = Resources.Load("CSV/Enemy32", typeof(TextAsset)) as TextAsset;
                break;
            case StageNo.Stage3_3:
                textasset = Resources.Load("CSV/Enemy33", typeof(TextAsset)) as TextAsset;
                break;
            case StageNo.Stage3_4:
                textasset = Resources.Load("CSV/Enemy34", typeof(TextAsset)) as TextAsset;
                break;
            case StageNo.Stage3_5:
                textasset = Resources.Load("CSV/Enemy35", typeof(TextAsset)) as TextAsset;
                break;
            case StageNo.Stage4_1:
                textasset = Resources.Load("CSV/Enemy41", typeof(TextAsset)) as TextAsset;
                break;
            case StageNo.Stage4_2:
                textasset = Resources.Load("CSV/Enemy42", typeof(TextAsset)) as TextAsset;
                break;
            case StageNo.Stage4_3:
                textasset = Resources.Load("CSV/Enemy43", typeof(TextAsset)) as TextAsset;
                break;
            case StageNo.Stage4_4:
                textasset = Resources.Load("CSV/Enemy44", typeof(TextAsset)) as TextAsset;
                break;
            case StageNo.Stage4_5:
                textasset = Resources.Load("CSV/Enemy45", typeof(TextAsset)) as TextAsset;
                break;
        }
        // CSVSerializerを用いてcsvファイルを配列に流し込む
        enemyData = CSVSerializer.Deserialize<EnemyData>(textasset.text);

        // SpriteRendererの初期化
        Sprite = GetComponent<SpriteRenderer>();

        appearanceNotice = AppearanceNoticeObj.GetComponent<AppearanceNotice>();

        // Target1Posを使いやすいように置き換え
        for (i = 0; i < element; i++)
        {
            enemyData[i].Entry = new Vector3(enemyData[i].EntryPosX, enemyData[i].EntryPosY, enemyData[i].EntryPosZ);
            enemyData[i].target1 = new Vector3(enemyData[i].Target1PosX, enemyData[i].Target1PosY, enemyData[i].Target1PosZ);
            enemyData[i].target = new Vector3(enemyData[i].TargetPosX, enemyData[i].TargetPosY, enemyData[i].TargetPosZ);
        }

        // ビューポート取得(敵が消える境目、少し広く取っている)
        ViewportLB = Camera.main.ViewportToWorldPoint(new Vector3(-0.1f, -0.1f));
        ViewportRT = Camera.main.ViewportToWorldPoint(new Vector3(1.1f, 1.1f));

        // 最初はPhase1;
        CurrentPhase = 1;

        clearflag = false;
    }

    // Update is called once per frame
    void Update()
    {
        spawnRealTime += Time.deltaTime;    // 現在時間
        PhaseTransition = true;
        for (i = 0; i < element; i++)
        {
            // 敵が削除されていた場合はスキップ           ↓削除ステート
            if (enemy[i] == null && enemyData[i].State == -1) continue;

            // 現在のフェーズに出現する敵だけを出す
            if (CurrentPhase != (int)enemyData[i].phase) continue;

            // 敵出現時の共通処理
            if (enemyData[i].State != 0)
            {
                enemyData[i].prevPosition = enemy[i].transform.position;    // 前フレームのワールド位置をとっておく
                enemyData[i].Duration += Time.deltaTime;                    // 経過時間を取得
            }

            // 敵未出現
            if (enemyData[i].State == 0)
            {
                // 時間になったら敵登場
                if (spawnRealTime >= enemyData[i].AppearanceTime)
                {
                    SpawnNewEnemy(i);
                    enemyData[i].State = enemyData[i].NextState;
                    enemyData[i].Duration = 0.0f;
                }
            }
            // 敵出現
            // 1:Slerpによる二点間の球形移動
            else if (enemyData[i].State == 1)
            {
                //二点間の距離を代入(スピード調整に使う)
                enemyData[i].distance_two = Vector3.Distance(
                    new Vector3(enemyData[i].StartPosX, enemyData[i].StartPosY, enemyData[i].StartPosZ),
                    enemyData[i].target1
                    );

                // 現在の位置
                enemyData[i].PresentLocation = (enemyData[i].Duration * 5) / enemyData[i].distance_two;

                // 移動
                enemy[i].transform.position = Vector3.Slerp(
                    new Vector3(enemyData[i].StartPosX, enemyData[i].StartPosY, enemyData[i].StartPosZ),
                    enemyData[i].target1,
                    enemyData[i].PresentLocation
                    );
                //enemy[i].transform.Rotate(0f, 1.0f, 0f);      // おあそび

                // 進行方向に向きを変える
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyData[i].prevPosition);

                // positionの値を四捨五入(現在は調整不要？)
                //Vector3 roundposition;
                //roundposition.x = Mathf.Round(enemy[i].transform.position.x);
                //roundposition.y = Mathf.Round(enemy[i].transform.position.y);
                //roundposition.z = Mathf.Round(enemy[i].transform.position.z);

                // 指定場所についたら次の動きに移行
                if (enemy[i].transform.position == enemyData[i].target1)
                {
                    enemyData[i].State = 2;
                    enemyData[i].Duration = 0;
                }
            }
            // 2:円を描く
            else if (enemyData[i].State == 2)
            {
                // 移動
                enemy[i].transform.RotateAround(
                    new Vector3(enemyData[i].target1.x - 1.0f, enemyData[i].target1.y, enemyData[i].target1.z),
                    Vector3.forward,        // Z軸
                    Time.deltaTime * angle
                    );

                // 進行方向に向きを変える
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyData[i].prevPosition);

                // 2周したら次の動きに移行
                if (enemyData[i].Duration * angle >= 720.0f)
                {
                    enemyData[i].State = 3;
                    enemyData[i].Duration = 0;
                }
            }
            // 3:MoveTowardsで目標位置に
            else if (enemyData[i].State == 3)
            {
                // 移動
                enemy[i].transform.position = Vector3.MoveTowards(
                   enemy[i].transform.position,
                   new Vector3(enemyData[i].TargetPosX, enemyData[i].TargetPosY, enemyData[i].TargetPosZ),
                   Time.deltaTime * 8
                   );

                // 進行方向に向きを変える
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyData[i].prevPosition);

                // 一定時間経過で次の動きに移行
                if (enemyData[i].Duration >= 10.0f)
                {
                    enemyData[i].State = 4;
                    enemyData[i].Duration = 0;
                }
            }
            // 4:敵が逃げていく
            else if (enemyData[i].State == 4)
            {
                // 移動
                enemy[i].transform.position = Vector3.MoveTowards(
                   enemy[i].transform.position,
                   new Vector3(enemyData[i].StartPosX, enemyData[i].StartPosY, enemyData[i].StartPosZ),
                   Time.deltaTime * 8
                   );

                // 進行方向に向きを変える
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyData[i].prevPosition);

                // 画面外に逃げたら削除
                if (enemy[i].transform.position.x <= ViewportLB.x ||
                    enemy[i].transform.position.x >= ViewportRT.x ||
                    enemy[i].transform.position.y <= ViewportLB.y ||
                    enemy[i].transform.position.y >= ViewportRT.y)
                {
                    DestroyEnemy(i);
                }
            }

            // 9:往復移動
            else if (enemyData[i].State == 9)
            {
                // 移動
                enemy[i].transform.position = Vector3.MoveTowards(
                   enemy[i].transform.position,
                   new Vector3(enemyData[i].Target1PosX, enemyData[i].Target1PosY, enemyData[i].Target1PosZ),
                   Time.deltaTime * 8
                   );

                // 進行方向に向きを変える
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyData[i].prevPosition);

                // 指定場所についたら次の動きに移行
                if (enemy[i].transform.position == enemyData[i].target1)
                {
                    enemyData[i].State = 10;
                }
            }
            // 10:往復移動
            else if (enemyData[i].State == 10)
            {
                // 移動
                enemy[i].transform.position = Vector3.MoveTowards(
                   enemy[i].transform.position,
                   new Vector3(enemyData[i].TargetPosX, enemyData[i].TargetPosY, enemyData[i].TargetPosZ),
                   Time.deltaTime * 8
                   );

                // 進行方向に向きを変える
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyData[i].prevPosition);

                // 指定場所についたら次の動きに移行
                if (enemy[i].transform.position == enemyData[i].target)
                {
                    enemyData[i].State = 9;
                }
            }


            PhaseTransition = false;  // 敵が残っていれば遷移しない
        }

        // 全ての敵が倒されたor画面外に逃げたら次のフェーズに移行
        if (PhaseTransition)
        {
            CurrentPhase++;
            spawnRealTime = 0;
        }

        if (CurrentPhase == 6)
        {
            clearflag = true;
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
        Debug.Log((no + 1) + "を渡す");
        // インターフェイス
        enemy[no].GetComponent<EnemyInstance>().EnemyIns(no);
        // 名前をつける
        enemy[no].name = enemyData[no].name;
        // サイズ設定
        enemy[no].transform.localScale = new Vector3(enemyData[no].Size, enemyData[no].Size, enemyData[no].Size);
        // テクスチャ設定(仮)
        //enemy[no].GetComponent<SpriteRenderer>().sprite = enemyData[no].sprite;
        // モデル設定
        model[no] = Instantiate(
            Resources.Load(enemyData[no].model, typeof(GameObject)) as GameObject,
            new Vector3(enemyData[no].StartPosX, enemyData[no].StartPosY, enemyData[no].StartPosZ),
            Quaternion.identity
            );
        Parent = GameObject.Find(enemyData[no].name);
        model[no].transform.parent = Parent.transform;
        // 敵予告のフェードを始める
        appearanceNotice.StartFade(enemyData[no].Entry, enemyData[no].sideNo);
    }

    // 進行方向に向きを変える関数
    public Quaternion RotateToMovementDirection(Vector3 newPos, Vector3 oldPos)
    {
        // 移動量を計算
        Vector3 delta = newPos - oldPos;

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

    //敵番号取得
    public static int GetEnemyNo()
    {
        return EnemyIdx;
    }

    // 敵座標
    //public static Vector3 GetEnemyPos(int no)
    //{
    //    return enemy[no].transform.position;
    //}


    // 敵削除
    public static void DestroyEnemy(int no)
    {
        enemyData[no].State = -1;
        Destroy(enemy[no]);
    }

    public bool getclearflag()
    {
        return clearflag;
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
