// �Ƃ肠����������p�^�[���P
// �v���C���[�̂��Ƃ��l�����A���R�ɓ����G

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // �O���[�o���ϐ��݂����Ƀt�B�[���h���g���܂�
    public int State = 1; // �G�l�~�[�̏�Ԃ�����ϐ��B�����l�͓G�Ƃ��ďP���������Ă�����
    public float MoveTime = 1.5f;  // �s�����ς�鎞��
    float time = 0f;

    void Start()
    {
        time = 0f;
    }

    void Update()
    {
        // ���݂̃|�W�V�����擾
        Vector2 pos = transform.position;
        float movex = 0.001f;

        // �g���Ă݂��͂������A�A�A
        time += Time.deltaTime;

        if (State == 1)// 1:�G�Ƃ��ďP���������Ă�����
        {
            // �P���������Ă��铮��
            MoveTime -= 1;
            if(MoveTime < time)
            {
                time = 0f;
                movex *= -1;
            }

            pos.x -= movex;

            // Player�̓����蔻������m������A���(State)��2(�����^�΂���)�ɕύX
            //if ()
            //{ 
            //    State == 2
            //}
        }
        else if (State == 2)// 2:�^�΂�Ă�����
        {
            // �^�΂�Ă����Ԃ̓���




            // �����̓����蔻������m������A���(State)��ύX
            //if ()
            //{ 
            //    State == 3
            //}
        }
        else // �����ɓ�����ďo��Ȃ���Ԃ����ɏ�������ǂ�����
        {


        }

        // �ړ��𔽉f
        transform.position = pos;

        // ��ʊO����ǂ�����H�H

    }
}
