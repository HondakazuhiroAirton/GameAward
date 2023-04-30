using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect3 : MonoBehaviour
{
    public Button world;

    public GameObject Stage3;
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

    public void onButtonStage3_1()
    {
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(10);
    }

    public void onButtonStage3_2()
    {
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(11);
    }

    public void onButtonStage3_3()
    {
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(12);
    }

    public void onButtonStage3_4()
    {
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(13);
    }

    public void onButtonStage3_5()
    {
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(14);
    }

    public void onButtonCancel()
    {
        Sel.SetActive(true);
        world.Select();
        Stage3.SetActive(false);
    }
}
