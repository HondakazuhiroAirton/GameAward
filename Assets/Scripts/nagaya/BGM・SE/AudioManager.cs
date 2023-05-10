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


    //BGM集
    [SerializeField] private AudioSource BGM;
    [SerializeField] private AudioClip TitleBgm;
    [SerializeField] private AudioClip SelectBgm;
    [SerializeField] private AudioClip GameBgm;
    [SerializeField] private AudioClip ResultBgm;
    [SerializeField] private AudioClip GameOverBgm;

    //SE集
    [SerializeField] private AudioSource SE;
    [SerializeField] private AudioClip SelectSE;
    [SerializeField] private AudioClip MenuSE;
    [SerializeField] private AudioClip BeamSE;
    [SerializeField] private AudioClip PlayerMoveSE;
    [SerializeField] private AudioClip EnemyDefeatSE;
    [SerializeField] private AudioClip CursolSE;
    [SerializeField] private AudioClip CancelSE;
    [SerializeField] private AudioClip PauseSE;

    private string beforeScene;//string型の変数beforeSceneを宣言 
//  private string clearScene; //string型の変数clearSceneを宣言

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        beforeScene = "mTitleScene";
        BGM.PlayOneShot(TitleBgm);

        //シーンが切り替わった時に呼ばれるメソッドを登録
        SceneManager.activeSceneChanged += OnActiveSceneChanged;
     // SceneManager.activeSceneChanged+=OnClearScene;
    }

    // Update is called once per frame
    void Update()
    {
  //   if (Input.GetKeyDown(KeyCode.Return))
  //   {
  //       SE.PlayOneShot(SelectSE);
  //       SceneManager.LoadScene("mSelectScene");
  //   }


    }

    void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
    {
        //シーンがどう変わったかで判定
        //タイトルからステージセレクトへ
        if (beforeScene == "mTitleScene" && nextScene.name == "mSelectScene")
        {
            BGM.Stop();
            BGM.PlayOneShot(SelectBgm);
        }

        // ステージセレクトからゲーム画面へ(予定）
        if (beforeScene == "mSelectScene" && nextScene.name == "mGameScene")
        {
            BGM.PlayOneShot(GameBgm);
            BGM.Stop();
        }

        //ステージセレクトからタイトル画面へ
        if(beforeScene=="mSelectScene"&&nextScene.name=="mTitleScene")
        {
            //if()//タイトルへ戻るボタンを押したとき
            BGM.Stop();
            BGM.PlayOneShot(TitleBgm);
        }


        //遷移後のシーン名を「１つ前のシーン名」として保持
        beforeScene = nextScene.name;
    }

    //クリアしたとき、BGMを変更
    //void OnClearScene(Scene prevScene,Scene nextScene)
    //{
    // if()
    // {
    //  BGM.Stop();
    //  BGM.PlayOneShot(ResultBgm);
    //      if()//リザルト表示された時
    //      {
    //          SE.PlayOneShot(MenuSE);
    //      }
    //  }
    // 
    // //クリアからステージセレクトへ行くとき
    //
    //if(ClearScene == "mGameScene" && nextScene.name =="mStageSelectScene")
    //  {
    // if()//ステージセレクトボタンが押された時
    //   (
    //   BGM.Stop();
    //   BGM.PlayOneShot(SelectBgm);
    //   }
    //  }
    //
    // //クリアからゲームプレイ（コンティニュー）へ
    // if()
    // {
    // if()//ボタンが押された時
    //       {
    //       BGM.Stop();
    //       BGM.PlayOneShot(GameBgm);
    //       }
    // }
    //}
    // ClearScene=nextScene.name;
    //}
    //
    //
    //
    //

    void playCusolSE()
    {
        SE.PlayOneShot(CursolSE);
    }

    void playBeamSE()
    {
        SE.PlayOneShot(BeamSE);
    }

    void playEnemyDefeatSE()
    {
        SE.PlayOneShot(EnemyDefeatSE);
    }

    void playPlayerMoveSE()
    {
        SE.PlayOneShot(PlayerMoveSE);
    }

    void playPauseSE()
    {
        SE.PlayOneShot(PauseSE);
    }

}
