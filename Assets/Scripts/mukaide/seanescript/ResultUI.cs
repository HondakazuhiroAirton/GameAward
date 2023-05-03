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
    static int i; //�g�[�^���X�R�A�Ŏg���Ă�

    // Start is called before the first frame update

  

    void Start()
    {
        //������
        combo = 0;
        numenemy = 0;
        beam = 100;
        score = 0;
        totalscore = 0;

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
            Time.timeScale = 0f;

        }


        //�e�L�X�g�\��
        if (resultUI.activeSelf == true)
        {
            text(3);

        }
    }

    public void Active()
    {
        //�p�l��UI�̃A�N�e�B�u�A��A�N�e�B�u��؂�ւ�
        resultUI.SetActive(!resultUI.activeSelf);
        //���v�̌v�Z
        totalscore = combo + numenemy + beam + score;
    }

    void text(int no)
    {
        switch(no)
        {
            case 0: //�R���{
                {
                   // if (combo < //<<<�R���{�̐��������Ă���֐�)
                   // {
                   //     combo++;
                   //     Cm.text = combo.ToString();
                   // }
                    break; 
                };
            case 1:
                {//�|�����G�̐�
                    //if (numenemy < //<<<�|�����G�̐��������ė���֐�)
                    //{
                    //    numenemy++;
                    //    Ne.text = numenemy.ToString();
                    //}
                    break; 
                };
            case 2:
                {//�r�[���c��
                    //if (beam < //<<<�r�[���c�ʂ������ė���֐�)
                    //{
                    //    beam++;
                    //    Bm.text = beam.ToString();
                    //}
                    break; 
                };
            case 3://�X�R�A
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
                {//�g�[�^���X�R�A

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
