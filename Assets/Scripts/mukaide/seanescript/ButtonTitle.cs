using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonTitle : MonoBehaviour
{
    //　ポーズした時に表示するUI
    [SerializeField]
    private GameObject titleUI;
    //カウントダウン
    public float countdown;

    //ボタン設定
    private Button redo;

    public GameObject Image;
    private Fade fade;

    //SE
    public AudioManager SE;


    // Start is called before the first frame update
    void Start()
    {
        //Fadeの取得
        Image = GameObject.Find("Image");
        fade = Image.GetComponent<Fade>();

    }

    void Awake()
    {
        //ボタンの読み込み
        redo = GameObject.Find("Redo").GetComponent<Button>();
        //SE
        SE = GameObject.Find("AudioManage").GetComponent<AudioManager>();

        //ボタンが選択された状態になる
        redo.Select();

    }

    // Update is called once per frame
    void Update()
    {
        //ボタンが選択された状態になる
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
