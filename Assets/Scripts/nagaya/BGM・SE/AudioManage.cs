using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using KanKikuchi.AudioManager;

public class AudioManage : MonoBehaviour
{
    //�V���O���g���ݒ肱������
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
    //�V���O���g���ݒ肱���܂�



    int volume;


    [SerializeField] private AudioSource audio;
    [SerializeField] private AudioClip Bgm;

//    private string beforeScene;//string�^�̕ϐ�beforeScene��錾 


    // Start is called before the first frame update
    void Start()
    {
//      beforeScene = "Title(Proto)";
       audio.PlayOneShot(Bgm);

        //�V�[�����؂�ւ�������ɌĂ΂�郁�\�b�h��o�^
//        SceneManager.activeSceneChanged += OnActiveSceneChanged;
    }

    // Update is called once per frame
    void Update()
    {
     
    }

//    void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
//    {
//        //�V�[�����ǂ��ς�������Ŕ���
//        //Scene1����Scene2��
//        if (beforeScene == "Scene1" && nextScene.name == "Scene2")
//        {
//            A_BGM.Stop();
//            B_BGM.Play();
//        }
//
//        // Scene1����Scene2��
//        if (beforeScene == "Scene2" && nextScene.name == "Scene1")
//        {
//            A_BGM.Play();
//            B_BGM.Stop();
//        }
//
//
//        //�J�ڌ�̃V�[�������u�P�O�̃V�[�����v�Ƃ��ĕێ�
//        beforeScene = nextScene.name;
//    }
//

}
