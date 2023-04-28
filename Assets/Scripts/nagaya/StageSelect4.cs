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
        Sel.SetActive(true);
        world.Select();
        Stage4.SetActive(false);
    }
}
