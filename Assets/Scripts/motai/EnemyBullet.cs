using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    // �L���[�u(�G��)
    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;
    // �eNo
    public int BallNo;
    // �GNo
    public int EnemyNo;
    public GameObject EnemyManager;
    public GameObject Enemy;

    GameObject player;
    Animator animator;
    private int maxtime;
    public const float mintime = 2.0f;
    public float time;

    void Start()
    {
        // animator�R���|�[�l���g���擾
        animator = GetComponent<Animator>();

        player = GameObject.Find("Player");
        Enemy = transform.parent.gameObject;
        EnemyManager = GameObject.Find("EnemyGroup(Clone)");


        maxtime = UnityEngine.Random.Range(5, 10);
        Debug.Log("maxtime >" + maxtime);
    }

    void Update()
    {
        if (player == null) return;

        time += Time.deltaTime;

        //if (time >= mintime)// 2�b��������A�j���[�V�����X�^�[�g
        //{
        //    animator.SetBool("enemyS_flag", true);//3�b�`4�b�E4�b�`5�b��2��
        //}
        if (time >= maxtime)// 5�`10�b��������e���o�ăA�j���[�V�����X�g�b�v
        {
            //animator.SetBool("enemyS_flag", false);
            BallShot();
            time = 0;
        }
    }

    void BallShot()// �L���[�u(�G��)
    {
        // ���܂𐶂ݏo���Ă�
        EnemyNo = Enemy.GetComponent<Enemy>().GetEnemyIndex();
        BallNo = (int)EnemyManager.GetComponent<EnemyManager>().GetBulletType(EnemyNo);
        switch (BallNo)
        {
            case 1:
                Instantiate(ball1, transform.position, this.transform.rotation);
                break;
            case 2:
                Instantiate(ball2, transform.position, this.transform.rotation);
                break;
            case 3:
                Instantiate(ball3, transform.position, this.transform.rotation);
                break;
            default:
                break;
        }
        maxtime = UnityEngine.Random.Range(5, 10);
        Debug.Log("maxtime >" + maxtime);
    }
}