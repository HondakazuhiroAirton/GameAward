using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BeamChargeScript : MonoBehaviour
{
    // プレイヤーデータオブジェクト保持
    public GameObject PlayerDate;
    // Geter使用用のスクリプト保持
    public PlayerClass PlayerClassScript;
    // このオブジェクトのテキストコンポーネント保存
    private TextMeshProUGUI textComponent;
    void Start()
    {
        // スクリプトを拾ってくる
        PlayerClassScript = PlayerDate.GetComponent<PlayerClass>();
        // テキストコンポーネント取得
        textComponent = this.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        // tmpにAmountの数値を入れて
        float tmpAmount = PlayerClassScript.GetAmount();

        // 桁を1つずつ取り出して表示したほうが制御しやすいかも
        // 表示を少数第2位までにする**********************
        // 右に2シフト
        tmpAmount = tmpAmount * 100;
        // あまりを取る
        float Amari = tmpAmount % 1;
        // 引く
        tmpAmount = tmpAmount - Amari;
        // 左に2シフトして戻す
        tmpAmount = tmpAmount / 100;
        //************************************************

        // 毎フレームビーム残量(Amount)の値を表示する
        this.textComponent.text =  tmpAmount +"%" .ToString();

    }
}
