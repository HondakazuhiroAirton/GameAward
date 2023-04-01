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
        //�{�^���̓ǂݍ���
        stageselect = GameObject.Find("StageSelect").GetComponent<Button>();
        retry = GameObject.Find("Retry").GetComponent<Button>();
        nextstage = GameObject.Find("NextStage").GetComponent<Button>();

        //�{�^�����I�����ꂽ��ԂɂȂ�
        retry.Select();


        continueUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("v"))
        {
           // SetActive();
        // �p�l��UI�̃A�N�e�B�u��A�N�e�B�u��؂�ւ�
        continueUI.SetActive(!continueUI.activeSelf);
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

//   public void SetActive()
//   {
//       //�p�l��UI�̃A�N�e�B�u�A��A�N�e�B�u��؂�ւ�
//       continueUI.SetActive(!continueUI.activeSelf);
//   }

}
