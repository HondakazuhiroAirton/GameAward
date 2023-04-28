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

    // Start is called before the first frame update
    void Start()
    {
        SM = GameObject.Find("StageManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onButtonStage2_1()
    {
        SM.GetComponent<StageManagerScript>().SetStageIndex(5);
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage2_2()
    {
        SM.GetComponent<StageManagerScript>().SetStageIndex(6);
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage2_3()
    {
        SM.GetComponent<StageManagerScript>().SetStageIndex(7);
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage2_4()
    {
        SM.GetComponent<StageManagerScript>().SetStageIndex(8);
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage2_5()
    {
        SM.GetComponent<StageManagerScript>().SetStageIndex(9);
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonCancel()
    {
        Sel.SetActive(true);
        world.Select();
        Stage2.SetActive(false);
    }
}
