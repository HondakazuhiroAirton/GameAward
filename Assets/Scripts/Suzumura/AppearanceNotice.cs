using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppearanceNotice : MonoBehaviour
{
    public GameObject Object;
    //フェード後に呼び出されるメゾッド
    private static void OnFinished() { }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            // テスト用
            CanvasFader.Begin(Object, false, 0.7f, true, OnFinished);
        }
    }

    public void StartFade()
    {
        CanvasFader.Begin(Object, false, 0.7f, true, OnFinished);

    }
}
