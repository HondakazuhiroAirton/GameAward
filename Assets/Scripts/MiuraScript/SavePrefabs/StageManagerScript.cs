using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManagerScript : MonoBehaviour
{
    // 全ステージ情報
    [SerializeField]private StageClearDate[] AllStage;
    // 現在のステージ
    [SerializeField]private int StageIndex;

    private static GameObject instance;

    // Geter/Seterその他関数**************************************************************
    // ステージ全情報取得
    public StageClearDate[] GetStageInformation()
    {
        return AllStage;
    }

    // ステージ全情報セット
    public void SetStageInformation(StageClearDate[] date)
    {
        AllStage = date;
    }

    // ステージ情報取得
    public int GetStageIndex()
    {
        return StageIndex;
    }

    // ステージ情報セット
    public void SetStageIndex(int date)
    {
        StageIndex = date;
    }

    // 指定したステージのクリア状況を直接変更する変数
    public void SetInformation(int stageNo,StageClearState state) /*stageNo = 通し番号*/
    {
        AllStage[stageNo].State = state;
    }

    // ステージをクリアした時に使う関数
    public void ClearStage(int stageNo) /*stageNo = 通し番号*/
    {
        // もらった通し番号ステージをクリアに変更
        AllStage[stageNo].State = StageClearState.CLEAR;
        // 次のステージをチャレンジの変更
        AllStage[stageNo + 1].State = StageClearState.CHALLENGE;
    }

    void Awake()
    {
        CheckInstance();
    }


    // スタート
    void Start()
    {
        // シーンを跨いでもこのオブジェクトは消えない
        DontDestroyOnLoad(this.gameObject);
    }

    // アップデート
    void Update()
    {
        
    }

    void CheckInstance()
    {
        if (instance == null)
        {
            instance = this.gameObject;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
