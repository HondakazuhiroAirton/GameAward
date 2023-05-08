using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rank : MonoBehaviour
{
    //�p�l���̎擾
    [SerializeField]
    Image RankPanel;
    float alfa;

    //�����N�����߂�X�R�A�͈̔�
    public int S;
    public int A;
    public int B;
    public int C;

    //�����N�����߂�X�R�A�͈̔�
    GameObject RankS;
    GameObject RankA;
    GameObject RankB;
    GameObject RankC;
    GameObject RankD;

    //�X�R�A�������Ă��ē����ϐ�
    static int FainalScore;
    ResultUI Resulte;

    //�����ŃX�R�A�������Ă���I�u�W�F�N�g�擾
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

            //���v�������Ă���
            FainalScore = Resulte.TotalScore();

                //�����N�����߂ĉ摜��ς��鏈��
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

                //�@�|�[�YUI���\������Ă鎞�͒�~
                if (alfa == 1)
                {
                    Time.timeScale = 0f;
                    //�@�|�[�YUI���\������ĂȂ���Βʏ�ʂ�i�s  

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
