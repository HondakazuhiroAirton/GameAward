// とりあえず作ったパターン１
// プレイヤーのことを考えず、自由に動く敵

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // グローバル変数みたいにフィールドを使います
    public int State = 1; // エネミーの状態を入れる変数。初期値は敵として襲いかかってくる状態
    //public float MoveTime = 10f;  // 行動が変わる時間
    //float time = 0f;
    //float movex = 1.0f;   // 移動量
    //float movey = 5.0f;   // 移動量 上にいっかいパタッとしたときに動く量
    //int StartCount; // 最初にパタパタする回数
    //float StartPataPataTime = 1.0f; // 最初にパタパタする時間間隔
    //Vector3 MoveValue;


    static GameObject Player;
    Vector2 PlayerPos;
    Vector2 EnemyPos;
    Rigidbody2D rb;
    float valuex;
    float valuey;
    float clampMin;
    float clampMax;
    // プレイヤーのオブジェクトを取得


    void Start()
    {
        //time = 0f;
        //StartCount = 0;
        State = 0;
 
        Player = GameObject.Find("Player");
        PlayerPos = Player.transform.position ;
        rb = this.GetComponent<Rigidbody2D>();  // rigidbodyを取得
        clampMin = -50;
        clampMax = 50;
    }

    void Update()
    {

        //if (State == 0) // 最初0
        //{
        //    if (StartPataPataTime < time)
        //    {
        //        time = 0f;
        //        MoveValue.y = movey * Time.deltaTime;
        //        StartCount++;
        //    }


        //    if (StartCount > 5) // 5回パタパタしたら
        //    {
        //        State = 1; // 次の状態へ
        //    }

        //}
        //else 
        if (State == 1)// 0:敵として襲いかかってくる状態
        {
            // 敵と自分の位置を比較
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

            // Playerの当たり判定を検知したら、状態(State)を2(持ち運ばれ状態)に変更
            //if ()
            //{ 
            //    State == 2
            //}
        }
        else if (State == 2)// 2:運ばれている状態
        {
            // 運ばれている状態の動き




            // かごの当たり判定を検知したら、状態(State)を変更
            //if ()
            //{ 
            //    State == 3
            //}
        }
        else // かごに入れられて出れない状態を下に書いたら良さそう
        {


        }

        // 移動を反映する前にふわふわした慣性をつけるといいのかな？？


        // 画面外判定どうする？？

    }

    public void SetEnemyState(int StateID)
    {
        State = StateID;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("プレイヤーとあたったよ");
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
