using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursoll : MonoBehaviour
{
    // �Q�[���I�u�W�F�N�g�z��ŊǗ�
    public GameObject[] iti;

    // ���̈ʒu�����Ă����ϐ�
    [SerializeField] private int NowPosition;

    void Start()
    {
        // �ŏ��̓X�e�[�W1
        NowPosition = 0;
        this.transform.position = iti[NowPosition].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            NowPosition += 1;
            if (NowPosition > 2/*<-�}�W�b�N�i���o�[ ���[���h�̍��v�̐�-1����ꂽ��*/) NowPosition = 0;
            this.transform.position = iti[NowPosition].transform.position;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            NowPosition -= 1;
            if (NowPosition < 0) NowPosition = 2;/*<-�}�W�b�N�i���o�[ ���[���h�̍��v�̐�-1����ꂽ��*/
            this.transform.position = iti[NowPosition].transform.position;
        }
    }
}
