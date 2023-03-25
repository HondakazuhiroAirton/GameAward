using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTranslation : MonoBehaviour
{

    public void ButtonStage()
    {
        SceneManager.LoadScene("StageSelect");
    }

    public void ButtonRestart()
    {
        SceneManager.LoadScene("GameScene");
    }
}
