using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //SceneManagement�̋@�\���g�p

public class SceneChange : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        //�������͂��ꂽ�L�[��space�L�[�Ȃ璆�̏��������s����
       // if (Input.GetKeyDown(KeyCode.Space))
       // {
       //     //TitleScene�ɐ؂�ւ�
       //     SceneManager.LoadScene("TitleScene(Nagaya)");
       // }

        //�������͂��ꂽ�L�[��Enter�L�[�Ȃ�
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //TitleScene�ɐ؂�ւ�
            SceneManager.LoadScene("NagayaScene");
        }

        //�������͂��ꂽ�L�[��EnterKey�Ȃ�
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    //EndScene�ɐ؂�ւ�
        //    SceneManager.LoadScene("GameOverScene");
        //}
    }

    
}

