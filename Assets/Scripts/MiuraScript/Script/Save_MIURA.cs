using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class Save_MIURA : MonoBehaviour
{
    // �Ȃ񂩂̃N���X������Ă�
    private StreamWriter sw;

    void Start()
    {
        // �Ȃ񂩂̃N���X�ɏ������ޓ��e�����Ă���ۂ�
        //                     �� ���t�@�C���� ��true     �������R�[�h  
        sw = new StreamWriter(@"SaveData.csv", true, Encoding.GetEncoding("Shift_JIS"));

        // �X�e�[�W
        string[] s1 = { "stage" };

        // s1�̃f�[�^�ɏ������ރf�[�^��������
        string s2 = string.Join(",", s1);

        // sw�ɒǉ�����
        sw.WriteLine(s2);

        // s2�ɓ��e��������
        s2 = string.Join(",", "stage1");

        // sw�ɒǉ�����
        sw.WriteLine(s2);
    }

    // �ۑ��֐�
    public void SaveData(string txt1)
    {
        // ������z�������Ă�
        string[] s1 = { txt1};
        string s2 = string.Join(",", s1);
        sw.WriteLine(s2);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
          SaveData("stage1");
        }

        // �t�@�C����������߂�
        if (Input.GetKeyDown(KeyCode.Return))
        {
            sw.Close();
        }

    }
}

// �ǂݍ���