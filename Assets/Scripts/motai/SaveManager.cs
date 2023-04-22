using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; // UnityJson���g���ꍇ�ɕK�v
using System.IO; // �t�@�C���������݂ɕK�v
using UnityEditor;//EditorApplication���g���̕K�v


[Serializable]
public struct SaveData
{
    public int stage;
    public int stage2;
    public int stage3;
    //public int stage4;
    //public int stage5;
    //public int CS;

    public void Dump()
    {
        Debug.Log("stage = " + stage);
        Debug.Log("stage2 = " + stage2);
        Debug.Log("stage3 = " + stage3);
        //Debug.Log("stage4 = " + stage4);
        //Debug.Log("stage5 = " + stage5);
        //Debug.Log("CS�F" + CS);
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
    public int goal2;
    public int goal3;

    void Start()
    {
        
    }

        void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))     // Input.GetKeyDown(KeyCode.S)// S�L�[�ŃZ�[�u���s
        {
            goal += 1;
            // goal�̐���10�ƂɂȂ�ƕۑ�
            var data = new SaveData();
            data.stage = 1;
            // JSON�ɃV���A���C�Y
            var json = JsonUtility.ToJson(data);
            // Assets�t�H���_�ɕۑ�����
            var path = Application.dataPath + "/" + SAVE_FILE_PATH;
            var writer = new StreamWriter(path, false); // �㏑��
            writer.WriteLine(json);
            writer.Flush();
            writer.Close();
        }
        

        //if (Input.GetKeyDown(KeyCode.L))
        /*if (Input.GetKeyDown(KeyCode.L))
        {
            // L�L�[�Ń��[�h���s
            // Assets�t�H���_���烍�[�h
            var info = new FileInfo(Application.dataPath + "/" + SAVE_FILE_PATH);
            var reader = new StreamReader(info.OpenRead());
            var json = reader.ReadToEnd();
            var data = JsonUtility.FromJson<SaveData>(json);
            data.Dump();
            //goal = data.CS;
            data.CS = goal;
        }*/
    }

    [InitializeOnLoad]//�G�f�B�^�[�N�����ɃR���X�g���N�^���Ă΂��悤��
    public static class PlayModeStateChangedExample
    {

        /// <summary>
        /// �R���X�g���N�^(InitializeOnLoad�����ɂ��G�f�B�^�[�N�����ɌĂяo�����)
        /// </summary>
        static PlayModeStateChangedExample()
        {

            //playModeStateChanged�C�x���g�Ƀ��\�b�h�o�^
            EditorApplication.playModeStateChanged += OnChangedPlayMode;

        }

        public static int goal { get; private set; }
        public static int goal2 { get; private set; }
        public static int goal3 { get; private set; }

        //�v���C���[�h���ύX���ꂽ
        private static void OnChangedPlayMode(PlayModeStateChange state)
        {
            if (state == PlayModeStateChange.ExitingEditMode)
            {
                Debug.Log("��~��Ԃ̏I���J�n�I(���s�{�^����������)");
                var info = new FileInfo(Application.dataPath + "/" + SAVE_FILE_PATH);
                var reader = new StreamReader(info.OpenRead());
                var json = reader.ReadToEnd();
                var data = JsonUtility.FromJson<SaveData>(json);
                data.Dump();

                Debug.Log("goal:" + goal);
                Debug.Log("goal2:" + goal2);
                Debug.Log("goal3:" + goal3);
            }
        }
    }
}
