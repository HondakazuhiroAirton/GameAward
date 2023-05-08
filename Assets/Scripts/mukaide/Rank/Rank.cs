using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rank : MonoBehaviour
{
    //パネルの取得
    [SerializeField]
    Image RankPanel;
    float alfa;

    //ランクを決めるスコアの範囲
    public int S;
    public int A;
    public int B;
    public int C;

    //ランクを決めるスコアの範囲
    GameObject RankS;
    GameObject RankA;
    GameObject RankB;
    GameObject RankC;
    GameObject RankD;

    //スコアを持ってきて入れる変数
    static int FainalScore;
    ResultUI Resulte;

    //ここでスコアを持ってくるオブジェクト取得
    [SerializeField]
    GameObject Obj;

    // Start is called before the first frame update
    void Start()
    {
        Obj = GameObject.Find("Result");
        Resulte = Obj.GetComponent<ResultUI>();
    }

    void Awake()
    {
        RankPanel = GetComponent<Image>();
        RankS = GameObject.Find("S");
        RankA = GameObject.Find("A");
        RankB = GameObject.Find("B");
        RankC = GameObject.Find("C");
        RankD = GameObject.Find("D");

        Time.timeScale = 1f;

        alfa = RankPanel.color.a;
        alfa = 0;
        SetAlpha();
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown("o"))
            {

            alfa = 1;
            SetAlpha();

            //合計をもってする
            FainalScore = Resulte.TotalScore();

                //ランクを決めて画像を変える処理
                if (FainalScore >= S)
                {
                    Rankselect(0);
                }
                else if (FainalScore < S && FainalScore >= A)
                {
                    Rankselect(1);
                }
                else if (FainalScore < A && FainalScore >= B)
                {
                    Rankselect(2);
                }
                else if (FainalScore < B && FainalScore >= C)
                {
                    Rankselect(3);
                }
                else if (FainalScore < C)
                {
                    Rankselect(4);
                }

                //　ポーズUIが表示されてる時は停止
                if (alfa == 1)
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

    void Rankselect(int no)
    {
        switch (no)
        {
            case 0:
                {
                    RankS.SetActive(true);
                    RankA.SetActive(false);
                    RankB.SetActive(false);
                    RankC.SetActive(false);
                    RankD.SetActive(false);
                    break;
                }
            case 1:
                {
                    RankS.SetActive(false);
                    RankA.SetActive(true);
                    RankB.SetActive(false);
                    RankC.SetActive(false);
                    RankD.SetActive(false);
                    break;
                }
            case 2:
                {
                    RankS.SetActive(false);
                    RankA.SetActive(false);
                    RankB.SetActive(true);
                    RankC.SetActive(false);
                    RankD.SetActive(false);
                    break;
                }
            case 3:
                {
                    RankS.SetActive(false);
                    RankA.SetActive(false);
                    RankB.SetActive(false);
                    RankC.SetActive(true);
                    RankD.SetActive(false);
                    break;
                }
            case 4:
                {
                    RankS.SetActive(false);
                    RankA.SetActive(false);
                    RankB.SetActive(false);
                    RankC.SetActive(false);
                    RankD.SetActive(true);
                    break;
                }
        }
    }

    void SetAlpha()
    {
        RankPanel.color = new Color(1, 1, 1, alfa);
    }
}
