using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    //�@�|�[�Y�������ɕ\������UI
    [SerializeField]
    private GameObject pauseUI;

    //�{�^���ݒ�
    private Button resume;
    private Button restart;
    private Button stageselect;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;

        //�{�^���̓ǂݍ���
        resume = GameObject.Find("Resume").GetComponent<Button>();
        restart = GameObject.Find("Restart").GetComponent<Button>();
        stageselect = GameObject.Find("StageSelect").GetComponent<Button>();

        //�{�^�����I�����ꂽ��ԂɂȂ�
        resume.Select();


        pauseUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            //�@�|�[�YUI�̃A�N�e�B�u�A��A�N�e�B�u��؂�ւ�
            pauseUI.SetActive(!pauseUI.activeSelf);

            //�@�|�[�YUI���\������Ă鎞�͒�~
            if (pauseUI.activeSelf)
            {
                Time.timeScale = 0f;
                //�@�|�[�YUI���\������ĂȂ���Βʏ�ʂ�i�s  
            }
            else
            {              
               Time.timeScale = 1f;
            }
        }

        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }
    }

    public void ButtonContinue()
    {
        //�@�|�[�YUI�̃A�N�e�B�u�A��A�N�e�B�u��؂�ւ�
        pauseUI.SetActive(!pauseUI.activeSelf);


        //�@�|�[�YUI���\������Ă鎞�͒�~
        if (pauseUI.activeSelf)
        {
            Time.timeScale = 0f;
            //�@�|�[�YUI���\������ĂȂ���Βʏ�ʂ�i�s  
        }
        else
        {
            Time.timeScale = 1f;
        }

        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }
    }

    public void ButtonStage()
    {
        SceneManager.LoadScene("StageSelect");
    }

    public void ButtonRestart()
    {
        SceneManager.LoadScene("GameScene");
    }
}
