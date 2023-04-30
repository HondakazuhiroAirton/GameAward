using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect4 : MonoBehaviour
{

    public Button world;

    public GameObject Stage4;
    public GameObject Sel;
    private GameObject SM;

    Image fadeImage;                //透明度を変更するパネルのイメージ

    // Start is called before the first frame update
    void Start()
    {
        SM = GameObject.Find("StageManager");
        fadeImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onButtonStage4_1()
    {
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(15);
    }

    public void onButtonStage4_2()
    {
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(16);
    }

    public void onButtonStage4_3()
    {
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(17);
    }

    public void onButtonStage4_4()
    {
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(18);
    }

    public void onButtonStage4_5()
    {
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(19);
    }

    public void onButtonCancel()
    {
        Sel.SetActive(true);
        world.Select();
        Stage4.SetActive(false);
    }
}
