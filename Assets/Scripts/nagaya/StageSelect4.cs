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

    // Start is called before the first frame update
    void Start()
    {
        SM = GameObject.Find("StageManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onButtonStage4_1()
    {
        SM.GetComponent<StageManagerScript>().SetStageIndex(15);
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage4_2()
    {
        SM.GetComponent<StageManagerScript>().SetStageIndex(16);
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage4_3()
    {
        SM.GetComponent<StageManagerScript>().SetStageIndex(17);
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage4_4()
    {
        SM.GetComponent<StageManagerScript>().SetStageIndex(18);
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage4_5()
    {
        SM.GetComponent<StageManagerScript>().SetStageIndex(19);
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonCancel()
    {
        Sel.SetActive(true);
        world.Select();
        Stage4.SetActive(false);
    }
}
