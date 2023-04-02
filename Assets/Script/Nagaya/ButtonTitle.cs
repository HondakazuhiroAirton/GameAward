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


    // Start is called before the first frame update
    void Start()
    {
        Image = GameObject.Find("Image");

        //ボタンの読み込み
        redo = GameObject.Find("Redo").GetComponent<Button>();
        Continue = GameObject.Find("Continue").GetComponent<Button>();

        titleUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //時間をカウントダウンする
        countdown -= Time.deltaTime;
        

        //countdownが0以下になったとき
        if (countdown <= 0)
        {
            countdown = 0;

            // パネルUIのアクティブ非アクティブを切り替え
            Active();
            //ボタンが選択された状態になる
            redo.Select();
        }
        
    }

    public void ButtonRedo()
    {
        Image.GetComponent<Fade>().GameSelect();
    }

    public void ButtonContinue()
    {
        Image.GetComponent<Fade>().GameSelect();
    }

    public void Active()
    {
        //パネルUIのアクティブ、非アクティブを切り替え
        titleUI.SetActive(true);
    }
}
