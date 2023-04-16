using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // �C���X�y�N�^�[�r���[����ݒ肷��V�[����
    public string sceneName;
    //�{�^���ݒ�
    private Button Retry;
    private Button StageSelect;
    private GameObject GameOver;

    public GameObject Image;

    void Start()
    {
        //Fade�̎擾
        Image = GameObject.Find("Image");
    }

    void Awake()
    {

        //�{�^���̓ǂݍ���
        Retry = GameObject.Find("RetryButton").GetComponent<Button>();
        StageSelect = GameObject.Find("SelectButton").GetComponent<Button>();

        //Time.timeScale = 1f;

        GameOver.SetActive(false);
    }
    // �C���X�y�N�^�[�r���[����ݒ肵���V�[����ǂݍ���
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ButtonStageSelect()
    {
        Image.GetComponent<Fade>().GameSelect();
    }

    public void ButtonRetry()
    {
        Image.GetComponent<Fade>().GameStart();
    }
}
