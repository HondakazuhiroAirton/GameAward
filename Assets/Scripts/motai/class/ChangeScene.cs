using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    //ボタン設定
    private Button Retry;
    private Button StageSelect;
    [SerializeField]
    private GameObject GameOver;

    public GameObject Image;

    void Start()
    {
        //Fadeの取得
        Image = GameObject.Find("Image");
        //ボタンが選択された状態になる
        Retry.Select();
    }

    void Awake()
    {

        //ボタンの読み込み
        Retry = GameObject.Find("RetryButton").GetComponent<Button>();
        StageSelect = GameObject.Find("SelectButton").GetComponent<Button>();

        //Time.timeScale = 1f;

        //GameOver.SetActive(false);
    }
    // インスペクタービューから設定したシーンを読み込む
    public void ButtonStageSelect()
    {
        Image.GetComponent<Fade>().GameSelect();
    }

    public void ButtonRetry()
    {
        Image.GetComponent<Fade>().GameStart();
    }
}
