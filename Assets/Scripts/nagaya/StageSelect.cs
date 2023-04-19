using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    public Button Stage1_1;
    public Button Stage1_2;
    public Button Stage1_3;
    public Button Stage1_4;
    public Button Stage1_5;

    public Button Cancel;

    public GameObject Stage1;


    // Start is called before the first frame update
    void Start()
    {
        Stage1_1.Select();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onButtonStage1_1()
    {
        SceneManager.LoadScene("Stage1");
    }

    

    public void onButtonCancel()
    {
        Stage1.SetActive(false);
    }
}
