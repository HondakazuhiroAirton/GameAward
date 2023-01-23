using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //SceneManagementの機能を使用

public class SceneChange : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {

        //もし入力されたキーがEnterキーなら
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //TitleSceneに切り替え
            SceneManager.LoadScene("MainScene");
        }
    }

    
}

