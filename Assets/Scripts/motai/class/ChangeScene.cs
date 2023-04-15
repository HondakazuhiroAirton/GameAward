using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // インスペクタービューから設定するシーン名
    public string sceneName;

    // インスペクタービューから設定したシーンを読み込む
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
