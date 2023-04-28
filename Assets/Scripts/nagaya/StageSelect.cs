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
    



    // Start is called before the first frame update
    void Start()
    {
        SM = GameObject.Find("StageManager");
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void onButtonStage1_1()
    {
        SM.GetComponent<StageManagerScript>().SetStageIndex(0);
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage1_2()
    {
        SM.GetComponent<StageManagerScript>().SetStageIndex(1);
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage1_3()
    {
        SM.GetComponent<StageManagerScript>().SetStageIndex(2);
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage1_4()
    {
        SM.GetComponent<StageManagerScript>().SetStageIndex(3);
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage1_5()
    {
        SM.GetComponent<StageManagerScript>().SetStageIndex(4);
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonCancel()
    {
        Sel.SetActive(true);
        world.Select();
        Stage1UI.SetActive(false);
    }
}
