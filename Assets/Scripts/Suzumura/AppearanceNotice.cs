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
    public void StartFade(Vector3 Entry)
    {
        Object = Instantiate(ExclamationMark,
        Entry,
        Quaternion.identity);
        CanvasFader.Begin(Object, false, 0.7f, true, OnFinished);
    }
}
