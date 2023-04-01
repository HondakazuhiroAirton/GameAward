using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{

    //�@�|�[�Y�������ɕ\������UI
    [SerializeField]
    private GameObject continueUI;

    //�{�^���ݒ�
    private Button stageselect;
    private Button retry;
    private Button nextstage;


    // Start is called before the first frame update
    void Start()
    {

    }

    void Awake()
    {
        //�{�^���̓ǂݍ���
        stageselect = GameObject.Find("ReturnSelect").GetComponent<Button>();
        retry = GameObject.Find("Retry").GetComponent<Button>();
        nextstage = GameObject.Find("NextStage").GetComponent<Button>();

        continueUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("v"))
        {

            // �p�l��UI�̃A�N�e�B�u��A�N�e�B�u��؂�ւ�
            Active();

            //�{�^�����I�����ꂽ��ԂɂȂ�
            retry.Select();      

            //�@�|�[�YUI���\������Ă鎞�͒�~
            if (continueUI.activeSelf)
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

    public void ButtonStageSelect()
    {
        SceneManager.LoadScene("StageSelect");
    }

    public void ButtonRetry()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ButtonNextStage()
    {
        SceneManager.LoadScene("GameScene");
    }


   public void Active()
   {
       //�p�l��UI�̃A�N�e�B�u�A��A�N�e�B�u��؂�ւ�
       continueUI.SetActive(!continueUI.activeSelf);
   }

}
