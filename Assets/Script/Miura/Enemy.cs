// �Ƃ肠����������p�^�[���P
// �v���C���[�̂��Ƃ��l�����A���R�ɓ����G

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // �O���[�o���ϐ��݂����Ƀt�B�[���h���g���܂�
    public int State = 1; // �G�l�~�[�̏�Ԃ�����ϐ��B�����l�͓G�Ƃ��ďP���������Ă�����
    //public float MoveTime = 10f;  // �s�����ς�鎞��
    //float time = 0f;
    //float movex = 1.0f;   // �ړ���
    //float movey = 5.0f;   // �ړ��� ��ɂ��������p�^�b�Ƃ����Ƃ��ɓ�����
    //int StartCount; // �ŏ��Ƀp�^�p�^�����
    //float StartPataPataTime = 1.0f; // �ŏ��Ƀp�^�p�^���鎞�ԊԊu
    //Vector3 MoveValue;


    static GameObject Player;
    Vector2 PlayerPos;
    Vector2 EnemyPos;
    Rigidbody2D rb;
    float valuex;
    float valuey;
    float clampMin;
    float clampMax;
    // �v���C���[�̃I�u�W�F�N�g���擾


    void Start()
    {
        //time = 0f;
        //StartCount = 0;
        State = 0;
 
        Player = GameObject.Find("Player");
        PlayerPos = Player.transform.position ;
        rb = this.GetComponent<Rigidbody2D>();  // rigidbody���擾
        clampMin = -50;
        clampMax = 50;
    }

    void Update()
    {

        //if (State == 0) // �ŏ�0
        //{
        //    if (StartPataPataTime < time)
        //    {
        //        time = 0f;
        //        MoveValue.y = movey * Time.deltaTime;
        //        StartCount++;
        //    }


        //    if (StartCount > 5) // 5��p�^�p�^������
        //    {
        //        State = 1; // ���̏�Ԃ�
        //    }

        //}
        //else 
        if (State == 1)// 0:�G�Ƃ��ďP���������Ă�����
        {
            // �G�Ǝ����̈ʒu���r
            EnemyPos = this.transform.position;
            PlayerPos = Player.transform.position;
            Vector2 Compare = new Vector2(EnemyPos.x - PlayerPos.x, EnemyPos.y - PlayerPos.y);


            if (Compare.x >= 0.5)
            {
                rb.AddForce(new Vector2(-0.1f,0f));
            }
            else if (Compare.x <= -0.05)
            {
                rb.AddForce(new Vector2(0.1f,0f));
            }

            if (Compare.y >= 0.2)
            {
                //rb.AddForce(new Vector2(0,-30));
            }
            else if (Compare.y <= -0.2)
            {
                rb.AddForce(new Vector2(0, 5));
            }

            rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, clampMin, clampMax),
                                      Mathf.Clamp(rb.velocity.y, clampMin, clampMax));

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


        // ��ʊO����ǂ�����H�H

    }

    public void SetEnemyState(int StateID)
    {
        State = StateID;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("�v���C���[�Ƃ���������");
            EnemyPos = this.transform.position;
            PlayerPos = Player.transform.position;
            Vector2 Compare = new Vector2(EnemyPos.x - PlayerPos.x, EnemyPos.y - PlayerPos.y);

            if (Compare.x > 0)
            {
                rb.AddForce(new Vector2( 1000f, 0f));
            }
            else if (Compare.x <= 0)
            {
                rb.AddForce(new Vector2( -1000f, 0f));
            }

        }

    }
}
