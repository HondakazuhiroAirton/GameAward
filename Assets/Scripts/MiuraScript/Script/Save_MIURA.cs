using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using UnityEditor;

public class Save_MIURA : MonoBehaviour
{
    // �Ȃ񂩂̃N���X������Ă�
    private StreamWriter sw;

    //�@�X�e�[�W�N���A�f�[�^�i�[�z��
    public StageClearDate[] StageClearDate;

    void Start()
    {
        // �X�^�[�g�Ő�Ƀt�@�C����ǂݍ���

        // 1.�ŏ��Ɍ��̃f�[�^���Q�[�����̔z��Ɋi�[���čT���Ă���
        //�@�e�L�X�g�t�@�C���̓ǂݍ��݂��s���Ă����N���X
        TextAsset textasset = new TextAsset();
        //�@csv�t�@�C����ǂݍ��܂���B
        //�@�t�@�C���́uResources�v�t�H���_�����A�����ɓ���Ă������ƁB�܂�"CSVTestData"�̕����̓t�@�C�����ɍ��킹�ĕύX����B
        textasset = Resources.Load("SaveData", typeof(TextAsset)) as TextAsset;
        //�@CSVSerializer��p����csv�t�@�C����z��ɗ������ށB
        StageClearDate = CSVSerializer.Deserialize<StageClearDate>(textasset.text);

        // 2.�t�@�C��������
        AssetDatabase.DeleteAsset("Assets/Scenes/MiuraScene/Resources/SaveData.csv");

        // 3.����1�񓯂����O�̃t�@�C���쐬
        //                     �� ���t�@�C���� ��true     �������R�[�h  
        sw = new StreamWriter(@"./Assets/Scenes/MiuraScene/Resources/SaveData.csv", true, Encoding.GetEncoding("Shift_JIS"));

    }

    // �ۑ��֐� (�X�e�[�W��,�ʂ��ԍ�,�N���A��)
    public void SaveData(string txt1,int stage,int state)
    {
        Debug.Log("�f�[�^�ۑ����ɂ��");

        // int�̃f�[�^�𕶎��ɕϊ�
        string Stage = stage.ToString("00"); 
        string State = state.ToString("0"); 

        // ���s���Ēǉ�
        string s2 = string.Join(",", txt1, Stage, State);
        sw.WriteLine(s2);
    }

    void Update()
    {

        //if (Input.GetKeyDown(KeyCode.F))
        //{
        //  SaveData("stage1_2",0,0);
        //}

        if (Input.GetKeyDown(KeyCode.D))
        {
            CSVReset();
        }
    }

    // �Q�[���A�v�����I������^�C�~���O��1��s������
    public void OnApplicationQuit()
    {
        // �X�e�[�W�̃N���A�󋵂���������
        // �X�e�[�W�f�[�^�̓��e(StageClearDate)��1�s�ڂ��쐬
        string[] s1 = { "stage", "StageIndex", "State" };

        // s1�̃f�[�^�ɏ������ރf�[�^��������(���s)
        string s2 = string.Join(",", s1);

        // sw�ɒǉ�����
        sw.WriteLine(s2);


        // �N���A���Ă邩�ǂ���
        for (int i = 0; i < 20; i++) // �S�X�e�[�W20�̕����[�v
        {
            StageClearState State = StageClearDate[i].State; 
            // s2�ɓ��e��������   ���X�e�[�W�� ���ʂ��ԍ� ���N���A��
            s2 = string.Join(",", "stage" + (i / 5 + 1) +"_" + (i % 5 + 1 ), i /*( <-StageIndex�Ɠ���)*/, (int)State);

            // sw�ɒǉ�����
            sw.WriteLine(s2);

        }

        Debug.Log("�A�v����������ɂ��");
        Debug.Log("�t�@�C���̐�L����߂�ɂ��");
        // �t�@�C����������߂�
        sw.Close();
    }

    // CSV�t�@�C��������(�ŏ�����Ɏg���邩��)
    public void CSVReset()
    {
        // void Start �Ɠ����ŃN���[�Y���ĐV������蒼��
        Debug.Log("�Z�[�u�f�[�^����������ɂ��");
        sw.Close();
        AssetDatabase.DeleteAsset("Assets/Scenes/MiuraScene/Resources/SaveData.csv");
        sw = new StreamWriter(@"./Assets/Scenes/MiuraScene/Resources/SaveData.csv", true, Encoding.GetEncoding("Shift_JIS"));
        string[] s1 = { "stage", "StageIndex", "State" };
        string s2 = string.Join(",", s1);
        sw.WriteLine(s2);

        for (int i = 0; i < 20; i++) // �S�X�e�[�W20�̕����[�v
        {
            StageClearState State = StageClearState.NONE;
            if(i == 0) State = StageClearState.CHALLENGE; // 1_1�������풆

            // s2�ɓ��e��������   ���X�e�[�W�� ���ʂ��ԍ� ���N���A��
            s2 = string.Join(",", "stage" + (i / 5 + 1) + "_" + (i % 5 + 1), i /*( <-StageIndex�Ɠ���)*/, (int)State);

            // sw�ɒǉ�����
            sw.WriteLine(s2);

        }

    }

}


