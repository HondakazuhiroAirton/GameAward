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
    Animator animatior;
    private int maxtime;
    private float mintime;
    public float time;

    GameObject PD;
    beamlife PlayerClasslife;
    private int life;

    void Start()
    {
        // animatorコンポーネントを取得
        animatior = GetComponent<Animator>();

        player = GameObject.Find("Player");
        Enemy = transform.parent.gameObject;
        EnemyManager = GameObject.Find("EnemyGroup(Clone)");

        PD = GameObject.Find("PD");
        PlayerClasslife = PD.GetComponent<beamlife>();
        life = PlayerClasslife.GetLife();


        maxtime = UnityEngine.Random.Range(5, 10);
        Debug.Log("maxtime >" + maxtime);
    }

    void Update()
    {
        if (life == 0) return;

        time += Time.deltaTime;
          
        if (time >= maxtime - 1)
        {
            animatior.SetBool("enemyS_flag", true);
        }
        if (time >= maxtime)// 5～10秒たったら弾が出てアニメーションストップ
        {
            animatior.SetBool("enemyS_flag", false);
            BallShot();
            time = 0;
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
        maxtime = UnityEngine.Random.Range(5, 10);
        Debug.Log("maxtime >" + maxtime);
    }
}