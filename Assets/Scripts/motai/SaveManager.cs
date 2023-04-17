using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; // UnityJsonを使う場合に必要
using System.IO; // ファイル書き込みに必要

[Serializable]
public struct SaveData
{
    public int x;
    public int y;

    public void Dump()
    {
        Debug.Log("x = " + x);
        Debug.Log("y = " + y);
    }
}

/// <summary>
/// セーブデータ管理
/// </summary>
public class SaveManager : MonoBehaviour
{
    // 保存するファイル
    const string SAVE_FILE_PATH = "save.txt";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            // Sキーでセーブ実行
            var data = new SaveData();
            data.x = 5;
            data.y = 7;
            // JSONにシリアライズ
            var json = JsonUtility.ToJson(data);
            // Assetsフォルダに保存する
            var path = Application.dataPath + "/" + SAVE_FILE_PATH;
            var writer = new StreamWriter(path, false); // 上書き
            writer.WriteLine(json);
            writer.Flush();
            writer.Close();
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            // Lキーでロード実行
            // Assetsフォルダからロード
            var info = new FileInfo(Application.dataPath + "/" + SAVE_FILE_PATH);
            var reader = new StreamReader(info.OpenRead());
            var json = reader.ReadToEnd();
            var data = JsonUtility.FromJson<SaveData>(json);
            data.Dump();
        }
    }
}
