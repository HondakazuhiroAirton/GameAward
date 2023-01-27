using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CircleCollision : MonoBehaviour
{
    public int addText;
    GameObject MainScene;
    GameObject SecondStage;
    GameObject ThirdStage;
    GameObject EndScene;

    int SceneCount;
    bool SceneChangeFlag;

    // Start is called before the first frame update
    void Start()
    {
        addText = 0;
        SceneCount = 0;
        SceneChangeFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneChangeFlag)
        {
            switch (SceneCount)
            {
                case 0: //MainScene
                    if (SceneManager.GetActiveScene().name == "MainScene")
                    {
                        SceneManager.LoadScene("SecondStage");
                    }
                    break;
                case 1: //SecondStage
                    if (SceneManager.GetActiveScene().name == "SecondStage")
                    {
                        SceneManager.LoadScene("ThirdStage");
                    }
                    break;
                case 2: //ThirdStage
                    if (SceneManager.GetActiveScene().name == "ThirdStage")
                    {
                        SceneManager.LoadScene("EndScene");
                    }
                    break;
            }
            SceneChangeFlag = false;
            SceneCount++;
        }     
    }

    public void SceneChange()
    {
        SceneChangeFlag = true;
    }

    void GoToGameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }

}


