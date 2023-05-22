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
        // BGMの音を流す
        audioSource = this.GetComponent<AudioSource>();
        audioSource.clip = GameBGM;
        audioSource.Play();
     }

    // Update is called once per frame
    void Update()
    {

    }

    // リザルト用BGM開始
    public void ResultBGMStart()
    {
        // BGM止める
        audioSource.Stop();
        // BGMの音を流す
        audioSource.clip = ResultBGM;
        audioSource.Play();
    }

    // ゲームオーバー用用BGM開始
    public void GameOverBGMStart()
    {
        // BGM止める
        audioSource.Stop();
        // BGMの音を流す
        audioSource.clip = GameOverBGM;
        audioSource.Play();
    }
}
