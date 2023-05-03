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
    static int i; //トータルスコアで使ってる

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

        }


        //テキスト表示
        if (resultUI.activeSelf == true)
        {
            text(3);

        }
    }

    public void Active()
    {
        //パネルUIのアクティブ、非アクティブを切り替え
        resultUI.SetActive(!resultUI.activeSelf);
        //合計の計算
        totalscore = combo + numenemy + beam + score;
    }

    void text(int no)
    {
        switch(no)
        {
            case 0: //コンボ
                {
                   // if (combo < //<<<コンボの数を持ってくる関数)
                   // {
                   //     combo++;
                   //     Cm.text = combo.ToString();
                   // }
                    break; 
                };
            case 1:
                {//倒した敵の数
                    //if (numenemy < //<<<倒した敵の数を持って来る関数)
                    //{
                    //    numenemy++;
                    //    Ne.text = numenemy.ToString();
                    //}
                    break; 
                };
            case 2:
                {//ビーム残量
                    //if (beam < //<<<ビーム残量をもって来る関数)
                    //{
                    //    beam++;
                    //    Bm.text = beam.ToString();
                    //}
                    break; 
                };
            case 3://スコア
                {
                    if (score < Score.GetComponent<Score>().ResultScore())
                    {
                        score++;
                        Rs.text = score.ToString();
                    }
                    else
                    {
                        text(4);
                    }
                    break; 
                };
            case 4:
                {//トータルスコア

                    if (i < totalscore)
                    {
                        i++;
                        Ts.text = i.ToString();
                    }
                    break; 
                };
        }
    }
}
