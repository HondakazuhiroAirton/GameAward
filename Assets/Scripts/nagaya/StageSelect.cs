using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{

    public Button world;

    //�@�|�[�Y�������ɕ\������UI
    [SerializeField]
    private GameObject Stage1UI;
    public GameObject Sel;
    private GameObject SM;

    // ���̈ʒu�����Ă����ϐ�
    [SerializeField] private int NowPosition;

    Image fadeImage;                //�����x��ύX����p�l���̃C���[�W


    // Start is called before the first frame update
    void Start()
    {
        SM = GameObject.Find("StageManager");
        fadeImage = GameObject.Find("Image").GetComponent<Image>();
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void onButtonStage1_1()
    {
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(0);
    }

    public void onButtonStage1_2()
    {
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(1);
    }

    public void onButtonStage1_3()
    {
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(2);
    }

    public void onButtonStage1_4()
    {
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(3);
    }

    public void onButtonStage1_5()
    {
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(4);
    }

    public void onButtonCancel()
    {
        Sel.SetActive(true);
        world.Select();
        Stage1UI.SetActive(false);
    }
}
