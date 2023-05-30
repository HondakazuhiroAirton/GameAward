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
    [SerializeField] private AudioClip GameOverBgm;

    //SE�W
    [SerializeField] private AudioSource SE;
    [SerializeField] private AudioClip SelectSE;
    [SerializeField] private AudioClip MenuSE;
    [SerializeField] private AudioClip BeamSE;
    [SerializeField] private AudioClip PlayerMoveSE;
    [SerializeField] private AudioClip EnemyDefeatSE;
    [SerializeField] private AudioClip CursolSE;
    [SerializeField] private AudioClip CancelSE;
    [SerializeField] private AudioClip PauseSE;

    private string beforeScene;//string�^�̕ϐ�beforeScene��錾 
//  private string clearScene; //string�^�̕ϐ�clearScene��錾

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        beforeScene = "mTitleScene";
        BGM.PlayOneShot(TitleBgm, 0.03f);

        //�V�[�����؂�ւ�������ɌĂ΂�郁�\�b�h��o�^
        SceneManager.activeSceneChanged += OnActiveSceneChanged;
     // SceneManager.activeSceneChanged+=OnClearScene;
    }

    // Update is called once per frame
    void Update()
    {



    }

    void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
    {
        //�V�[�����ǂ��ς�������Ŕ���
        //�^�C�g������X�e�[�W�Z���N�g��
        if (beforeScene == "mTitleScene" && nextScene.name == "mSelectScene")
        {
            BGM.Stop();
            BGM.PlayOneShot(SelectBgm, 0.03f);
        }

        // �X�e�[�W�Z���N�g����Q�[����ʂ�(�\��j
        if (beforeScene == "mSelectScene" && nextScene.name == "mGameScene")
        {
            BGM.PlayOneShot(GameBgm, 0.03f);
            BGM.Stop();
        }

        //�X�e�[�W�Z���N�g����^�C�g����ʂ�
        if(beforeScene=="mSelectScene"&&nextScene.name=="mTitleScene")
        {
            //if()//�^�C�g���֖߂�{�^�����������Ƃ�
            BGM.Stop();
            BGM.PlayOneShot(TitleBgm, 0.03f);
        }


        //�J�ڌ�̃V�[�������u�P�O�̃V�[�����v�Ƃ��ĕێ�
        beforeScene = nextScene.name;
    }

    //�N���A�����Ƃ��ABGM��ύX
    //void OnClearScene(Scene prevScene,Scene nextScene)
    //{
    // if()
    // {
    //  BGM.Stop();
    //  BGM.PlayOneShot(ResultBgm);
    //      if()//���U���g�\�����ꂽ��
    //      {
    //          SE.PlayOneShot(MenuSE);
    //      }
    //  }
    // 
    // //�N���A����X�e�[�W�Z���N�g�֍s���Ƃ�
    //
    //if(ClearScene == "mGameScene" && nextScene.name =="mStageSelectScene")
    //  {
    // if()//�X�e�[�W�Z���N�g�{�^���������ꂽ��
    //   (
    //   BGM.Stop();
    //   BGM.PlayOneShot(SelectBgm);
    //   }
    //  }
    //
    // //�N���A����Q�[���v���C�i�R���e�B�j���[�j��
    // if()
    // {
    // if()//�{�^���������ꂽ��
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

    public void playCusolSE()
    {
        SE.PlayOneShot(CursolSE, 0.03f);
    }

    public void playBeamSE()
    {
        SE.PlayOneShot(BeamSE, 0.03f);
    }

    public void playEnemyDefeatSE()
    {
        SE.PlayOneShot(EnemyDefeatSE, 0.03f);
    }

    public void playPlayerMoveSE()
    {
        SE.PlayOneShot(PlayerMoveSE, 0.03f);
    }

    public void playPauseSE()
    {
        SE.PlayOneShot(PauseSE, 0.03f);
    }

    public void playselectSE()
    {
        SE.PlayOneShot(SelectSE, 0.03f);
    }

}
