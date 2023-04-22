using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using UnityEditor;

public class Save_MIURA : MonoBehaviour
{
    // なんかのクラスを作ってる
    private StreamWriter sw;

    //　ステージクリアデータ格納配列
    public StageClearDate[] StageClearDate;

    void Start()
    {
        // スタートで先にファイルを読み込む

        // 1.最初に元のデータをゲーム内の配列に格納して控えておく
        //　テキストファイルの読み込みを行ってくれるクラス
        TextAsset textasset = new TextAsset();
        //　csvファイルを読み込ませる。
        //　ファイルは「Resources」フォルダを作り、そこに入れておくこと。また"CSVTestData"の部分はファイル名に合わせて変更する。
        textasset = Resources.Load("SaveData", typeof(TextAsset)) as TextAsset;
        //　CSVSerializerを用いてcsvファイルを配列に流し込む。
        StageClearDate = CSVSerializer.Deserialize<StageClearDate>(textasset.text);

        // 2.ファイルを消す
        AssetDatabase.DeleteAsset("Assets/Scenes/MiuraScene/Resources/SaveData.csv");

        // 3.もう1回同じ名前のファイル作成
        //                     ↓ 作るファイル名 ↓true     ↓文字コード  
        sw = new StreamWriter(@"./Assets/Scenes/MiuraScene/Resources/SaveData.csv", true, Encoding.GetEncoding("Shift_JIS"));

    }

    // 保存関数 (ステージ名,通し番号,クリア状況)
    public void SaveData(string txt1,int stage,int state)
    {
        Debug.Log("データ保存だにゃん");

        // intのデータを文字に変換
        string Stage = stage.ToString("00"); 
        string State = state.ToString("0"); 

        // 改行して追加
        string s2 = string.Join(",", txt1, Stage, State);
        sw.WriteLine(s2);
    }

    void Update()
    {

        //if (Input.GetKeyDown(KeyCode.F))
        //{
        //  SaveData("stage1_2",0,0);
        //}

        if (Input.GetKeyDown(KeyCode.D))
        {
            CSVReset();
        }
    }

    // ゲームアプリが終了するタイミングで1回行う処理
    public void OnApplicationQuit()
    {
        // ステージのクリア状況を書き込む
        // ステージデータの内容(StageClearDate)の1行目を作成
        string[] s1 = { "stage", "StageIndex", "State" };

        // s1のデータに書き込むデータを加える(改行)
        string s2 = string.Join(",", s1);

        // swに追加する
        sw.WriteLine(s2);


        // クリアしてるかどうか
        for (int i = 0; i < 20; i++) // 全ステージ20の分ループ
        {
            StageClearState State = StageClearDate[i].State; 
            // s2に内容を加える   ↓ステージ名 ↓通し番号 ↓クリア状況
            s2 = string.Join(",", "stage" + (i / 5 + 1) +"_" + (i % 5 + 1 ), i /*( <-StageIndexと同じ)*/, (int)State);

            // swに追加する
            sw.WriteLine(s2);

        }

        Debug.Log("アプリが落ちるにゃん");
        Debug.Log("ファイルの専有をやめるにゃん");
        // ファイル操作を辞める
        sw.Close();
    }

    // CSVファイル初期化(最初からに使えるかも)
    public void CSVReset()
    {
        // void Start と同じでクローズして新しく作り直す
        Debug.Log("セーブデータを消去するにゃん");
        sw.Close();
        AssetDatabase.DeleteAsset("Assets/Scenes/MiuraScene/Resources/SaveData.csv");
        sw = new StreamWriter(@"./Assets/Scenes/MiuraScene/Resources/SaveData.csv", true, Encoding.GetEncoding("Shift_JIS"));
        string[] s1 = { "stage", "StageIndex", "State" };
        string s2 = string.Join(",", s1);
        sw.WriteLine(s2);

        for (int i = 0; i < 20; i++) // 全ステージ20の分ループ
        {
            StageClearState State = StageClearState.NONE;
            if(i == 0) State = StageClearState.CHALLENGE; // 1_1だけ挑戦中

            // s2に内容を加える   ↓ステージ名 ↓通し番号 ↓クリア状況
            s2 = string.Join(",", "stage" + (i / 5 + 1) + "_" + (i % 5 + 1), i /*( <-StageIndexと同じ)*/, (int)State);

            // swに追加する
            sw.WriteLine(s2);

        }

    }

}


