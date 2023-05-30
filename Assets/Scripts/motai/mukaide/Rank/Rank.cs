using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

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
    Image rankPanel;

    float alfaS;
    float alfaA;
    float alfaB;
    float alfaC;
    float alfaD;
    float ranktxal;
    float alfa;

    //スコアを持ってきて入れる変数
    static int FainalScore;
    ResultUI Resulte;

    //ここでスコアを持ってくるオブジェクト取得
    [SerializeField]
    GameObject Obj;

    //button 
    Continue rankButton;
    int Ctime = 0;
    bool Cflag = true;

    // StageChangerオブジェクト
    public GameObject StageChanger;
    public RankBorder[] rb;

    // Start is called before the first frame update
    void Start()
    {
        Obj = GameObject.Find("Result");
        Resulte = Obj.GetComponent<ResultUI>();

        // スクリプト上のNextStageを取得
        StageNo nextStageNo = StageChanger.GetComponent<StageChangerScript>().NextStage;
        rb = rankborders;
        S = rb[(int)nextStageNo].HiScore /10 * 9;
        A = rb[(int)nextStageNo].HiScore /10 * 7;
        B = rb[(int)nextStageNo].HiScore /10 * 5;
        C = rb[(int)nextStageNo].HiScore /10 * 3;
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
        rankPanel = GameObject.Find("rankPanel").GetComponent<Image>();

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
        alfa = rankPanel.color.a;
        alfa = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Cflag = true; 
        if (Ctime >= 0)
        {
            Ctime--;
        }

        if (Resulte.rankflag() == true)
        {
            //デバック用
            if (Input.GetKeyDown(KeyCode.O))
            {
                rankpanel();

                Obj.SetActive(false);
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
                    alfa = 0.8f;
                    RankS.GetComponent<Image>().color += new Color(0, 0, 0, alfaS);
                    rankPanel.GetComponent<Image>().color += new Color(0, 0, 0, alfa);
                    break;
                }
            case 1:
                {
                    alfaA = 1.0f;
                    alfa = 0.8f;
                    RankA.GetComponent<Image>().color += new Color(0, 0, 0, alfaA);
                    rankPanel.GetComponent<Image>().color += new Color(0, 0, 0, alfa);
                    break;
                }
            case 2:
                {
                    alfaB = 1.0f;
                    alfa = 0.8f;
                    RankB.GetComponent<Image>().color += new Color(0, 0, 0, alfaB);
                    rankPanel.GetComponent<Image>().color += new Color(0, 0, 0, alfa);
                    break;
                }
            case 3:
                {
                    alfaC = 1.0f;
                    alfa = 0.8f;
                    RankC.GetComponent<Image>().color += new Color(0, 0, 0, alfaC);
                    rankPanel.GetComponent<Image>().color += new Color(0, 0, 0, alfa);
                    break;
                }
            case 4:
                {
                    alfaD = 1.0f;
                    alfa = 0.8f;
                    RankD.GetComponent<Image>().color += new Color(0, 0, 0, alfaD);
                    rankPanel.GetComponent<Image>().color += new Color(0, 0, 0, alfa);
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
    public void Ondecision(InputAction.CallbackContext context)
    {

        if (Resulte.rankflag() == true)
        {
            if (context.phase == InputActionPhase.Performed)
            {
                rankpanel();
                rankButton = this.GetComponent<Continue>();
                rankButton.rankButton();
                Cflag = false;
                Ctime = 4;
                Resulte.rankfragfalse();
                Obj.SetActive(false);
            }
        }
    }

    public bool BCflag()
    {
        return Cflag;
    }

    public RankBorder[] rankborders = new RankBorder[]
    {
        new RankBorder() {HiScore = 52525},    //1-1
        new RankBorder() {HiScore = 63450},
        new RankBorder() {HiScore = 82300},
        new RankBorder() {HiScore = 52550},
        new RankBorder() {HiScore = 60825},
        new RankBorder() {HiScore = 71100},    //2-1
        new RankBorder() {HiScore = 74600},
        new RankBorder() {HiScore = 74050},
        new RankBorder() {HiScore = 91950},
        new RankBorder() {HiScore = 83175},
        new RankBorder() {HiScore = 108250},    //3-1
        new RankBorder() {HiScore = 50750},
        new RankBorder() {HiScore = 93950},
        new RankBorder() {HiScore = 83500},
        new RankBorder() {HiScore = 41825},
        new RankBorder() {HiScore = 53075},    //4-1
        new RankBorder() {HiScore = 100425},
        new RankBorder() {HiScore = 249850},
        new RankBorder() {HiScore = 384300},
        new RankBorder() {HiScore = 1245950},
    };
}

public class RankBorder
{
    public int HiScore;
}
