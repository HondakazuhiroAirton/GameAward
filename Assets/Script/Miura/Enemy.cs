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
    float movey = 3.0f;   // �ړ��� ��ɂ��������p�^�b�Ƃ����Ƃ��ɓ�����
    int StartCount; // �ŏ��Ƀp�^�p�^�����
    float FallTime = 1.0f; // �Q�[���J�n���Ă��痎�����鉽�����Ȃ�����
    float StartPataPataTime = 0.6f; // �ŏ��Ƀp�^�p�^���鎞�ԊԊu
    Vector3 MoveValue;
    public bool GroundCollision;

    void Start()
    {
        time = 0f;
        State = 1;
        StartCount = 0;
        GroundCollision = false;
    }

    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);

        // �g���Ă݂��͂������A�g�������킩��Ȃ��I�I
        time += Time.deltaTime;
        if (State == 1) // �ŏ�
        {
            if (FallTime < time)
            {
                time = 0f;
                State = 2;
            }
        }
        if (State == 2) // �ŏ�
        {
            if (Input.GetKeyDown("space"))
            //if (StartPataPataTime < time)
            {
                //time = 0f;
                MoveValue.y = movey * Time.deltaTime;
                Debug.Log("�W�����v������");
                //StartCount++;
            }

            //if (StartCount > 4) // 5��p�^�p�^������
            //{
            //    State = 3; // ���̏�Ԃ�
            //}

        }
        else if (State == 3)// 1:�G�Ƃ��ďP���������Ă�����
        {
            // �P���������Ă��铮��,��莞�Ԍo�߂�POS�����������B
            if (MoveTime < time)
            {
                time = 0f;
                MoveValue.y = movey * Time.deltaTime;
                movex *= -1;
            }

            MoveValue.x = movex * Time.deltaTime;


            // �n�ʂƈ��̋������m������A�W�����v���鏈��
            if (GroundCollision == true)// �����AGround�Ɠ���������
            {
                MoveValue.y = movey * Time.deltaTime;
                GroundCollision = false;
            }
        }

        // �ړ��𔽉f����O�ɂӂ�ӂ킵������������Ƃ����̂��ȁH�H


        // �d�͐ݒ�(�����蔻�胏�P���J�����N�Ȃ����̂ň�U�R�����g�A�E�g)
        // MoveValue.y = MoveValue.y - movey / 5  * Time.deltaTime ;

        // �ړ��𔽉f
        transform.Translate(MoveValue);

        // ��ʊO����ǂ�����H�H

    }

    public void SetJump() // GroundCollision�N�������蔻������m�����狳���Ă����
    {
        if (State == 3)
        {
            GroundCollision = true;

        }
    }
}


// 1.RigitBody���O�����Ƃ��ɒn�ʂƂ̓����蔻��Ȃ��Ȃ�܂����B
// 2.
// 
// 