using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppearanceNotice : MonoBehaviour
{
    public GameObject Object;
    //�t�F�[�h��ɌĂяo����郁�]�b�h
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
            // �e�X�g�p
            CanvasFader.Begin(Object, false, 0.7f, true, OnFinished);
        }
    }

    public void StartFade()
    {
        CanvasFader.Begin(Object, false, 0.7f, true, OnFinished);

    }
}
