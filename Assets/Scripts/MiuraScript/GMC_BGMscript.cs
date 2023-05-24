using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using KanKikuchi.AudioManager;

public class GMC_BGMscript : MonoBehaviour
{
    //�V���O���g���ݒ肱������
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
    //�V���O���g���ݒ肱���܂�


    // public GameObject ResultPanel;

    //BGM�W
    [SerializeField] private AudioSource BGM;
    [SerializeField] private AudioClip TitleBgm;
    [SerializeField] private AudioClip SelectBgm;
    [SerializeField] private AudioClip GameBGM;
    [SerializeField] private AudioClip ResultBGM;
    [SerializeField] private AudioClip GameOverBGM;

    private string beforeScene;//string�^�̕ϐ�beforeScene��錾 

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        BGM=this.GetComponent<AudioSource>();


        beforeScene = "Title";
        BGM.PlayOneShot(TitleBgm);

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

    void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
    {
        //�V�[�����ǂ��ς�������Ŕ���
        //�^�C�g������X�e�[�W�Z���N�g��
        if (beforeScene == "Title" && nextScene.name == "nagaya")
        {
            BGM.Stop();
            BGM.PlayOneShot(SelectBgm);
        }

        // �X�e�[�W�Z���N�g����Q�[����ʂ�(�\��j
        if (beforeScene == "nagaya" && nextScene.name == "Master_Final")
        {
            BGM.PlayOneShot(GameBGM);
            BGM.Stop();
        }

        //�X�e�[�W�Z���N�g����^�C�g����ʂ�
        if (beforeScene == "nagaya" && nextScene.name == "Title")
        {
            //if()//�^�C�g���֖߂�{�^�����������Ƃ�
            BGM.Stop();
            BGM.PlayOneShot(TitleBgm);
        }
        
        //�J�ڌ�̃V�[�������u�P�O�̃V�[�����v�Ƃ��ĕێ�
        beforeScene = nextScene.name;
    }

}
