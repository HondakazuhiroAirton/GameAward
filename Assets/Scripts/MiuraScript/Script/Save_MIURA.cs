using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class Save_MIURA : MonoBehaviour
{
    // なんかのクラスを作ってる
    private StreamWriter sw;

    void Start()
    {
        // なんかのクラスに書き込む内容を入れてるっぽい
        //                     ↓ 作るファイル名 ↓true     ↓文字コード  
        sw = new StreamWriter(@"SaveData.csv", true, Encoding.GetEncoding("Shift_JIS"));

        // ステージ
        string[] s1 = { "stage" };

        // s1のデータに書き込むデータを加える
        string s2 = string.Join(",", s1);

        // swに追加する
        sw.WriteLine(s2);

        // s2に内容を加える
        s2 = string.Join(",", "stage1");

        // swに追加する
        sw.WriteLine(s2);
    }

    // 保存関数
    public void SaveData(string txt1)
    {
        // 文字列配列を作ってる
        string[] s1 = { txt1};
        string s2 = string.Join(",", s1);
        sw.WriteLine(s2);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
          SaveData("stage1");
        }

        // ファイル操作を辞める
        if (Input.GetKeyDown(KeyCode.Return))
        {
            sw.Close();
        }

    }
}

// 読み込み