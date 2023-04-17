using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ステージの名前をキレイにする列挙型
public enum StageNo
{
    Stage1_1 = 0,
    Stage1_2,
    Stage1_3,


    Stage_MAX // 全ステージ+1
}

public class StageChangerScript : MonoBehaviour
{
    // ステージデータを入れる**************************************************
    public GameObject[] StageData;


    // 今のステージNo
    public StageNo NowStage;

    // 次のステージNo
    public StageNo NextStage;

    [SerializeField]
    // Stageを切り替えるかどうかフラグ
    private bool changeStage = false;

    void Start()
    {
       
    }

    void Update()
    {
        // 条件を達成したらステージ変更処理を開始する
        if (changeStage == true)
        {
            // ステージ変更処理を開始する
            StageChange(StageNo.Stage1_1);
        }
    }


    // ステージ変更処理
    void StageChange(StageNo no) // <--- 変更先のNo.
    {
        // 対応したステージデータのプレハブを読み込む
        Instantiate( StageData[(int)no] );

        // ステージ変更フラグをfalseにする
        changeStage = false;
    }
}
