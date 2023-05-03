using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using KanKikuchi.AudioManager;

public class AudioManager : MonoBehaviour
{
    //�V���O���g���ݒ肱������
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
    //�V���O���g���ݒ肱���܂�



    int volume;


    [SerializeField] private AudioSource A_BGM;
    [SerializeField] private AudioSource B_BGM;
    [SerializeField] private AudioClip A_Bgm;
    [SerializeField] private AudioClip B_Bgm;

    private string beforeScene;//string�^�̕ϐ�beforeScene��錾 


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        beforeScene = "Title(Proto)";
      A_BGM.PlayOneShot(A_Bgm);

        //�V�[�����؂�ւ�������ɌĂ΂�郁�\�b�h��o�^
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
        //�V�[�����ǂ��ς�������Ŕ���
        //�^�C�g������X�e�[�W�Z���N�g��
        if (beforeScene == "Title(Proto)" && nextScene.name == "nagaya")
        {
            A_BGM.Stop();
            B_BGM.PlayOneShot(B_Bgm);
        }
        
        // �X�e�[�W�Z���N�g����Q�[����ʂ�(�\��j
        if (beforeScene == "nagaya" && nextScene.name == "Stage1")
        {
            A_BGM.PlayOneShot(A_Bgm);
            B_BGM.Stop();
        }


        //�J�ڌ�̃V�[�������u�P�O�̃V�[�����v�Ƃ��ĕێ�
        beforeScene = nextScene.name;
    }


}
