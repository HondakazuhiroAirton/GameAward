using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonTitle : MonoBehaviour
{
    //�@�|�[�Y�������ɕ\������UI
    [SerializeField]
    private GameObject titleUI;
    //�J�E���g�_�E��
    public float countdown;

    //�{�^���ݒ�
    private Button redo;
    private Button Continue;

    public GameObject Image;


    // Start is called before the first frame update
    void Start()
    {
        Image = GameObject.Find("Image");

        //�{�^���̓ǂݍ���
        redo = GameObject.Find("Redo").GetComponent<Button>();
        Continue = GameObject.Find("Continue").GetComponent<Button>();

        titleUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //���Ԃ��J�E���g�_�E������
        countdown -= Time.deltaTime;
        

        //countdown��0�ȉ��ɂȂ����Ƃ�
        if (countdown <= 0)
        {
            countdown = 0;

            // �p�l��UI�̃A�N�e�B�u��A�N�e�B�u��؂�ւ�
            Active();
            //�{�^�����I�����ꂽ��ԂɂȂ�
            redo.Select();
        }
        
    }

    public void ButtonRedo()
    {
        Image.GetComponent<Fade>().GameSelect();
    }

    public void ButtonContinue()
    {
        Image.GetComponent<Fade>().GameSelect();
    }

    public void Active()
    {
        //�p�l��UI�̃A�N�e�B�u�A��A�N�e�B�u��؂�ւ�
        titleUI.SetActive(true);
    }
}
