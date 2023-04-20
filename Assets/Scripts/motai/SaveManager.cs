using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; // UnityJsonを使う場合に必要
using System.IO; // ファイル書き込みに必要

[Serializable]
public struct SaveData
{
    public int stage1;
    public int stage2;
    public int stage3;
    public int stage4;
    public int stage5;

    public void Dump()
    {
        Debug.Log("stage1 = " + stage1);
        Debug.Log("stage2 = " + stage2);
        Debug.Log("stage3 = " + stage3);
        Debug.Log("stage4 = " + stage4);
        Debug.Log("stage5 = " + stage5);
    }
}

/// <summary>
/// セーブデータ管理
/// </summary>
public class SaveManager : MonoBehaviour
{
    // 保存するファイル
    const string SAVE_FILE_PATH = "save.txt";
    public int goal;

    void Update()
    {
        if (goal == 1)     // Input.GetKeyDown(KeyCode.S)// Sキーでセーブ実行
        {
            // goalの数が10とになると保存
            var data = new SaveData();
            data.stage1 = 1;
            // JSONにシリアライズ
            var json = JsonUtility.ToJson(data);
            // Assetsフォルダに保存する
            var path = Application.dataPath + "/" + SAVE_FILE_PATH;
            var writer = new StreamWriter(path, false); // 上書き
            writer.WriteLine(json);
            writer.Flush();
            writer.Close();
        }
        if (goal == 10) //1-1がクリアしたら
        {
            // goalの数が10とになると保存
            var data = new SaveData();
            data.stage1 = 2;
            data.stage2 = 1;
            // JSONにシリアライズ
            var json = JsonUtility.ToJson(data);
            // Assetsフォルダに保存する
            var path = Application.dataPath + "/" + SAVE_FILE_PATH;
            var writer = new StreamWriter(path, false); // 上書き
            writer.WriteLine(json);
            writer.Flush();
            writer.Close();
            goal = 10;
        }
        if (goal == 20) //1-2がクリアしたら
        {
            // goalの数が20とになると保存
            var data = new SaveData();
            data.stage1 = 2;
            data.stage2 = 2;
            data.stage3 = 1;
            // JSONにシリアライズ
            var json = JsonUtility.ToJson(data);
            // Assetsフォルダに保存する
            var path = Application.dataPath + "/" + SAVE_FILE_PATH;
            var writer = new StreamWriter(path, false); // 上書き
            writer.WriteLine(json);
            writer.Flush();
            writer.Close();
            goal = 20;
        }
        if (goal == 30) //1-3がクリアしたら
        {
            // goalの数が30とになると保存
            var data = new SaveData();
            data.stage1 = 2;
            data.stage2 = 2;
            data.stage3 = 2;
            data.stage4 = 1;
            // JSONにシリアライズ
            var json = JsonUtility.ToJson(data);
            // Assetsフォルダに保存する
            var path = Application.dataPath + "/" + SAVE_FILE_PATH;
            var writer = new StreamWriter(path, false); // 上書き
            writer.WriteLine(json);
            writer.Flush();
            writer.Close();
            goal = 30;
        }
        if (goal == 40) //1-4がクリアしたら
        {
            // goalの数が40とになると保存
            var data = new SaveData();
            data.stage1 = 2;
            data.stage2 = 2;
            data.stage3 = 2;
            data.stage4 = 2;
            data.stage5 = 1;
            // JSONにシリアライズ
            var json = JsonUtility.ToJson(data);
            // Assetsフォルダに保存する
            var path = Application.dataPath + "/" + SAVE_FILE_PATH;
            var writer = new StreamWriter(path, false); // 上書き
            writer.WriteLine(json);
            writer.Flush();
            writer.Close();
            goal = 40;
        }
        if (goal == 50) //1-5がクリアしたら
        {
            // goalの数が50とになると保存
            var data = new SaveData();
            data.stage1 = 2;
            data.stage2 = 2;
            data.stage3 = 2;
            data.stage4 = 2;
            data.stage5 = 2;
            // JSONにシリアライズ
            var json = JsonUtility.ToJson(data);
            // Assetsフォルダに保存する
            var path = Application.dataPath + "/" + SAVE_FILE_PATH;
            var writer = new StreamWriter(path, false); // 上書き
            writer.WriteLine(json);
            writer.Flush();
            writer.Close();
            goal = 50;
        }

        if (Input.GetKeyDown(KeyCode.L))
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
