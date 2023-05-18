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
    private Button Continue;

    public GameObject Image;

    //SE
    public AudioManager SE;


    // Start is called before the first frame update
    void Start()
    {
        //Fadeの取得
        Image = GameObject.Find("Image");

        //ボタンが選択された状態になる
        redo.Select();
    }
    void Awake()
    {
        //ボタンの読み込み
        redo = GameObject.Find("Redo").GetComponent<Button>();
        Continue = GameObject.Find("Continue").GetComponent<Button>();
        //SE
        SE = GameObject.Find("AudioManage").GetComponent<AudioManager>();

        titleUI.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        //時間をカウントダウンする
        countdown -= Time.deltaTime;



        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)|| Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {

            SE.playCusolSE();
        }
    

        //countdownが0以下になったとき
        if (countdown <= 0)
        {
            countdown = 0;

            // パネルUIのアクティブ非アクティブを切り替え
            Active();
        }

    }

    public void ButtonRedo()
    {
        redo.interactable = false;
        SE.playselectSE();
        Image.GetComponent<Fade>().GameSelect();
    }

    public void ButtonContinue()
    {
        Continue.interactable = false;
        SE.playselectSE();
        Image.GetComponent<Fade>().GameSelect();
    }

    public void Active()
    {
        //パネルUIのアクティブ、非アクティブを切り替え
        titleUI.SetActive(true);
    }
}
