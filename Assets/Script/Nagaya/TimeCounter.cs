using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TimeCounter : MonoBehaviour
{
    //�J�E���g�_�E��
    public float countdown;

    //���Ԃ�\������Text�^�̕ϐ�
    TextMeshProUGUI timeText;

    public GameObject Image;

    // Start is called before the first frame update
    void Start()
    {
        Image = GameObject.Find("timeText");
        this.timeText = GameObject.Find("timeText").GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        //���Ԃ��J�E���g�_�E������
        countdown -= Time.deltaTime;

        //���Ԃ�\������
        this.timeText.text = countdown.ToString("f1") + "�b";

        //countdown��0�ȉ��ɂȂ����Ƃ�
        if (countdown <= 0)
        {
            countdown = 0;
            timeText.enabled = false;    //d)�p�l���̕\�����I�t�ɂ���
            Image.GetComponent<Fade>().GameOver();
        }

        
    }
}
