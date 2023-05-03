using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using KanKikuchi.AudioManager;

public class AudioManage : MonoBehaviour
{
    //シングルトン設定ここから
 //  static public test5 instance;
 //
 //  private void Awake()
 //  {
 //      if (instance == null)
 //      {
 //          instance = this;
 //          DontDestroyOnLoad(this.gameObject);
 //      }
 //      else
 //      {
 //          Destroy(this.gameObject);
 //      }
 //
 //  }
    //シングルトン設定ここまで



    int volume;


    [SerializeField] private AudioSource audio;
    [SerializeField] private AudioClip Bgm;

//    private string beforeScene;//string型の変数beforeSceneを宣言 


    // Start is called before the first frame update
    void Start()
    {
//      beforeScene = "Title(Proto)";
       audio.PlayOneShot(Bgm);

        //シーンが切り替わった時に呼ばれるメソッドを登録
//        SceneManager.activeSceneChanged += OnActiveSceneChanged;
    }

    // Update is called once per frame
    void Update()
    {
     
    }

//    void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
//    {
//        //シーンがどう変わったかで判定
//        //Scene1からScene2へ
//        if (beforeScene == "Scene1" && nextScene.name == "Scene2")
//        {
//            A_BGM.Stop();
//            B_BGM.Play();
//        }
//
//        // Scene1からScene2へ
//        if (beforeScene == "Scene2" && nextScene.name == "Scene1")
//        {
//            A_BGM.Play();
//            B_BGM.Stop();
//        }
//
//
//        //遷移後のシーン名を「１つ前のシーン名」として保持
//        beforeScene = nextScene.name;
//    }
//

}
