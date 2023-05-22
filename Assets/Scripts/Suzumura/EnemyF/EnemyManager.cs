using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private float spawnRealTime = 0;            // タイマー

    // CSVのデータを流し込む配列
    [SerializeField] public EnemyData[] enemyData;
    [SerializeField] public EnemyDatas[] enemyDatas;

    // StageChangerオブジェクト
    public GameObject StageChanger;

    // オリジナルのオブジェクト
    public GameObject originenemy;

    public GameObject AppearanceNoticeObj;
    private AppearanceNotice appearanceNotice;
    public GameObject PhaseUI;
    private PhaseManager phase;
    public GameObject StageData;
    private Stage11 stage11;
    public bool clearflag;

    // 出現用オブジェクト
    private int element = 2;
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
    [SerializeField] private bool EnemyAnimation;

    // 作るエネミーの番号
    [SerializeField] private static int EnemyIdx;

    private void Awake()
    {
        //enemyDatas = new EnemyDatas[50];
        StageData = GameObject.Find("StageData");
        stage11 = StageData.GetComponent<Stage11>();

    }

    // Start is called before the first frame update
    void Start()
    {
        // 親のオブジェクト(StageChanger)を取得
        StageChanger = this.transform.root.gameObject;
        // スクリプト上のNextStageを取得
        StageNo nextStageNo = StageChanger.GetComponent<StageChangerScript>().NextStage;
        Debug.Log(nextStageNo);
        // 使用するCSVファイルの行数を取得
        //element = CountNumberofLine.Main(nextStageNo);
        // 配列の要素数を決定
        enemy = new GameObject[element];
        model = new GameObject[element];
        enemyData = new EnemyData[50];
        Debug.Log("長さ" + enemyData.Length);
        // csvファイルを読み込ませる
        // NextStageの番号で読み込むファイルを分岐する
        switch (nextStageNo)
        {
            case StageNo.Stage1_1:
                enemyData = stage11.enemydatas;
                Debug.Log(enemyData[0].name);
                //StartCoroutine(AddressableLoad("enemy11"));
                //元のリソースロードを使った方法
                //textasset = Resources.Load("CSV/enemy11", typeof(TextAsset)) as TextAsset;
                break;
            case StageNo.Stage1_2:
                //StartCoroutine(AddressableLoad("enemy12"));
                break;
            case StageNo.Stage1_3:
                //StartCoroutine(AddressableLoad("enemy13"));
                break;
        }
        Debug.Log("pos" + enemyData[i].EntryPosX);

        Debug.Log("ながさ" + enemyData.Length);
        Debug.Log("datas" + enemyDatas.Length);
        enemyDatas[0].Entry = new Vector3(enemyData[0].EntryPosX, enemyData[0].EntryPosY, enemyData[0].EntryPosZ);
        Debug.Log("pos" + enemyDatas[0].Entry.x);

        // 初期設定(Vector3として使いやすいようになど)
        for (int i = 0; i < enemyData.Length; i++)
        {
            Debug.Log("pos" + enemyData[i].EntryPosX);
            enemyDatas[i].Entry = new Vector3(enemyData[i].EntryPosX, enemyData[i].EntryPosY, enemyData[i].EntryPosZ);
            enemyDatas[i].target1 = new Vector3(enemyData[i].Target1PosX, enemyData[i].Target1PosY, enemyData[i].Target1PosZ);
            enemyDatas[i].target = new Vector3(enemyData[i].TargetPosX, enemyData[i].TargetPosY, enemyData[i].TargetPosZ);
            enemyDatas[i].Step = 0;
        }
        Debug.Log(enemyDatas[0].Step);
        // SpriteRendererの初期化
        Sprite = GetComponent<SpriteRenderer>();

        appearanceNotice = AppearanceNoticeObj.GetComponent<AppearanceNotice>();
        PhaseUI = GameObject.Find("PhaseGroup");
        phase = PhaseUI.GetComponent<PhaseManager>();

        // ビューポート取得(敵が消える境目、少し広く取っている)
        ViewportLB = Camera.main.ViewportToWorldPoint(new Vector3(-0.1f, -0.1f));
        ViewportRT = Camera.main.ViewportToWorldPoint(new Vector3(1.1f, 1.1f));

        // 最初はPhase1;
        CurrentPhase = 1;
        phase.PlayPhase(CurrentPhase);
        clearflag = false;
    }

    // Update is called once per frame
    void Update()
    {
        spawnRealTime += Time.deltaTime;    // 現在時間
        PhaseTransition = true;
        EnemyAnimation = false;
        for (i = 0; i < element; i++)
        {
            // 敵が削除されていた場合はスキップ           ↓削除ステート
            if (enemy[i] == null && enemyData[i].State == -1) continue;

            // 現在のフェーズに出現する敵だけを出す
            if (CurrentPhase != (int)enemyData[i].phase) continue;

            // 敵出現時の共通処理
            if (enemyData[i].State != 0)
            {
                enemyDatas[i].prevPosition = enemy[i].transform.position;    // 前フレームのワールド位置をとっておく
                enemyDatas[i].Duration += Time.deltaTime;                    // 経過時間を取得
            }

            // 敵未出現
            if (enemyData[i].State == 0)
            {
                // 時間になったら敵登場
                if (spawnRealTime >= enemyData[i].AppearanceTime)
                {
                    SpawnNewEnemy(i);
                    enemyData[i].State = SetState(i);
                    enemyDatas[i].Duration = 0.0f;
                }
            }
            // 敵出現
            // 1:Slerpによる二点間の球形移動
            else if (enemyData[i].State == 1)
            {
                //二点間の距離を代入(スピード調整に使う)
                enemyDatas[i].distance_two = Vector3.Distance(
                    new Vector3(enemyData[i].StartPosX, enemyData[i].StartPosY, enemyData[i].StartPosZ),
                    enemyDatas[i].target1
                    );

                // 現在の位置
                enemyDatas[i].PresentLocation = (enemyDatas[i].Duration * 5) / enemyDatas[i].distance_two;

                // 移動
                enemy[i].transform.position = Vector3.Slerp(
                    new Vector3(enemyData[i].StartPosX, enemyData[i].StartPosY, enemyData[i].StartPosZ),
                    enemyDatas[i].target1,
                    enemyDatas[i].PresentLocation
                    );
                //enemy[i].transform.Rotate(0f, 1.0f, 0f);      // おあそび

                // 進行方向に向きを変える
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyDatas[i].prevPosition);

                // positionの値を四捨五入(現在は調整不要？)
                //Vector3 roundposition;
                //roundposition.x = Mathf.Round(enemy[i].transform.position.x);
                //roundposition.y = Mathf.Round(enemy[i].transform.position.y);
                //roundposition.z = Mathf.Round(enemy[i].transform.position.z);

                // 指定場所についたら次の動きに移行
                if (enemy[i].transform.position == enemyDatas[i].target1)
                {
                    enemyData[i].State = SetState(i);
                    enemyDatas[i].Duration = 0;
                }
            }
            // 2:円を描く
            else if (enemyData[i].State == 2)
            {
                // 移動
                enemy[i].transform.RotateAround(
                    new Vector3(enemyDatas[i].target1.x - 1.0f, enemyDatas[i].target1.y, enemyDatas[i].target1.z),
                    Vector3.forward,        // Z軸
                    Time.deltaTime * angle
                    );

                // 進行方向に向きを変える
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyDatas[i].prevPosition);

                // 2周したら次の動きに移行
                if (enemyDatas[i].Duration * angle >= 720.0f)
                {
                    enemyData[i].State = SetState(i);
                    enemyDatas[i].Duration = 0;
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
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyDatas[i].prevPosition);

                EnemyAnimation = true;

                // 一定時間経過で次の動きに移行
                if (enemyDatas[i].Duration >= 10.0f)
                {
                    enemyData[i].State = SetState(i);
                    enemyDatas[i].Duration = 0;
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
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyDatas[i].prevPosition);

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
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyDatas[i].prevPosition);

                // 指定場所についたら次の動きに移行
                if (enemy[i].transform.position == enemyDatas[i].target1)
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
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyDatas[i].prevPosition);

                // 指定場所についたら次の動きに移行
                if (enemy[i].transform.position == enemyDatas[i].target)
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
            phase.PlayPhase(CurrentPhase);
            spawnRealTime = 0;
        }

        if (CurrentPhase == 6)
        {
            clearflag = true;
        }
        Debug.Log(EnemyAnimation);
    }

    // 敵を出現させる関数
    void SpawnNewEnemy(int no)
    {
        // 出現
        enemy[no] = Instantiate(
            Resources.Load<GameObject>("enemy"),
            new Vector3(enemyData[no].StartPosX, enemyData[no].StartPosY, enemyData[no].StartPosZ),
            Quaternion.identity,
            transform
            );
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
        appearanceNotice.StartFade(enemyDatas[no].Entry, enemyData[no].sideNo);
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

    // 敵削除
    public static void DestroyEnemy(int no)
    {
        //enemyData[no].State = -1;
        Destroy(enemy[no]);
    }

    // 次のステートをセット
    public int SetState(int no)
    {
        enemyDatas[no].Step++;
        switch (enemyDatas[no].Step)
        {
            case 1: return enemyData[no].NextState1;
            case 2: return enemyData[no].NextState2;
            case 3: return enemyData[no].NextState3;
            case 4: return enemyData[no].NextState4;
            case 5: return enemyData[no].NextState5;
            default: return -1;
        }
    }

    public bool getclearflag()
    {
        return clearflag;
    }

    public EnemyCategory GetBulletType(int no)
    {
        return enemyData[no].category;
    }

    public bool EnemyAnimationFlug()
    {
        return EnemyAnimation;
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
