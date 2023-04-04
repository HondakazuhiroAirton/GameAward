using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResultUI : MonoBehaviour
{
    //クリア時に表示するUI
    [SerializeField]
    private GameObject resultUI;

    //変数取得のためのオブジェクト取得
    //＜関数読み取りのためゲームオブジェクト取得してます＞
    public GameObject Score;
 

    //テキストオブジェクト取得  
    TextMeshProUGUI Cm;
    TextMeshProUGUI Ne;
    TextMeshProUGUI Bm;
    TextMeshProUGUI Rs;
    TextMeshProUGUI Ts;


    static int score;

    // Start is called before the first frame update
    void Start()
    {
       ////コンボ
       //Cm = GameObject.Find("Combo").GetComponent<TextMeshProUGUI>();
       //
       ////倒した敵
       //Ne = GameObject.Find("Numenemy").GetComponent<TextMeshProUGUI>();
       //
       ////ビーム
       //Bm = GameObject.Find("Beam").GetComponent<TextMeshProUGUI>();

        //スコアの取得
        Score = GameObject.Find("Score");
        Rs = GameObject.Find("ResultScore").GetComponent<TextMeshProUGUI>();

        ////合計
        //Ts = GameObject.Find("TotalScore").GetComponent<TextMeshProUGUI>();

        resultUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("k"))
        {
            // パネルUIのアクティブ非アクティブを切り替え
            Active();

            //テキスト表示
            score = Score.GetComponent<Score>().ResultScore();
            Rs.text = "Score: " + score.ToString();

            //タイマーを止める
            Time.timeScale = 0f;
        }
    }

    public void Active()
    {
        //パネルUIのアクティブ、非アクティブを切り替え
        resultUI.SetActive(!resultUI.activeSelf);
    }
}
