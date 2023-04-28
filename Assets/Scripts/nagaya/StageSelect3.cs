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


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onButtonStage3_1()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage3_2()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage3_3()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage3_4()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage3_5()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonCancel()
    {
        Sel.SetActive(true);
        world.Select();
        Stage3.SetActive(false);
    }
}
