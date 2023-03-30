using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    //　ポーズした時に表示するUI
    [SerializeField]
    private GameObject pauseUI;

    //ボタン設定
    private Button resume;
    private Button restart;
    private Button stageselect;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;

        //ボタンの読み込み
        resume = GameObject.Find("Resume").GetComponent<Button>();
        restart = GameObject.Find("Restart").GetComponent<Button>();
        stageselect = GameObject.Find("StageSelect").GetComponent<Button>();

        //ボタンが選択された状態になる
        resume.Select();


        pauseUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            //　ポーズUIのアクティブ、非アクティブを切り替え
            pauseUI.SetActive(!pauseUI.activeSelf);

            //　ポーズUIが表示されてる時は停止
            if (pauseUI.activeSelf)
            {
                Time.timeScale = 0f;
                //　ポーズUIが表示されてなければ通常通り進行  
            }
            else
            {              
               Time.timeScale = 1f;
            }
        }

        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }
    }

    public void ButtonContinue()
    {
        //　ポーズUIのアクティブ、非アクティブを切り替え
        pauseUI.SetActive(!pauseUI.activeSelf);


        //　ポーズUIが表示されてる時は停止
        if (pauseUI.activeSelf)
        {
            Time.timeScale = 0f;
            //　ポーズUIが表示されてなければ通常通り進行  
        }
        else
        {
            Time.timeScale = 1f;
        }

        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }
    }

    public void ButtonStage()
    {
        SceneManager.LoadScene("StageSelect");
    }

    public void ButtonRestart()
    {
        SceneManager.LoadScene("GameScene");
    }
}
