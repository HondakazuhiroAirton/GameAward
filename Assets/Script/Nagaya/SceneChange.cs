using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //SceneManagement�̋@�\���g�p

public class SceneChange : MonoBehaviour
{
    GameObject TitleScene;
    GameObject EndScene;
    
    // Update is called once per frame
    void Update()
    {
        //�������͂��ꂽ�L�[��Enter�L�[�Ȃ�
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //�v���C��ʂ�
            SceneManager.LoadScene("MainScene");
        }

        //if(Input.GetKeyDown(KeyCode.Return)&& SceneManager.GetActiveScene().name == "EndScene")
        //{   //�^�C�g���V�[����
        //    SceneManager.LoadScene("TitleScene");
        //}
    }
}

