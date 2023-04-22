using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect4 : MonoBehaviour
{

    public Button Stage4_1;
    public Button Stage4_2;
    public Button Stage4_3;
    public Button Stage4_4;
    public Button Stage4_5;

    public Button Cancel;

    public GameObject Stage4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onButtonStage4_1()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage4_2()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage4_3()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage4_4()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage4_5()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonCancel()
    {
        Stage4.SetActive(false);
    }
}
