// �Ƃ肠����������p�^�[���P
// �v���C���[�̂��Ƃ��l�����A���R�ɓ����G

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // �O���[�o���ϐ��݂����Ƀt�B�[���h���g���܂�
    public int State = 1; // �G�l�~�[�̏�Ԃ�����ϐ��B�����l�͓G�Ƃ��ďP���������Ă�����
    public float MoveTime = 10f;  // �s�����ς�鎞��
    float time = 0f;
    float movex = 0.001f;   // �ړ���
                            // ���݂̃|�W�V�����擾
    Vector3 MoveValue;
    void Start()
    {
        time = 0f;
        State = 1;
    }

    void Update()
    {



        // �g���Ă݂��͂������A�g�������킩��Ȃ��I�I
        time += Time.deltaTime;

        if (State == 1)// 1:�G�Ƃ��ďP���������Ă�����
        {
            // �P���������Ă��铮��,��莞�Ԍo�߂�POS�����������B
            if (MoveTime < time)
            {
                time = 0f;
                movex *= -1;
            }



            // ���̕ӂɒn�ʂƈ��̋������m������A��ɗ͂������鏈����������A�����Ȃ���



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

        // �ړ��𔽉f����O�ɂӂ�ӂ킵������������Ƃ����̂��ȁH�H

        // �ړ��𔽉f
        transform.Translate(MoveValue);

        // ��ʊO����ǂ�����H�H

    }
}
