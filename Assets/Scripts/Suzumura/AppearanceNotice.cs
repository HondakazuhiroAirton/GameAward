using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppearanceNotice : MonoBehaviour
{
    // オリジナルのオブジェクト
    public GameObject ExclamationMark;

    public GameObject Object;
    //フェード後に呼び出されるメゾッド
    private void OnFinished() { }

    // 角度反映用変数
    private int angle = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // テスト用
        if (Input.GetKeyDown(KeyCode.A))
        {
            CanvasFader.Begin(Object, false, 0.7f, true, OnFinished);
        }
    }

    // 敵出現予告「!」+ フェード
    public void StartFade(Vector3 Entry, int sideNo)
    {
        // 画面の端の位置によって角度を変える(「！」はそのまま)
        switch (sideNo)
        {
            case 1: angle = 0; break;
            case 2: angle = 90; break;
            case 3: angle = 180; break;
            case 4: angle = 270; break;
            default: break;
        }
        // インスタンス
        Object = Instantiate(ExclamationMark,
            Entry,
            Quaternion.Euler(0, 0, 0));
        GameObject Rail = this.transform.Find("Rail").gameObject;
        Rail.transform.Rotate(new Vector3(0, 0, angle));

        // フェードスタート
        CanvasFader.Begin(Object, false, 0.7f, true, OnFinished);
    }

    // クローンを削除する関数
    public void DestroyExclamation()
    {
        Destroy(gameObject);
    }
}
