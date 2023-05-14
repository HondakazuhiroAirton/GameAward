using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    // キューブ(敵に)
    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;
    // 弾No
    public int BallNo;
    // 敵No
    public int EnemyNo;
    public GameObject EnemyManager;
    public GameObject Enemy;

    GameObject player;
    Animator animator;
    public const float maxtime = 5.0f;
    public const float mintime = 2.0f;
    public float time;

    void Start()
    {
        // animatorコンポーネントを取得
        animator = GetComponent<Animator>();

        player = GameObject.Find("Player");
        Enemy = transform.parent.gameObject;
        EnemyManager = GameObject.Find("EnemyGroup (Clone)");
    }

    void Update()
    {
        if (player == null) return;

        time += Time.deltaTime;

        if (time >= mintime)// 2秒たったらアニメーションスタート
        {
            animator.SetBool("enemyS_flag", true);//3秒～4秒・4秒～5秒の2回
        }
        if (time >= maxtime)// 5秒たったら弾が出てアニメーションストップ タイマー0
        {
            BallShot();
            animator.SetBool("enemyS_flag", false);
            time = 0;
            return;
        }



    }

    void BallShot()// キューブ(敵に)
    {
        // たまを生み出してる
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
    }
}