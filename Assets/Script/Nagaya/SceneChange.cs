using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //SceneManagementの機能を使用

public class SceneChange : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        //もし入力されたキーがspaceキーなら中の処理を実行する
       // if (Input.GetKeyDown(KeyCode.Space))
       // {
       //     //TitleSceneに切り替え
       //     SceneManager.LoadScene("TitleScene(Nagaya)");
       // }

        //もし入力されたキーがEnterキーなら
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //TitleSceneに切り替え
            SceneManager.LoadScene("NagayaScene");
        }

        //もし入力されたキーがEnterKeyなら
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    //EndSceneに切り替え
        //    SceneManager.LoadScene("GameOverScene");
        //}
    }

    
}

