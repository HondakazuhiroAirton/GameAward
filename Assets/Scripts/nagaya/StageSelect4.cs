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

    //SE
    public AudioManager SE;
    private Button buttonflag;//ぼたんを一回だけ押す処理

    private Cursoll cursoll;

    // Start is called before the first frame update
    void Awake()
    {
        SM = GameObject.Find("StageManager");
        fadeImage = GameObject.Find("Image").GetComponent<Image>();

        //SE
        SE = GameObject.Find("AudioManage").GetComponent<AudioManager>();
        cursoll = GameObject.Find("Triangle").GetComponent<Cursoll>();
    }


    // Update is called once per frame
    void Update()
    {



        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {

            SE.playCusolSE();
        }
    }

    public void onButtonStage4_1()
    {
        if (cursoll.Bflag() == true)
        {
            buttonflag = GameObject.Find("4-1").GetComponent<Button>();
            buttonflag.interactable = false;
            SE.playselectSE();
            fadeImage.GetComponent<Fade>().GameStart();
            SM.GetComponent<StageManagerScript>().SetStageIndex(15);
        }
    }

    public void onButtonStage4_2()
    {
        buttonflag = GameObject.Find("4-2").GetComponent<Button>();
        buttonflag.interactable = false;
        SE.playselectSE();
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(16);
    }

    public void onButtonStage4_3()
    {
        buttonflag = GameObject.Find("4-3").GetComponent<Button>();
        buttonflag.interactable = false;
        SE.playselectSE();
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(17);
    }

    public void onButtonStage4_4()
    {
        buttonflag = GameObject.Find("4-4").GetComponent<Button>();
        buttonflag.interactable = false;
        SE.playselectSE();
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(18);
    }

    public void onButtonStage4_5()
    {
        buttonflag = GameObject.Find("4-5").GetComponent<Button>();
        buttonflag.interactable = false;
        SE.playselectSE();
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(19);
    }

    public void onButtonCancel()
    {
        Sel.SetActive(true);
        world.Select();
        cursoll.Updateflag();
        Stage4.SetActive(false);
    }
}
