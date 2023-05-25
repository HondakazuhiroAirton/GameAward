using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonTitle : MonoBehaviour
{
    //�@�|�[�Y�������ɕ\������UI
    [SerializeField]
    private GameObject titleUI;
    //�J�E���g�_�E��
    public float countdown;

    //�{�^���ݒ�
    private Button redo;

    public GameObject Image;
    private Fade fade;

    //SE
    public AudioManager SE;


    // Start is called before the first frame update
    void Start()
    {
        //Fade�̎擾
        Image = GameObject.Find("Image");
        fade = Image.GetComponent<Fade>();

    }

    void Awake()
    {
        //�{�^���̓ǂݍ���
        redo = GameObject.Find("Redo").GetComponent<Button>();
        //SE
        SE = GameObject.Find("AudioManage").GetComponent<AudioManager>();

        //�{�^�����I�����ꂽ��ԂɂȂ�
        redo.Select();

    }

    // Update is called once per frame
    void Update()
    {
        //�{�^�����I�����ꂽ��ԂɂȂ�
        redo.Select();
        if (Input.GetKeyDown(KeyCode.Return))
        {
            redo.interactable = false;
            SE.playselectSE();
            fade.GameSelect();
        }

    }

    public void ButtonRedo()
    {
        if (fade.Fadeflag() == false)
        {
            redo.interactable = false;
            SE.playselectSE();
            fade.GameSelect();
        }
    }

}