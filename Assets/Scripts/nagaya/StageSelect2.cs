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

    //SE
    public AudioManager SE;
    private Button buttonflag;//ぼたんを一回だけ押す処理

    // Start is called before the first frame update
    void Awake()
    {
        SM = GameObject.Find("StageManager");
        fadeImage = GetComponent<Image>();

        //SE
        SE = GameObject.Find("AudioManage").GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {

            SE.playCusolSE();
        }
    }

    public void onButtonStage2_1()
    {
        buttonflag = GameObject.Find("2-1").GetComponent<Button>();
        buttonflag.interactable = false;
        SE.playselectSE();
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(5);
    }

    public void onButtonStage2_2()
    {
        buttonflag = GameObject.Find("2-2").GetComponent<Button>();
        buttonflag.interactable = false;
        SE.playselectSE();
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(6);
    }

    public void onButtonStage2_3()
    {
        buttonflag = GameObject.Find("2-3").GetComponent<Button>();
        buttonflag.interactable = false;
        SE.playselectSE();
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(7);
    }

    public void onButtonStage2_4()
    {
        buttonflag = GameObject.Find("2-4").GetComponent<Button>();
        buttonflag.interactable = false;
        SE.playselectSE();
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(8);
    }

    public void onButtonStage2_5()
    {
        buttonflag = GameObject.Find("2-5").GetComponent<Button>();
        buttonflag.interactable = false;
        SE.playselectSE();
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
