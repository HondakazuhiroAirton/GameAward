using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
#if UNITY_EDITOR
using UnityEditor;
#endif

// フェーズ列挙型(Unityエディターのプルダウン用)
public enum PhaseNo
{
    Phase1 = 1,
    Phase2,
    Phase3,
    Phase4,
    Phase5
}

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private float spawnRealTime = 0;            // 生成タイマー

    // CSVのデータを流し込む配列
    [SerializeField] public static EnemyData[] enemyData;
    //[SerializeField] public EnemyData[] enemyData;

    // StageChangerオブジェクト
    public GameObject StageChanger;

    // オリジナルのオブジェクト
    public GameObject originenemy;

    public GameObject AppearanceNoticeObj;
    private AppearanceNotice appearanceNotice;
    public GameObject PhaseUI;
    private PhaseManager phase;
    private bool clearflag;
    private bool stopflag;

    // 出現用オブジェクト
    private int element;
    [SerializeField] private static GameObject[] enemy;
    [SerializeField] private static GameObject[] model;
    public SpriteRenderer Sprite;
    public GameObject Parent;

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

    // Start is called before the first frame update
    void Start()
    {
        // 親のオブジェクト(StageChanger)を取得
        StageChanger = this.transform.root.gameObject;
        // スクリプト上のNextStageを取得
        StageNo nextStageNo = StageChanger.GetComponent<StageChangerScript>().NextStage;
        Debug.Log(nextStageNo);

        // NextStageの番号で読み込むファイルを分岐する
        switch (nextStageNo)
        {
            case StageNo.Stage1_1:
                enemyData = Stage1_1.enemydatas;
                break;
            case StageNo.Stage1_2:
                enemyData = Stage1_2.enemydatas;
                break;
            case StageNo.Stage1_3:
                enemyData = Stage1_3.enemydatas;
                break;
            case StageNo.Stage1_4:
                enemyData = Stage1_4.enemydatas;
                break;
            case StageNo.Stage1_5:
                enemyData = Stage1_5.enemydatas;
                break;
            case StageNo.Stage2_1:
                enemyData = Stage2_1.enemydatas;
                break;
            case StageNo.Stage2_2:
                enemyData = Stage2_2.enemydatas;
                break;
            case StageNo.Stage2_3:
                enemyData = Stage2_3.enemydatas;
                break;
            case StageNo.Stage2_4:
                enemyData = Stage2_4.enemydatas;
                break;
            case StageNo.Stage2_5:
                enemyData = Stage2_5.enemydatas;
                break;
            case StageNo.Stage3_1:
                enemyData = Stage3_1.enemydatas;
                break;
            case StageNo.Stage3_2:
                enemyData = Stage3_2.enemydatas;
                break;
            case StageNo.Stage3_3:
                enemyData = Stage3_3.enemydatas;
                break;
            case StageNo.Stage3_4:
                enemyData = Stage3_4.enemydatas;
                break;
            case StageNo.Stage3_5:
                enemyData = Stage3_5.enemydatas;
                break;
            case StageNo.Stage4_1:
                enemyData = Stage4_1.enemydatas;
                break;
            case StageNo.Stage4_2:
                enemyData = Stage4_2.enemydatas;
                break;
            case StageNo.Stage4_3:
                enemyData = Stage4_3.enemydatas;
                break;
            case StageNo.Stage4_4:
                enemyData = Stage4_4.enemydatas;
                break;
            case StageNo.Stage4_5:
                enemyData = Stage4_5.enemydatas;
                break;
        }

        // 配列の要素数を決定
        element = enemyData.Length;
        enemy = new GameObject[element];
        model = new GameObject[element];

        // 初期設定(Vector3として使いやすいようになど)
        for (int i = 0; i < enemyData.Length; i++)
        {
            enemyData[i].Start = new Vector3(enemyData[i].StartPosX, enemyData[i].StartPosY, enemyData[i].StartPosZ);
            enemyData[i].Entry = new Vector3(enemyData[i].EntryPosX, enemyData[i].EntryPosY, 0);
            enemyData[i].First = new Vector3(enemyData[i].FirstPosX, enemyData[i].FirstPosY, enemyData[i].FirstPosZ);
            enemyData[i].Target = new Vector3(enemyData[i].TargetPosX, enemyData[i].TargetPosY, enemyData[i].TargetPosZ);
            enemyData[i].Step = 0;
            enemyData[i].State = 0;
            enemyData[i].Duration = 0.0f;

            // デフォルトデータ
            if (enemyData[i].RotateSpeed == 0) enemyData[i].RotateSpeed = angle;
            enemyData[i].Second = new Vector3(enemyData[i].SecondPosX, enemyData[i].SecondPosY, enemyData[i].SecondPosZ);
        }

        appearanceNotice = AppearanceNoticeObj.GetComponent<AppearanceNotice>();
        PhaseUI = GameObject.Find("PhaseGroup");
        phase = PhaseUI.GetComponent<PhaseManager>();

        // ビューポート取得(敵が消える境目、少し広く取っている)
        ViewportLB = Camera.main.ViewportToWorldPoint(new Vector3(-0.1f, -0.1f));
        ViewportRT = Camera.main.ViewportToWorldPoint(new Vector3(1.1f, 1.1f));

        // 最初はPhase1;
        CurrentPhase = 1;
        // デバック用
        CurrentPhase = StageChanger.GetComponent<StageChangerScript>().GetPhaseNo();
        // フェーズ再生
        phase.PlayPhase(CurrentPhase);

        clearflag = false;
        stopflag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (stopflag) return;
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
                enemyData[i].prevPosition = enemy[i].transform.position;    // 前フレームのワールド位置をとっておく                                                         
                enemyData[i].Duration += Time.deltaTime;                    // 経過時間を取得
            }

            // 敵未出現
            if (enemyData[i].State == 0)
            {
                // 時間になったら敵登場
                if (spawnRealTime >= enemyData[i].AppearanceTime)
                {
                    if (enemy[i] == null) SpawnNewEnemy(i);                  // 敵出現
                    enemyData[i].Duration += Time.deltaTime;                 // 経過時間を取得

                    // 出現タイミングを少し遅らせる
                    if (enemyData[i].Duration >= 3.0f)
                    {
                        enemyData[i].State = SetState(i);
                        enemyData[i].Duration = 0.0f;
                    }
                }
            }
            // 敵出現
            // 1:Slerpによる二点間の球形移動
            else if (enemyData[i].State == 1)
            {
                //二点間の距離を代入(スピード調整に使う)
                enemyData[i].distance_two = Vector3.Distance(
                    enemyData[i].Start,
                    enemyData[i].First
                    );

                // 現在の位置
                enemyData[i].PresentLocation = (enemyData[i].Duration * SetData(i)) / enemyData[i].distance_two;

                // 移動
                enemy[i].transform.position = Vector3.Slerp(
                    enemyData[i].Start,
                    enemyData[i].First,
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
                if (enemy[i].transform.position == enemyData[i].First)
                {
                    enemyData[i].State = SetState(i);
                    enemyData[i].Duration = 0;
                }
            }
            // 2:円を描く
            else if (enemyData[i].State == 2)
            {
                // 移動
                enemy[i].transform.RotateAround(
                    new Vector3(enemyData[i].First.x + SetData(i), enemyData[i].First.y + enemyData[i].RotateYData, enemyData[i].First.z),
                    Vector3.forward,        // Z軸
                    Time.deltaTime * enemyData[i].RotateSpeed
                    );

                // 進行方向に向きを変える
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyData[i].prevPosition);

                // 2周したら次の動きに移行
                if (Mathf.Abs(enemyData[i].Duration * enemyData[i].RotateSpeed) >= 720.0f)
                {
                    enemyData[i].State = SetState(i);
                    enemyData[i].Duration = 0;
                }
            }
            // 3:MoveTowardsで目標位置に
            else if (enemyData[i].State == 3)
            {
                // 移動
                enemy[i].transform.position = Vector3.MoveTowards(
                   enemy[i].transform.position,
                   enemyData[i].Target,
                   Time.deltaTime * SetData(i)
                   );

                // 進行方向に向きを変える
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyData[i].prevPosition);

                EnemyAnimation = true;

                // 一定時間経過で次の動きに移行
                if (enemyData[i].Duration >= 10.0f)
                {
                    enemyData[i].State = SetState(i);
                    enemyData[i].Duration = 0;
                }
            }
            // 4:敵が逃げていく
            else if (enemyData[i].State == 4)
            {
                // 移動
                enemy[i].transform.position = Vector3.MoveTowards(
                   enemy[i].transform.position,
                   enemyData[i].Start,
                   Time.deltaTime * SetData(i)
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
            // 5:その場待機
            else if (enemyData[i].State == 5)
            {
                // 一定時間経過で次の動きに移行
                if (enemyData[i].Duration >= SetData(i))
                {
                    enemyData[i].State = SetState(i);
                    enemyData[i].Duration = 0;
                }
            }
            // 6:三浦特注　3つの座標へ動きたい
            else if (enemyData[i].State == 6)
            {
                // 移動
                enemy[i].transform.position = Vector3.MoveTowards(
                   enemy[i].transform.position,
                   enemyData[i].Second,
                   Time.deltaTime * SetData(i)
                   );

                // 進行方向に向きを変える
                enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyData[i].prevPosition);

                EnemyAnimation = true;

                // 一定時間経過で次の動きに移行
                if (enemy[i].transform.position == enemyData[i].Second)
                {
                    enemyData[i].State = SetState(i);
                    enemyData[i].Duration = 0;
                }

            }
            //// 9:往復移動
            //else if (enemyData[i].State == 9)
            //{
            //    // 移動
            //    enemy[i].transform.position = Vector3.MoveTowards(
            //       enemy[i].transform.position,
            //       new Vector3(enemyData[i].FirstPosX, enemyData[i].FirstPosY, enemyData[i].FirstPosZ),
            //       Time.deltaTime * 8
            //       );

            //    // 進行方向に向きを変える
            //    enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyData[i].prevPosition);

            //    // 指定場所についたら次の動きに移行
            //    if (enemy[i].transform.position == enemyData[i].First)
            //    {
            //        enemyData[i].State = 10;
            //    }
            //}
            //// 10:往復移動
            //else if (enemyData[i].State == 10)
            //{
            //    // 移動
            //    enemy[i].transform.position = Vector3.MoveTowards(
            //       enemy[i].transform.position,
            //       new Vector3(enemyData[i].TargetPosX, enemyData[i].TargetPosY, enemyData[i].TargetPosZ),
            //       Time.deltaTime * 8
            //       );

            //    // 進行方向に向きを変える
            //    enemy[i].transform.rotation = RotateToMovementDirection(enemy[i].transform.position, enemyData[i].prevPosition);

            //    // 指定場所についたら次の動きに移行
            //    if (enemy[i].transform.position == enemyData[i].target)
            //    {
            //        enemyData[i].State = 9;
            //    }
            //}


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
        //enemy[no].transform.localScale = new Vector3(enemyData[no].Size, enemyData[no].Size, enemyData[no].Size);
        // モデル設定
        model[no] = Instantiate(
            Resources.Load(enemyData[no].model, typeof(GameObject)) as GameObject,
            new Vector3(enemyData[no].StartPosX, enemyData[no].StartPosY, enemyData[no].StartPosZ),
            Quaternion.identity
            );
        Parent = GameObject.Find(enemyData[no].name);
        model[no].transform.parent = Parent.transform;
        // サイズ設定
        model[no].transform.localScale = new Vector3(enemyData[no].Size, enemyData[no].Size, enemyData[no].Size);
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

    // 敵削除
    public static void DestroyEnemy(int no)
    {
        enemyData[no].State = -1;
        Destroy(enemy[no]);
    }

    // 次のステートをセット
    public int SetState(int no)
    {
        enemyData[no].Step++;
        switch (enemyData[no].Step)
        {
            case 1: return enemyData[no].NextStep1;
            case 2: return enemyData[no].NextStep2;
            case 3: return enemyData[no].NextStep3;
            case 4: return enemyData[no].NextStep4;
            case 5: return enemyData[no].NextStep5;
            default: return -1;
        }
    }

    // ステートに対するデータをセット
    public float SetData(int no)
    {
        switch (enemyData[no].Step)
        {
            case 1: return enemyData[no].Data1;
            case 2: return enemyData[no].Data2;
            case 3: return enemyData[no].Data3;
            case 4: return enemyData[no].Data4;
            case 5: return enemyData[no].Data5;
            default: return 0;
        }
    }

    public bool getclearflag()
    {
        return clearflag;
    }

    public void EnemyMoveStop()
    {
        stopflag = true;
    }

    public EnemyCategory GetBulletType(int no)
    {
        return enemyData[no].category;
    }

    public bool EnemyAnimationFlug()
    {
        return EnemyAnimation;
    }

    public int textcount()
    {
       return CurrentPhase;
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
