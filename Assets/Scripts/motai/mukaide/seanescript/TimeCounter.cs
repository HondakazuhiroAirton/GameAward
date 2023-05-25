using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TimeCounter : MonoBehaviour
{
    //カウントダウン
    public float countdown;

    //時間を表示するText型の変数
    TextMeshProUGUI timeText;

    public GameObject Image;

    // Start is called before the first frame update
    void Start()
    {
        Image = GameObject.Find("timeText");
        this.timeText = GameObject.Find("timeText").GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        //時間をカウントダウンする
        countdown -= Time.deltaTime;

        //時間を表示する
        this.timeText.text = countdown.ToString("f1") + "秒";

        //countdownが0以下になったとき
        if (countdown <= 0)
        {
            countdown = 0;
            timeText.enabled = false;    //d)パネルの表示をオフにする
            Image.GetComponent<Fade>().GameOver();
        }

        
    }
}
