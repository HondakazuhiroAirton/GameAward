using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //SceneManagement�̋@�\���g�p

public class SceneChange : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {

        //�������͂��ꂽ�L�[��Enter�L�[�Ȃ�
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //TitleScene�ɐ؂�ւ�
            SceneManager.LoadScene("MainScene");
        }
    }

    
}

