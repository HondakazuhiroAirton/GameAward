using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //�p�l���̃C���[�W�𑀍삷��̂ɕK�v
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    float fadeSpeed = 0.01f;        //�����x���ς��X�s�[�h���Ǘ�
    float red, green, blue, alfa;   //�p�l���̐F�A�s�����x���Ǘ�

    public bool isFadeOut = false;  //�t�F�[�h�A�E�g�����̊J�n�A�������Ǘ�����t���O
    public bool isFadeIn = false;   //�t�F�[�h�C�������̊J�n�A�������Ǘ�����t���O
    public string changeSceneName; // �t�F�[�h�A�E�g������A�V�[���J�ڂ���ꍇ�̃V�[����

    Image fadeImage;                //�����x��ύX����p�l���̃C���[�W

    public bool isfade;

    void Start()
    {
        fadeImage = GetComponent<Image>();
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;
        isfade = false;
    }

    void Update()
    {

        if (isFadeIn)
        {
            StartFadeIn();
        }

        if (isFadeOut)
        {
            StartFadeOut();
        }
    }

    void StartFadeIn()
    {
        alfa -= fadeSpeed;                //a)�s�����x�����X�ɉ�����
        SetAlpha();                      //b)�ύX�����s�����x�p�l���ɔ��f����
        if (alfa <= 0)
        {                    //c)���S�ɓ����ɂȂ����珈���𔲂���
            isFadeIn = false;
            isfade = false;
        }
    }

    void StartFadeOut()
    {
        isfade = true;
        fadeImage.enabled = true;  // a)�p�l���̕\�����I���ɂ���
        alfa += fadeSpeed;         // b)�s�����x�����X�ɂ�����
        SetAlpha();               // c)�ύX���������x���p�l���ɔ��f����
        if (alfa >= 1.5)
        {             // d)���S�ɕs�����ɂȂ����珈���𔲂���
            isFadeOut = false;
            isFadeIn = true;
            if (changeSceneName != "")
            {
                Debug.Log(changeSceneName + "�ɑJ�ڂ��܂��B");
                SceneManager.LoadScene(changeSceneName);
            }

        }
    }

    void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
    }

    //�@�X�^�[�g�{�^��������������s����
    public void GameStart()
    {
        if (isfade) return;
        isFadeOut = true;
        changeSceneName = "Master_Final2";
    }

    public void GameSelect()
    {
        if (isfade) return;
        isFadeOut = true;
        changeSceneName = "nagaya";
    }

    public void GameTitle()
    {
        if (isfade) return;
        isFadeOut = true;
        changeSceneName = "Title";
    }

    public void GameOver()
    {
        if (isfade) return;
        isFadeOut = true;
        changeSceneName = "GameOver";
    }

    public bool Fadeflag()
    {
        return isfade;
    }
}
