using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Rank : MonoBehaviour
{
    //パネルの取得
    [SerializeField]
    Image RankPanel;

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
    GameObject ranktx;

    Image RankSPanel;
    Image RankAPanel;
    Image RankBPanel;
    Image RankCPanel;
    Image RankDPanel;
    TextMeshProUGUI ranktxPanel;

    float alfaS;
    float alfaA;
    float alfaB;
    float alfaC;
    float alfaD;
    float ranktxal;

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
        RankS = GameObject.Find("S");
        RankSPanel = RankS.GetComponent<Image>();
        RankA = GameObject.Find("A");
        RankAPanel = RankA.GetComponent<Image>();
        RankB = GameObject.Find("B");
        RankBPanel = RankB.GetComponent<Image>();
        RankC = GameObject.Find("C");
        RankCPanel = RankC.GetComponent<Image>();
        RankD = GameObject.Find("D");
        RankDPanel = RankD.GetComponent<Image>();
        ranktx = GameObject.Find("ranktx");
        ranktxPanel = ranktx.GetComponent<TextMeshProUGUI>();

        Time.timeScale = 1f;

        alfaS = RankSPanel.color.a;
        alfaS = 0;
        alfaA = RankAPanel.color.a;
        alfaA = 0;
        alfaB = RankBPanel.color.a;
        alfaB = 0;
        alfaC = RankCPanel.color.a;
        alfaC = 0;
        alfaD = RankDPanel.color.a;
        alfaD = 0;
        ranktxal = ranktxPanel.color.a;
        ranktxal = 0;

    }

    // Update is called once per frame
    void Update()
    {

        if (Resulte.rankflag() == true)
        {
            //デバック用
            if (Input.GetKeyDown(KeyCode.O))
            {
                rankpanel();
            }
        }

    }

    void Rankselect(int no)
    {
        switch (no)
        {
            case 0:
                {
                    alfaS = 1.0f;
                    RankS.GetComponent<Image>().color += new Color(0, 0, 0, alfaS);
                    break;
                }
            case 1:
                {
                    alfaA = 1.0f;
                    RankA.GetComponent<Image>().color += new Color(0, 0, 0, alfaA);
                    break;
                }
            case 2:
                {
                    alfaB = 1.0f;
                    RankB.GetComponent<Image>().color += new Color(0, 0, 0, alfaB);
                    break;
                }
            case 3:
                {
                    alfaC = 1.0f;
                    RankC.GetComponent<Image>().color += new Color(0, 0, 0, alfaC);
                    break;
                }
            case 4:
                {
                    alfaD = 1.0f;
                    RankD.GetComponent<Image>().color += new Color(0, 0, 0, alfaD);
                    break;
                }
        }
    }

    //ランクパネル呼び出し用
    public void rankpanel()
    {
            //合計をもって来る
            FainalScore = Resulte.TotalScore();

            ranktxal = 1.0f;
            ranktx.GetComponent<TextMeshProUGUI>().color += new Color(0, 0, 0, ranktxal);

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

    }

}
