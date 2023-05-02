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
     GameObject Combo;
     GameObject Numenemy;
     GameObject Beam;
     TextMeshProUGUI Score;


    //テキストオブジェクト取得  
    TextMeshProUGUI Cm;
    TextMeshProUGUI Ne;
    TextMeshProUGUI Bm;
    TextMeshProUGUI Rs;
    TextMeshProUGUI Ts;

    static int combo;       //コンボ
    static int numenemy;    //倒した敵
    static int beam;        //ビーム
    static int score;       //スコア
    static int totalscore;  //合計

    // Start is called before the first frame update

  

    void Start()
    {
        //初期化
        combo = 0;
        numenemy = 0;
        beam = 100;
        score = 0;
        totalscore = 0;

        //コンボ
        //Combo = GameObject.Find("");
        Cm = GameObject.Find("Combo").GetComponent<TextMeshProUGUI>();

        //倒した敵
        //Numenemy = GameObject.Find("");
        Ne = GameObject.Find("NumEnemy").GetComponent<TextMeshProUGUI>();

        //ビーム
        //Beam = GameObject.Find("");
        Bm = GameObject.Find("Beam").GetComponent<TextMeshProUGUI>();

        //スコアの取得
        Score = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
        Rs = GameObject.Find("ResultScore").GetComponent<TextMeshProUGUI>();

        //合計
        Ts = GameObject.Find("TotalScore").GetComponent<TextMeshProUGUI>();

        resultUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("k"))
        {
            // パネルUIのアクティブ非アクティブを切り替え
            Active();
            //タイマーを止める
            Time.timeScale = 0f;

            //テキスト表示
            score = Score.GetComponent<Score>().ResultScore();
            Rs.text = "Score: " + score.ToString();




            //合計の計算
            totalscore = combo + numenemy + beam + score;
            Ts.text = "TotalScore: " + totalscore.ToString();

        }
    }

    public void Active()
    {
        //パネルUIのアクティブ、非アクティブを切り替え
        resultUI.SetActive(!resultUI.activeSelf);
    }
}
