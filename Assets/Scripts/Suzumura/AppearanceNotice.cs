using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppearanceNotice : MonoBehaviour
{
    // �I���W�i���̃I�u�W�F�N�g
    public GameObject ExclamationMark;

    public GameObject Object;
    //�t�F�[�h��ɌĂяo����郁�]�b�h
    private void OnFinished() { }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // �e�X�g�p
        if (Input.GetKeyDown(KeyCode.A))
        {
            CanvasFader.Begin(Object, false, 0.7f, true, OnFinished);
        }
    }

    // �G�o���\���u!�v+ �t�F�[�h
    public void StartFade(Vector3 Entry)
    {
        Object = Instantiate(ExclamationMark,
        Entry,
        Quaternion.identity);
        CanvasFader.Begin(Object, false, 0.7f, true, OnFinished);
    }
}
