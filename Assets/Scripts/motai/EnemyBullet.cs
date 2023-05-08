using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    // キューブ(敵に)
    [SerializeField] GameObject ball;
    [SerializeField] GameObject player;
    Animator animator;
    public const float maxtime = 5.0f;
    public const float mintime = 2.0f;
    public float time;

    void Start()
    {
        // animatorコンポーネントを取得
        animator = GetComponent<Animator>();

        player = GameObject.Find("Player");
    }

        void Update()
    {
        
        time += Time.deltaTime;
        //if(player != null)
        //{
        //    transform.LookAt(player.transform);// キューブ(敵に)
        //    this.transform.rotation = Quaternion.Euler(0,0,this.transform.eulerAngles.z);
        //}

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
        Instantiate(ball, transform.position, this.transform.rotation);
        
    }
}