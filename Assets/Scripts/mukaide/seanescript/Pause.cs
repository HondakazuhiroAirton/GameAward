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

    public GameObject Image;

    // Start is called before the first frame update
    void Start()
    {
        //Fadeの取得
        Image = GameObject.Find("Image");
    }

    void Awake()
    {

        //ボタンの読み込み
        resume = GameObject.Find("Resume").GetComponent<Button>();
        restart = GameObject.Find("Restart").GetComponent<Button>();
        stageselect = GameObject.Find("StageSelect").GetComponent<Button>();
        pauseUI = GameObject.Find("PousePanel");

        Time.timeScale = 1f;

        pauseUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            //　ポーズUIのアクティブ、非アクティブを切り替え
            pauseUI.SetActive(!pauseUI.activeSelf);
            

            //ボタンが選択された状態になる
            resume.Select();

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
        Image.GetComponent<Fade>().GameSelect();
    }

    public void ButtonRestart()
    {
        Image.GetComponent<Fade>().GameStart();
    }
}
