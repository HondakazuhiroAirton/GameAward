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

            //�e�L�X�g�\��
            score = Score.GetComponent<Score>().ResultScore();
            Rs.text = "Score: " + score.ToString();




            //���v�̌v�Z
            totalscore = combo + numenemy + beam + score;
            Ts.text = "TotalScore: " + totalscore.ToString();

        }
    }

    public void Active()
    {
        //�p�l��UI�̃A�N�e�B�u�A��A�N�e�B�u��؂�ւ�
        resultUI.SetActive(!resultUI.activeSelf);
    }
}
