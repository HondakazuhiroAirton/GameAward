using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //SceneManagementの機能を使用

public class SceneChange : MonoBehaviour
{
    GameObject TitleScene;
    GameObject EndScene;
    
    // Update is called once per frame
    void Update()
    {
        //もし入力されたキーがEnterキーなら
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //プレイ画面へ
            SceneManager.LoadScene("MainScene");
        }

        //if(Input.GetKeyDown(KeyCode.Return)&& SceneManager.GetActiveScene().name == "EndScene")
        //{   //タイトルシーンへ
        //    SceneManager.LoadScene("TitleScene");
        //}
    }
}

