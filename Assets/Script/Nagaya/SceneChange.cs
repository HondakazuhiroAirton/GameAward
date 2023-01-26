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
<<<<<<< HEAD
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    //TitleSceneに切り替え
        //    SceneManager.LoadScene("TitleScene(Nagaya)");
        //}
=======
       // if (Input.GetKeyDown(KeyCode.Space))
       // {
       //     //TitleSceneに切り替え
       //     SceneManager.LoadScene("TitleScene(Nagaya)");
       // }
>>>>>>> feature/nagaya

        //もし入力されたキーがEnterキーなら
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //TitleSceneに切り替え
            SceneManager.LoadScene("debugScene");
        }

        //もし入力されたキーがEnterKeyなら
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    //EndSceneに切り替え
        //    SceneManager.LoadScene("GameOverScene");
        //}
    }

    
}

