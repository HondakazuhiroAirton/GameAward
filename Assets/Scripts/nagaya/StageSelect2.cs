using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect2 : MonoBehaviour
{
    public Button world;

    public GameObject Stage2;
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

    public void onButtonStage2_1()
    {
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(5);
    }

    public void onButtonStage2_2()
    {
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(6);
    }

    public void onButtonStage2_3()
    {
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(7);
    }

    public void onButtonStage2_4()
    {
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(8);
    }

    public void onButtonStage2_5()
    {
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(9);
    }

    public void onButtonCancel()
    {
        Sel.SetActive(true);
        world.Select();
        Stage2.SetActive(false);
    }
}
