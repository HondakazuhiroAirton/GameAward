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

    //SE
    public AudioManager SE;
    private Button buttonflag;//ぼたんを一回だけ押す処理

    private Cursoll cursoll;

    // Start is called before the first frame update
    void Awake()
    {
        SM = GameObject.Find("StageManager");
        fadeImage = GetComponent<Image>();

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

    public void onButtonStage3_1()
    {
        if (cursoll.Bflag() == true)
        {
            buttonflag = GameObject.Find("3-1").GetComponent<Button>();
            buttonflag.interactable = false;
            SE.playselectSE();
            fadeImage.GetComponent<Fade>().GameStart();
            SM.GetComponent<StageManagerScript>().SetStageIndex(10);
        }
    }

    public void onButtonStage3_2()
    {
        buttonflag = GameObject.Find("3-2").GetComponent<Button>();
        buttonflag.interactable = false;
        SE.playselectSE();
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(11);
    }

    public void onButtonStage3_3()
    {
        buttonflag = GameObject.Find("3-3").GetComponent<Button>();
        buttonflag.interactable = false;
        SE.playselectSE();
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(12);
    }

    public void onButtonStage3_4()
    {
        buttonflag = GameObject.Find("3-4").GetComponent<Button>();
        buttonflag.interactable = false;
        SE.playselectSE();
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(13);
    }

    public void onButtonStage3_5()
    {
        buttonflag = GameObject.Find("3-5").GetComponent<Button>();
        buttonflag.interactable = false;
        SE.playselectSE();
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(14);
    }

    public void onButtonCancel()
    {
        Sel.SetActive(true);
        world.Select();
        Stage3.SetActive(false);
        cursoll.Updateflag();
    }
}
