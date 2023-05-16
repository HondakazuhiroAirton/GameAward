using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{

    public Button world;

    //　ポーズした時に表示するUI
    [SerializeField]
    private GameObject Stage1UI;
    public GameObject Sel;
    private GameObject SM;

    // 今の位置を入れておく変数
    [SerializeField] private int NowPosition;

    Image fadeImage;                //透明度を変更するパネルのイメージ

    //SE
    public AudioManager SE;
    private Button buttonflag;//ぼたんを一回だけ押す処理

    // Start is called before the first frame update
    void Start()
    {
        SM = GameObject.Find("StageManager");
        fadeImage = GameObject.Find("Image").GetComponent<Image>();
        //SE
        SE = GameObject.Find("AudioManage").GetComponent<AudioManager>();
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void onButtonStage1_1()
    {
        buttonflag = GameObject.Find("1-1").GetComponent<Button>();
        buttonflag.interactable = false;
        SE.playselectSE();
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(0);
    }

    public void onButtonStage1_2()
    {
        buttonflag = GameObject.Find("1-2").GetComponent<Button>();
        buttonflag.interactable = false;
        SE.playselectSE();
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(1);
    }

    public void onButtonStage1_3()
    {
        buttonflag = GameObject.Find("1-3").GetComponent<Button>();
        buttonflag.interactable = false;
        SE.playselectSE();
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(2);
    }

    public void onButtonStage1_4()
    {
        buttonflag = GameObject.Find("1-4").GetComponent<Button>();
        buttonflag.interactable = false;
        SE.playselectSE();
        fadeImage.GetComponent<Fade>().GameStart();
        SM.GetComponent<StageManagerScript>().SetStageIndex(3);
    }

    public void onButtonStage1_5()
    {
        buttonflag = GameObject.Find("1-5").GetComponent<Button>();
        buttonflag.interactable = false;
        SE.playselectSE();
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
