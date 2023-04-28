using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppearanceNotice : MonoBehaviour
{
    // �I���W�i���̃I�u�W�F�N�g
    public GameObject ExclamationMark;
    public GameObject Rail;

    public GameObject ExObject;
    public GameObject RaObject;
    //�t�F�[�h��ɌĂяo����郁�]�b�h
    private void OnFinished() { }

    // �p�x���f�p�ϐ�
    private int angle = 0;

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
            //CanvasFader.Begin(Object, false, 0.7f, true, OnFinished);
        }
    }

    // �G�o���\���u!�v+ �t�F�[�h
    public void StartFade(Vector3 Entry, int sideNo)
    {
        // ��ʂ̒[�̈ʒu�ɂ���Ċp�x��ς���(�u�I�v�͂��̂܂�)
        switch (sideNo)
        {
            case 1: angle = 0; break;
            case 2: angle = 90; break;
            case 3: angle = 180; break;
            case 4: angle = 270; break;
            default: break;
        }
        // �C���X�^���X
        ExObject = Instantiate(ExclamationMark,
            Entry,
            Quaternion.identity);
        RaObject = Instantiate(Rail,
            Entry,
            Quaternion.Euler(0, 0, angle));

        // �t�F�[�h�X�^�[�g
        CanvasFader.Begin(ExObject, false, 0.7f, true, OnFinished);
        CanvasFader.Begin(RaObject, false, 0.7f, true, OnFinished);
    }

    // �N���[�����폜����֐�
    public void DestroyExclamation()
    {
        Destroy(gameObject);
    }
}
