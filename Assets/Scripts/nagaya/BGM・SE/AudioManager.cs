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


    //BGM�W
    [SerializeField] private AudioSource BGM;
    [SerializeField] private AudioClip TitleBgm;
    [SerializeField] private AudioClip SelectBgm;
    [SerializeField] private AudioClip GameBgm;
    [SerializeField] private AudioClip ResultBgm;

    //SE�W
    [SerializeField] private AudioSource SE;
    [SerializeField] private AudioClip SelectSE;
    [SerializeField] private AudioClip MenuSE;
    [SerializeField] private AudioClip BeamSE;
    [SerializeField] private AudioClip PlayerMoveSE;
    [SerializeField] private AudioClip EnemyDefeatSE;
    [SerializeField] private AudioClip CursolSE;

    private string beforeScene;//string�^�̕ϐ�beforeScene��錾 
//  private string clearScene; //string�^�̕ϐ�clearScene��錾

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        beforeScene = "Title(Proto)";
        BGM.PlayOneShot(TitleBgm);

        //�V�[�����؂�ւ�������ɌĂ΂�郁�\�b�h��o�^
        SceneManager.activeSceneChanged += OnActiveSceneChanged;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SE.PlayOneShot(SelectSE);
            SceneManager.LoadScene("nagaya");
        }


    }

    void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
    {
        //�V�[�����ǂ��ς�������Ŕ���
        //�^�C�g������X�e�[�W�Z���N�g��
        if (beforeScene == "Title(Proto)" && nextScene.name == "nagaya")
        {
            BGM.Stop();
            BGM.PlayOneShot(SelectBgm);
        }

        // �X�e�[�W�Z���N�g����Q�[����ʂ�(�\��j
        if (beforeScene == "nagaya" && nextScene.name == "Stage1")
        {
            BGM.PlayOneShot(TitleBgm);
            BGM.Stop();
        }


        //�J�ڌ�̃V�[�������u�P�O�̃V�[�����v�Ƃ��ĕێ�
        beforeScene = nextScene.name;
    }

    //�N���A�����Ƃ��ABGM��ύX
    //void OnClearScene(Scene prevScene,Scene nextScene)
    //{
    // if()
    // {
    // BGM.Stop();
    // BGM.PlayOneShot(ResultBgm);
    //  }
    // 
    // //�N���A����X�e�[�W�Z���N�g�֍s���Ƃ�
    // if()
    //  {
    // BGM.Stop();
    // BGM.PlayOneShot(SelectBgm);
    //  }
    //
    // //�N���A����Q�[���v���C�i�R���e�B�j���[�j��
    // if()
    // {
    // BGM.Stop();
    // BGM.PlayOneShot(GameBgm);
    //}
    // ClearScene=nextScene.name;
    //}
    //
    //
    //
    //
}
