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
    static int comboPlus;       //コンボ
    static int numenemyPlus;    //倒した敵
    static int beamPlus;        //ビーム
    static int scorePlus;       //スコア
    static int totalscorePlus;  //合計
    static int i;  //色々使う

    public int Second = 2;  //時間

    // 0503三浦追記
    // 何のスコアをぐるぐるして表示させるか覚えておく変数
    enum resultState
    {
        None = 0,
        combo,
        numenemy,
        beam,
        score,
        totalscore
    };
    private resultState panelState;


    // Start is called before the first frame update



    void Start()
    {
        //初期化
        combo = 0;
        numenemy = 0;
        beam = 0;
        score = 0;
        totalscore = 0;
        comboPlus = 0;     
        numenemyPlus = 0;  
        beamPlus = 0;      
        scorePlus = 0;
        totalscorePlus = 0;
        i = 0;
 
        panelState = resultState.None;
        Second = Second * 60;

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
            Time.timeScale = 0.0f;

            // パネルのステイトを変更する
            // 最初のステイトに
            //panelState = resultState.None

            // ↑今は暫定機に…
            panelState = resultState.score;

        }


        //テキスト表示
        if (resultUI.activeSelf == true)
        {
            // 表示関数開始
            text();
        }
    }

    public void Active()
    {
        //パネルUIのアクティブ、非アクティブを切り替え
        resultUI.SetActive(!resultUI.activeSelf);

        // trueの時だけ処理する
        if (resultUI.activeSelf == true)
        {
            // 三浦)この辺で全部の変数に最終の値入れちゃう

            //combo = ??;//<<<コンボの数を持ってくる関数
            //numenemy = ??;//<<<倒した敵の数を持って来る関数
            //beam = ??;//<<<ビーム残量をもって来る関数
            score = Score.GetComponent<Score>().ResultScore();
            totalscore = combo + numenemy + beam + score; // トータル計算

            comboPlus = combo / Second;
            if (comboPlus <= 0) comboPlus = 1;
            numenemyPlus = numenemy / Second;
            if (numenemyPlus <= 0) numenemyPlus = 1;
            beamPlus = beam / Second;
            if (beamPlus <= 0) beamPlus = 1;
            scorePlus = score / Second;
            if (scorePlus <= 0) scorePlus = 1;
            totalscorePlus = totalscore / Second;
            if (totalscorePlus <= 0) totalscorePlus = 1;

        }
    }

    void text()
    {
        
        switch (panelState)
        {
            case resultState.None: // 何もしない
                break;
            case resultState.combo: //コンボ
                {
                    // if (i < combo)
                    // {
                    //       i = i + comboPlus;
                    //     Cm.text = combo.ToString();
                    // }else if (i >= combo)
                    //{
                    //Cm.text = combo.ToString();
                    //     // 次のステイトへ(次はnumenemy表示)   
                    //     panelState = resultState.numenemy;
                    //     // iを初期化
                    //     // i = 0;
                    //}
                    break;
                }
            case resultState.numenemy:
                {
                    //倒した敵の数
                    //if (i < numenemy)
                    //{
                    //      i = i + numenemyPlus;
                    //    Ne.text = numenemy.ToString();
                    //}
                    // }else if (i >= numenemy)
                    //{
                    // Ne.text = numenemy.ToString();
                    //     // 次のステイトへ(次はbeam表示)   
                    //     panelState = resultState.beam;
                    //     // iを初期化
                    //     // i = 0;
                    //}
                    break;
                }
            case resultState.beam:
                    {
                    //ビーム残量
                    //if (i < beam)
                    //{
                    //      i = i + beamPlus;
                    //    Bm.text = beam.ToString();
                    //}
                    //else if (i >= beam)
                    //{
                    // Bm.text = beam.ToString();
                    //     // 次のステイトへ(次はscore表示)   
                    //     panelState = resultState.score;
                    //     // iを初期化
                    //     // i = 0;
                    //}
                    break;
                    }
                case resultState.score://スコア
                {
                    if (i < score)
                    {
                        i = i + scorePlus;
                        Rs.text = i.ToString();
                    }
                    else if (i >= score)
                    {
                        Rs.text = score.ToString();
                        // 次のステイトへ(次はtotalscore表示)   
                        panelState = resultState.totalscore;
                        // iを初期化
                        i = 0;
                    }
                    break;
                }
                case resultState.totalscore:
                {//トータルスコア

                    if (i < totalscore)
                    {
                        i = i + totalscorePlus;
                        Ts.text = i.ToString();
                    }
                    else if (i >= totalscore)
                    {
                        Ts.text = totalscore.ToString();
                        // トータルスコアを表示しておわり(最後はNoneにする)   
                        panelState = resultState.None;
                    }
                    break;
                }
            }
        
    }

    public int TotalScore()
    {
       return totalscore;
    }
}
