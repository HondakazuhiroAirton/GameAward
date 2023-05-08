using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ステージの名前をキレイにする列挙型
public enum StageNo
{
    Stage1_1 = 0,
    Stage1_2,
    Stage1_3,
    Stage1_4,
    Stage1_5,
    Stage2_1,
    Stage2_2,
    Stage2_3,
    Stage2_4,
    Stage2_5,
    Stage3_1,
    Stage3_2,
    Stage3_3,
    Stage3_4,
    Stage3_5,
    Stage4_1,
    Stage4_2,
    Stage4_3,
    Stage4_4,
    Stage4_5,

    Stage_MAX // 全ステージ+1
}

public class StageChangerScript : MonoBehaviour
{
    // ステージデータを入れる**************************************************
    public GameObject StageData;
    public GameObject StageManager;


    // 今のステージNo
    //public StageNo NowStage;

    // 次のステージNo
    public StageNo NextStage;

    [SerializeField]
    // Stageを切り替えるかどうかフラグ
    private bool changeStage = false;

    private void Awake()
    {
        StageManager = GameObject.Find("StageManager");
        NextStage = (StageNo)StageManager.GetComponent<StageManagerScript>().GetStageIndex();
        StageChange(NextStage);
        
    }

    void Start()
    {
    }

    void Update()
    {
        // 手動でステージ選択
        if (changeStage == true)
        {
            // ステージ変更処理を開始する
            StageChange(NextStage);
        }
    }


    // ステージ変更処理
    void StageChange(StageNo no) // <--- 変更先のNo.
    {
        // 前のエネミーを全部デリートする
        Destroy(this.transform.GetChild(0).gameObject);

        // 対応したステージデータのプレハブを作る
        Instantiate( StageData ,
            new Vector3(0.0f, 0.0f, 0.0f),
            Quaternion.identity,
            this.transform);//  <-- StageChangerの子として作成

        // ステージ変更フラグをfalseにする
        changeStage = false;
    }
}
