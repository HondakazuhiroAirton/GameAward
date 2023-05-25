using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResultUI : MonoBehaviour
{
    //�N���A���ɕ\������UI
    [SerializeField]
    private GameObject resultUI;
    [SerializeField]
    GameObject flag;
    EnemyManager clearflag;

    //�ϐ��擾�̂��߂̃I�u�W�F�N�g�擾
    //���֐��ǂݎ��̂��߃Q�[���I�u�W�F�N�g�擾���Ă܂���
     GameObject PD;
     TextMeshProUGUI Score;


    //�e�L�X�g�I�u�W�F�N�g�擾  
    TextMeshProUGUI Cm;
    TextMeshProUGUI Ne;
    TextMeshProUGUI Bm;
    TextMeshProUGUI Rs;
    TextMeshProUGUI Ts;

    static int combo;       //�R���{
    static int numenemy;    //�|�����G
    static int beam;        //�r�[��
    static int score;       //�X�R�A
    static int totalscore;  //���v
    static int comboPlus;       //�R���{
    static int numenemyPlus;    //�|�����G
    static int beamPlus;        //�r�[��
    static int scorePlus;       //�X�R�A
    static int totalscorePlus;  //���v
    static int i;  //�F�X�g��

    public int Second = 2;  //����



    // 0503�O�Y�ǋL
    // ���̃X�R�A�����邮�邵�ĕ\�������邩�o���Ă����ϐ�
    enum resultState
    {
        None = 0,
        combo,
        numenemy,
        beam,
        score,
        totalscore,
        end
    };
    private resultState panelState;

    private bool initflag;

    // BGM�p�Ƀ��C���J�������擾
    private GMC_BGMscript mainCameraBGMscript;


    // Start is called before the first frame update

    void Start()
    {
        initflag = false;
        //������
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

        //�R���{
        Cm = GameObject.Find("Combo").GetComponent<TextMeshProUGUI>();

        //�|�����G
        PD = GameObject.Find("PD");
        Ne = GameObject.Find("NumEnemy").GetComponent<TextMeshProUGUI>();

        //�r�[��
        Bm = GameObject.Find("Beam").GetComponent<TextMeshProUGUI>();

        //�X�R�A�̎擾
        Score = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
        Rs = GameObject.Find("ResultScore").GetComponent<TextMeshProUGUI>();

        //���v
        Ts = GameObject.Find("TotalScore").GetComponent<TextMeshProUGUI>();

        flag = GameObject.Find("EnemyGroup(Clone)");
        clearflag = flag.GetComponent<EnemyManager>();

        // BGM�p�Ƀ��C���J�������擾
        mainCameraBGMscript = GameObject.Find("MainCamera").GetComponent<GMC_BGMscript>();

        resultUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (clearflag.getclearflag() == true)
        {
            // �p�l��UI�̃A�N�e�B�u��A�N�e�B�u��؂�ւ�
            Active();

            // Debug.Log("������������������������������������");
            //�^�C�}�[���~�߂�
            Time.timeScale = 0.0f;

            // �p�l���̃X�e�C�g��ύX����
            // �ŏ��̃X�e�C�g��
            //panelState = resultState.None

            // �����͎b��@�Ɂc
            if (panelState == resultState.None)
            {
                panelState = resultState.combo;
            }
        }


        //�e�L�X�g�\��
        if (resultUI.activeSelf == true)
        {
            // �\���֐��J�n
            text();
        }
    }

    public void Active()
    {   
        if (initflag) return;
        initflag = true;

        //�p�l��UI�̃A�N�e�B�u�A��A�N�e�B�u��؂�ւ�
        resultUI.SetActive(true);

        // ���U���gBGM�n�߂�
        mainCameraBGMscript.ResultBGMStart();


        // true�̎�������������
        if (resultUI.activeSelf == true)
        {
            // �O�Y)���̕ӂőS���̕ϐ��ɍŏI�̒l���ꂿ�Ⴄ

            combo = PD.GetComponent<beamlife>().GetLife();//<<<�R���{�̐��������Ă���֐�
            numenemy = PD.GetComponent<PlayerClass>().GetDestroyTotal();//<<<�|�����G�̐��������ė���֐�
            beam = (int)PD.GetComponent<beamlife>().GetAmount();//<<<�r�[���c�ʂ������ė���֐�
            score = Score.GetComponent<Score>().ResultScore();
            totalscore = combo*1000 + numenemy*1000 + beam*1000 + score; // �g�[�^���v�Z

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
            case resultState.None: // �������Ȃ�
                break;
            case resultState.combo: //�R���{
                {
                    if (i < combo)
                    {
                          i = i + comboPlus;
                        Cm.text = combo.ToString() + "�~1000";
                    }else if (i >= combo)
                   {
                   Cm.text = combo.ToString() + "�~1000";
                        // ���̃X�e�C�g��(����numenemy�\��)   
                        panelState = resultState.numenemy;
                        // i��������
                        i = 0;
                   }
                    break;
                }
            case resultState.numenemy:
                {
                    //�|�����G�̐�
                    if (i < numenemy)
                    {
                        i = i + numenemyPlus;
                        Ne.text = numenemy.ToString() + "�~1000";
                    }
                    else if (i >= numenemy)
                    {
                        Ne.text = numenemy.ToString() + "�~1000";
                        // ���̃X�e�C�g��(����beam�\��)   
                        panelState = resultState.beam;
                        // i��������
                        i = 0;
                    }
                    break;
                }
            case resultState.beam:
                {
                    //�r�[���c��
                   if (i < beam)
                   {
                         i = i + beamPlus;
                       Bm.text = beam.ToString() + "�~1000";
                   }
                   else if (i >= beam)
                   {
                    Bm.text = beam.ToString() + "�~1000";
                        // ���̃X�e�C�g��(����score�\��)   
                        panelState = resultState.score;
                        // i��������
                         i = 0;
                   }
                    break;
                }
            case resultState.score://�X�R�A
                {
                    if (i < score)
                    {
                        i = i + scorePlus;
                        Rs.text = i.ToString();
                    }
                    else if (i >= score)
                    {
                        Rs.text = score.ToString();
                        // ���̃X�e�C�g��(����totalscore�\��)   
                        panelState = resultState.totalscore;
                        // i��������
                        i = 0;
                    }
                    break;
                }
            case resultState.totalscore:
                {//�g�[�^���X�R�A

                    if (i < totalscore)
                    {
                        i = i + totalscorePlus;
                        Ts.text = i.ToString();
                    }
                    else if (i >= totalscore)
                    {
                        Ts.text = totalscore.ToString();
                        // �g�[�^���X�R�A��\�����Ă����(�Ō��None�ɂ���)   
                        panelState = resultState.end;
                    }
                    break;
                }

            case resultState.end:
                {
                    break;
                }
        }

    }

    public int TotalScore()
    {
       return totalscore;
    }

    public bool rankflag()
    {
        return initflag;
    }

    public void rankfragfalse()
    {
        initflag = false;
    }
}
