using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMC_BGMscript : MonoBehaviour
{
   // public GameObject ResultPanel;

    public AudioClip GameBGM;
    public AudioClip ResultBGM;
    public AudioClip GameOverBGM;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        // BGM�̉��𗬂�
        audioSource = this.GetComponent<AudioSource>();
        audioSource.clip = GameBGM;
        audioSource.Play();
     }

    // Update is called once per frame
    void Update()
    {

    }

    // ���U���g�pBGM�J�n
    public void ResultBGMStart()
    {
        // BGM�~�߂�
        audioSource.Stop();
        // BGM�̉��𗬂�
        audioSource.clip = ResultBGM;
        audioSource.Play();
    }

    // �Q�[���I�[�o�[�p�pBGM�J�n
    public void GameOverBGMStart()
    {
        // BGM�~�߂�
        audioSource.Stop();
        // BGM�̉��𗬂�
        audioSource.clip = GameOverBGM;
        audioSource.Play();
    }
}
