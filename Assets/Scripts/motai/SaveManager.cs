using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; // UnityJson���g���ꍇ�ɕK�v
using System.IO; // �t�@�C���������݂ɕK�v

[Serializable]
public struct SaveData
{
    public int x;
    public int y;

    public void Dump()
    {
        Debug.Log("x = " + x);
        Debug.Log("y = " + y);
    }
}

/// <summary>
/// �Z�[�u�f�[�^�Ǘ�
/// </summary>
public class SaveManager : MonoBehaviour
{
    // �ۑ�����t�@�C��
    const string SAVE_FILE_PATH = "save.txt";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            // S�L�[�ŃZ�[�u���s
            var data = new SaveData();
            data.x = 5;
            data.y = 7;
            // JSON�ɃV���A���C�Y
            var json = JsonUtility.ToJson(data);
            // Assets�t�H���_�ɕۑ�����
            var path = Application.dataPath + "/" + SAVE_FILE_PATH;
            var writer = new StreamWriter(path, false); // �㏑��
            writer.WriteLine(json);
            writer.Flush();
            writer.Close();
        }
        else if (Input.GetKeyDown(KeyCode.L))
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
