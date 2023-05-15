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

    public GameObject Image;

    ResultUI Resulte;

    // Start is called before the first frame update
    void Start()
    {
        //Fade�̎擾
        Image = GameObject.Find("Image");

        Resulte = GameObject.Find("Result").GetComponent<ResultUI>();
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
        if (Resulte.rankflag() == true)
        {
            //�f�o�b�N�p
            if (Input.GetKeyDown(KeyCode.O))
            {
                // �p�l��UI�̃A�N�e�B�u��A�N�e�B�u��؂�ւ�
                continueUI.SetActive(true);

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

        }

        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }

    }

    public void ButtonStageSelect()
    {
        Image.GetComponent<Fade>().GameSelect();
    }

    public void ButtonRetry()
    {
        Image.GetComponent<Fade>().GameStart();
    }

    public void ButtonNextStage()
    {
        SceneManager.LoadScene("GameScene");
    }



}
