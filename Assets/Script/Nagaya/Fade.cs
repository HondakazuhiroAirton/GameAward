using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    [SerializeField]    
    private GameObject  panelFade;   //フェードパネル

    [SerializeField, Range(0, 1)]
    private float alpha;            //アルファ値、0～1にRangeを設定

    private Image panel_fadeImage;  //フェードパネルのImage

    private bool fadeout, fadein;   //フェードのフラグ

    private int scenNumber;         //シーンナンバー


    // Start is called before the first frame update
    void Start()
    {
        panel_fadeImage = panelFade.GetComponent<Image>();
        PanelEnabled();

        FadeIn();
    }

    // Update is called once per frame
    void Update()
    {
        if (fadein)
            FadeInOperation();

        if (fadeout)
            FadeOutOperation();
    }

    //フェードイン呼び出し
    private void FadeIn()
    {
        if (alpha != 1)
            alpha = 1f;

        fadein = true;
    }

    //フェードアウト呼び出し
    private void FadeOut()
    {
        if (alpha != 0)
            alpha = 0f;

        fadeout = true;
    }

    //フェードイン操作
    private void FadeInOperation()
    {
        alpha -= 0.01f;

        var tempColor = panel_fadeImage.color;

        tempColor.a = alpha;
        panel_fadeImage.color = tempColor;

        PanelEnabled();

        if (alpha <= 0)
            fadein = false;

    }

    //フェードアウト操作とシーン遷移
    private void FadeOutOperation()
    {
        alpha += 0.01f;

        var tempColor = panel_fadeImage.color;

        tempColor.a = alpha;
        panel_fadeImage.color = tempColor;

        PanelEnabled();

        if (alpha >= 1)
        {
            fadeout = false;
            SceneManager.LoadScene(scenNumber);
        }
    }

    //フェードパネルの表示状態管理
    private void PanelEnabled()
    {
       
    }

    //シーン遷移時のボタン操作
    public void SceneMove(int num)
    { 
        scenNumber = num;
        FadeOut();
    }
}
