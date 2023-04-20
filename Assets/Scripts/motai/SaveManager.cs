using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; // UnityJson���g���ꍇ�ɕK�v
using System.IO; // �t�@�C���������݂ɕK�v

[Serializable]
public struct SaveData
{
    public int stage1;
    public int stage2;
    public int stage3;
    public int stage4;
    public int stage5;

    public void Dump()
    {
        Debug.Log("stage1 = " + stage1);
        Debug.Log("stage2 = " + stage2);
        Debug.Log("stage3 = " + stage3);
        Debug.Log("stage4 = " + stage4);
        Debug.Log("stage5 = " + stage5);
    }
}

/// <summary>
/// �Z�[�u�f�[�^�Ǘ�
/// </summary>
public class SaveManager : MonoBehaviour
{
    // �ۑ�����t�@�C��
    const string SAVE_FILE_PATH = "save.txt";
    public int goal;

    void Update()
    {
        if (goal == 1)     // Input.GetKeyDown(KeyCode.S)// S�L�[�ŃZ�[�u���s
        {
            // goal�̐���10�ƂɂȂ�ƕۑ�
            var data = new SaveData();
            data.stage1 = 1;
            // JSON�ɃV���A���C�Y
            var json = JsonUtility.ToJson(data);
            // Assets�t�H���_�ɕۑ�����
            var path = Application.dataPath + "/" + SAVE_FILE_PATH;
            var writer = new StreamWriter(path, false); // �㏑��
            writer.WriteLine(json);
            writer.Flush();
            writer.Close();
        }
        if (goal == 10) //1-1���N���A������
        {
            // goal�̐���10�ƂɂȂ�ƕۑ�
            var data = new SaveData();
            data.stage1 = 2;
            data.stage2 = 1;
            // JSON�ɃV���A���C�Y
            var json = JsonUtility.ToJson(data);
            // Assets�t�H���_�ɕۑ�����
            var path = Application.dataPath + "/" + SAVE_FILE_PATH;
            var writer = new StreamWriter(path, false); // �㏑��
            writer.WriteLine(json);
            writer.Flush();
            writer.Close();
            goal = 10;
        }
        if (goal == 20) //1-2���N���A������
        {
            // goal�̐���20�ƂɂȂ�ƕۑ�
            var data = new SaveData();
            data.stage1 = 2;
            data.stage2 = 2;
            data.stage3 = 1;
            // JSON�ɃV���A���C�Y
            var json = JsonUtility.ToJson(data);
            // Assets�t�H���_�ɕۑ�����
            var path = Application.dataPath + "/" + SAVE_FILE_PATH;
            var writer = new StreamWriter(path, false); // �㏑��
            writer.WriteLine(json);
            writer.Flush();
            writer.Close();
            goal = 20;
        }
        if (goal == 30) //1-3���N���A������
        {
            // goal�̐���30�ƂɂȂ�ƕۑ�
            var data = new SaveData();
            data.stage1 = 2;
            data.stage2 = 2;
            data.stage3 = 2;
            data.stage4 = 1;
            // JSON�ɃV���A���C�Y
            var json = JsonUtility.ToJson(data);
            // Assets�t�H���_�ɕۑ�����
            var path = Application.dataPath + "/" + SAVE_FILE_PATH;
            var writer = new StreamWriter(path, false); // �㏑��
            writer.WriteLine(json);
            writer.Flush();
            writer.Close();
            goal = 30;
        }
        if (goal == 40) //1-4���N���A������
        {
            // goal�̐���40�ƂɂȂ�ƕۑ�
            var data = new SaveData();
            data.stage1 = 2;
            data.stage2 = 2;
            data.stage3 = 2;
            data.stage4 = 2;
            data.stage5 = 1;
            // JSON�ɃV���A���C�Y
            var json = JsonUtility.ToJson(data);
            // Assets�t�H���_�ɕۑ�����
            var path = Application.dataPath + "/" + SAVE_FILE_PATH;
            var writer = new StreamWriter(path, false); // �㏑��
            writer.WriteLine(json);
            writer.Flush();
            writer.Close();
            goal = 40;
        }
        if (goal == 50) //1-5���N���A������
        {
            // goal�̐���50�ƂɂȂ�ƕۑ�
            var data = new SaveData();
            data.stage1 = 2;
            data.stage2 = 2;
            data.stage3 = 2;
            data.stage4 = 2;
            data.stage5 = 2;
            // JSON�ɃV���A���C�Y
            var json = JsonUtility.ToJson(data);
            // Assets�t�H���_�ɕۑ�����
            var path = Application.dataPath + "/" + SAVE_FILE_PATH;
            var writer = new StreamWriter(path, false); // �㏑��
            writer.WriteLine(json);
            writer.Flush();
            writer.Close();
            goal = 50;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            // L�L�[�Ń��[�h���s
            // Assets�t�H���_���烍�[�h
            var info = new FileInfo(Application.dataPath + "/" + SAVE_FILE_PATH);
            var reader = new StreamReader(info.OpenRead());
            var json = reader.ReadToEnd();
            var data = JsonUtility.FromJson<SaveData>(json);
            data.Dump();
        }
    }
}
