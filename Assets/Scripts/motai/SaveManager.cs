using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; // UnityJsonを使う場合に必要
using System.IO; // ファイル書き込みに必要
using UnityEditor;//EditorApplicationを使うの必要


[Serializable]
public struct SaveData
{
    public int stage;
    public int stage2;
    public int stage3;
    //public int stage4;
    //public int stage5;
    //public int CS;

    public void Dump()
    {
        Debug.Log("stage = " + stage);
        Debug.Log("stage2 = " + stage2);
        Debug.Log("stage3 = " + stage3);
        //Debug.Log("stage4 = " + stage4);
        //Debug.Log("stage5 = " + stage5);
        //Debug.Log("CS：" + CS);
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
    public int goal2;
    public int goal3;

    void Start()
    {
        
    }

        void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))     // Input.GetKeyDown(KeyCode.S)// Sキーでセーブ実行
        {
            goal += 1;
            // goalの数が10とになると保存
            var data = new SaveData();
            data.stage = 1;
            // JSONにシリアライズ
            var json = JsonUtility.ToJson(data);
            // Assetsフォルダに保存する
            var path = Application.dataPath + "/" + SAVE_FILE_PATH;
            var writer = new StreamWriter(path, false); // 上書き
            writer.WriteLine(json);
            writer.Flush();
            writer.Close();
        }
        

        //if (Input.GetKeyDown(KeyCode.L))
        /*if (Input.GetKeyDown(KeyCode.L))
        {
            // Lキーでロード実行
            // Assetsフォルダからロード
            var info = new FileInfo(Application.dataPath + "/" + SAVE_FILE_PATH);
            var reader = new StreamReader(info.OpenRead());
            var json = reader.ReadToEnd();
            var data = JsonUtility.FromJson<SaveData>(json);
            data.Dump();
            //goal = data.CS;
            data.CS = goal;
        }*/
    }

    [InitializeOnLoad]//エディター起動時にコンストラクタが呼ばれるように
    public static class PlayModeStateChangedExample
    {

        /// <summary>
        /// コンストラクタ(InitializeOnLoad属性によりエディター起動時に呼び出される)
        /// </summary>
        static PlayModeStateChangedExample()
        {

            //playModeStateChangedイベントにメソッド登録
            EditorApplication.playModeStateChanged += OnChangedPlayMode;

        }

        public static int goal { get; private set; }
        public static int goal2 { get; private set; }
        public static int goal3 { get; private set; }

        //プレイモードが変更された
        private static void OnChangedPlayMode(PlayModeStateChange state)
        {
            if (state == PlayModeStateChange.ExitingEditMode)
            {
                Debug.Log("停止状態の終了開始！(実行ボタンを押した)");
                var info = new FileInfo(Application.dataPath + "/" + SAVE_FILE_PATH);
                var reader = new StreamReader(info.OpenRead());
                var json = reader.ReadToEnd();
                var data = JsonUtility.FromJson<SaveData>(json);
                data.Dump();

                Debug.Log("goal:" + goal);
                Debug.Log("goal2:" + goal2);
                Debug.Log("goal3:" + goal3);
            }
        }
    }
}
