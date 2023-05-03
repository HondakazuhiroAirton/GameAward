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

    //�ϐ��擾�̂��߂̃I�u�W�F�N�g�擾
    //���֐��ǂݎ��̂��߃Q�[���I�u�W�F�N�g�擾���Ă܂���
     GameObject Combo;
     GameObject Numenemy;
     GameObject Beam;
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
    static int i;  //�F�X�g��

    // 0503�O�Y�ǋL
    // ���̃X�R�A�����邮�邵�ĕ\�������邩�o���Ă����ϐ�
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
        //������
        combo = 0;
        numenemy = 0;
        beam = 0;
        score = 0;
        totalscore = 0;
        i = 0;

        panelState = resultState.None;

        //�R���{
        //Combo = GameObject.Find("");
        Cm = GameObject.Find("Combo").GetComponent<TextMeshProUGUI>();

        //�|�����G
        //Numenemy = GameObject.Find("");
        Ne = GameObject.Find("NumEnemy").GetComponent<TextMeshProUGUI>();

        //�r�[��
        //Beam = GameObject.Find("");
        Bm = GameObject.Find("Beam").GetComponent<TextMeshProUGUI>();

        //�X�R�A�̎擾
        Score = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
        Rs = GameObject.Find("ResultScore").GetComponent<TextMeshProUGUI>();

        //���v
        Ts = GameObject.Find("TotalScore").GetComponent<TextMeshProUGUI>();

        resultUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("k"))
        {
            // �p�l��UI�̃A�N�e�B�u��A�N�e�B�u��؂�ւ�
            Active();
            //�^�C�}�[���~�߂�
            Time.timeScale = 0.0f;

            // �p�l���̃X�e�C�g��ύX����
            // �ŏ��̃X�e�C�g��
            //panelState = resultState.None

            // �����͎b��@�Ɂc
            panelState = resultState.score;
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
        //�p�l��UI�̃A�N�e�B�u�A��A�N�e�B�u��؂�ւ�
        resultUI.SetActive(!resultUI.activeSelf);

        // true�̎�������������
        if (resultUI.activeSelf == true)
        {
            // �O�Y)���̕ӂőS���̕ϐ��ɍŏI�̒l���ꂿ�Ⴄ

            //combo = ??;//<<<�R���{�̐��������Ă���֐�
            //numenemy = ??;//<<<�|�����G�̐��������ė���֐�
            //beam = ??;//<<<�r�[���c�ʂ������ė���֐�
            score = Score.GetComponent<Score>().ResultScore();
            totalscore = combo + numenemy + beam + score; // �g�[�^���v�Z
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
                // if (i < combo)
                // {
                //     combo++;
                //     Cm.text = combo.ToString();
                // }else
                //{
                //     // ���̃X�e�C�g��(����numenemy�\��)   
                //     panelState = resultState.numenemy;
                //     // i��������
                //     // i = 0;
                //}
                break;
                }
            case resultState.numenemy:
                {
                //�|�����G�̐�
                //if (i < numenemy)
                //{
                //    numenemy++;
                //    Ne.text = numenemy.ToString();
                //}
                // }else
                //{
                //     // ���̃X�e�C�g��(����beam�\��)   
                //     panelState = resultState.beam;
                //     // i��������
                //     // i = 0;
                //}
                   break;
                }
            case resultState.beam:
                    {
                    //�r�[���c��
                    //if (i < beam)
                    //{
                    //    beam++;
                    //    Bm.text = beam.ToString();
                    //}
                    //else
                    //{
                    //     // ���̃X�e�C�g��(����score�\��)   
                    //     panelState = resultState.score;
                    //     // i��������
                    //     // i = 0;
                    //}
                       break;
                    }
                case resultState.score://�X�R�A
                    {
                        if (i < score)
                        {
                            i++;
                            Rs.text = i.ToString();
                        }
                        else
                        {
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
                            i++;
                            Ts.text = i.ToString();
                        }
                        else
                        {
                            // �g�[�^���X�R�A��\�����Ă����(�Ō��None�ɂ���)   
                            panelState = resultState.None;
                        }
                        break;
                    }
            }
        
    }
}
