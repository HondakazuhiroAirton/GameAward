using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using KanKikuchi.AudioManager;

public class GMC_BGMscript : MonoBehaviour
{
    //シングルトン設定ここから
    public static GMC_BGMscript instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        else
        {
            Destroy(this.gameObject);
        }

    }
    //シングルトン設定ここまで


    // public GameObject ResultPanel;

    //BGM集
    [SerializeField] private AudioSource BGM;
    [SerializeField] private AudioClip TitleBgm;
    [SerializeField] private AudioClip SelectBgm;
    [SerializeField] private AudioClip GameBGM;
    [SerializeField] private AudioClip ResultBGM;
    [SerializeField] private AudioClip GameOverBGM;

    private string beforeScene;//string型の変数beforeSceneを宣言 

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        BGM=this.GetComponent<AudioSource>();


        beforeScene = "Title";
        BGM.PlayOneShot(TitleBgm);

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

    void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
    {
        //シーンがどう変わったかで判定
        //タイトルからステージセレクトへ
        if (beforeScene == "Title" && nextScene.name == "nagaya")
        {
            BGM.Stop();
            BGM.PlayOneShot(SelectBgm);
        }

        // ステージセレクトからゲーム画面へ(予定）
        if (beforeScene == "nagaya" && nextScene.name == "Master_Final")
        {
            BGM.PlayOneShot(GameBGM);
            BGM.Stop();
        }

        //ステージセレクトからタイトル画面へ
        if (beforeScene == "nagaya" && nextScene.name == "Title")
        {
            //if()//タイトルへ戻るボタンを押したとき
            BGM.Stop();
            BGM.PlayOneShot(TitleBgm);
        }
        
        //遷移後のシーン名を「１つ前のシーン名」として保持
        beforeScene = nextScene.name;
    }

}
