using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // �C���X�y�N�^�[�r���[����ݒ肷��V�[����
    public string sceneName;

    // �C���X�y�N�^�[�r���[����ݒ肵���V�[����ǂݍ���
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
