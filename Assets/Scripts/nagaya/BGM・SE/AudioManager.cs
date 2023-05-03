using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using KanKikuchi.AudioManager;

public class AudioManager : MonoBehaviour
{
    //シングルトン設定ここから
    public static AudioManager instance;
  
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



    int volume;


    [SerializeField] private AudioSource A_BGM;
    [SerializeField] private AudioSource B_BGM;
    [SerializeField] private AudioClip A_Bgm;
    [SerializeField] private AudioClip B_Bgm;

    private string beforeScene;//string型の変数beforeSceneを宣言 


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        beforeScene = "Title(Proto)";
      A_BGM.PlayOneShot(A_Bgm);

        //シーンが切り替わった時に呼ばれるメソッドを登録
        SceneManager.activeSceneChanged += OnActiveSceneChanged;
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("nagaya");
        }
    }

    void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
    {
        //シーンがどう変わったかで判定
        //タイトルからステージセレクトへ
        if (beforeScene == "Title(Proto)" && nextScene.name == "nagaya")
        {
            A_BGM.Stop();
            B_BGM.PlayOneShot(B_Bgm);
        }
        
        // ステージセレクトからゲーム画面へ(予定）
        if (beforeScene == "nagaya" && nextScene.name == "Stage1")
        {
            A_BGM.PlayOneShot(A_Bgm);
            B_BGM.Stop();
        }


        //遷移後のシーン名を「１つ前のシーン名」として保持
        beforeScene = nextScene.name;
    }


}
