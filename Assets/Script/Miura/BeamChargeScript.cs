using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BeamComboScript : MonoBehaviour
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
        // tmpにComboの数値を入れて
        float tmpCombo = PlayerClassScript.GetAmount();

        // 毎フレームビーム残量(Amount)の値を表示する
        this.textComponent.text = tmpCombo + "Combo" .ToString();

    }
}
