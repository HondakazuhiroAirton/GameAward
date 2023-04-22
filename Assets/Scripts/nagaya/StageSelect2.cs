using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect2 : MonoBehaviour
{
    public Button Stage2_1;
    public Button Stage2_2;
    public Button Stage2_3;
    public Button Stage2_4;
    public Button Stage2_5;

    public Button Cancel;

    public GameObject Stage2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onButtonStage2_1()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage2_2()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage2_3()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage2_4()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage2_5()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonCancel()
    {
        Stage2.SetActive(false);
    }
}
