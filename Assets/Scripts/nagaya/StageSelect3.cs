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

    // Start is called before the first frame update
    void Start()
    {
        SM = GameObject.Find("StageManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onButtonStage3_1()
    {
        SM.GetComponent<StageManagerScript>().SetStageIndex(10);
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage3_2()
    {
        SM.GetComponent<StageManagerScript>().SetStageIndex(11);
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage3_3()
    {
        SM.GetComponent<StageManagerScript>().SetStageIndex(12);
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage3_4()
    {
        SM.GetComponent<StageManagerScript>().SetStageIndex(13);
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage3_5()
    {
        SM.GetComponent<StageManagerScript>().SetStageIndex(14);
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonCancel()
    {
        Sel.SetActive(true);
        world.Select();
        Stage3.SetActive(false);
    }
}
