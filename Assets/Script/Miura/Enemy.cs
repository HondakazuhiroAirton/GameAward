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
    float movex = 1.0f;   // �ړ���
    float movey = 5.0f;   // �ړ��� ��ɂ��������p�^�b�Ƃ����Ƃ��ɓ�����
    int StartCount; // �ŏ��Ƀp�^�p�^�����
    float StartPataPataTime = 1.0f; // �ŏ��Ƀp�^�p�^���鎞�ԊԊu
    Vector3 MoveValue;
    public CollisionGround CollisionGroundScript;
    void Start()
    {
        time = 0f;
        State = 0;
        StartCount = 0;
    }

    void Update()
    {

        // �g���Ă݂��͂������A�g�������킩��Ȃ��I�I
        time += Time.deltaTime;

        if(State == 0) // �ŏ�0
        {
            if (StartPataPataTime < time)
            {
                time = 0f;
                MoveValue.y = movey * Time.deltaTime;
                StartCount++;
            }


            if (StartCount > 5) // 5��p�^�p�^������
            {
                State = 1; // ���̏�Ԃ�
            }

        }
        else if (State == 1)// 1:�G�Ƃ��ďP���������Ă�����
        {
            // �P���������Ă��铮��,��莞�Ԍo�߂�POS�����������B
            if (MoveTime < time)
            {
                time = 0f;
                MoveValue.y = movey * Time.deltaTime;
                movex *= -1;
            }


            MoveValue.x = movex * Time.deltaTime;
            // ���̕ӂɒn�ʂƈ��̋������m������A��ɗ͂������鏈����������A�����Ȃ���

            if (CollisionGroundScript.GroundCollision == true)// �����AGround�Ɠ���������
            {
                MoveValue.y = movey * Time.deltaTime;
            }


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
