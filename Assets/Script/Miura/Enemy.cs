// とりあえず作ったパターン１
// プレイヤーのことを考えず、自由に動く敵

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // グローバル変数みたいにフィールドを使います
    public int State = 1; // エネミーの状態を入れる変数。初期値は敵として襲いかかってくる状態
    public float MoveTime = 10f;  // 行動が変わる時間
    float time = 0f;
    float movex = 1.0f;   // 移動量
    float movey = 3.0f;   // 移動量 上にいっかいパタッとしたときに動く量
    int StartCount; // 最初にパタパタする回数
    float FallTime = 1.0f; // ゲーム開始してから落下する何もしない時間
    float StartPataPataTime = 0.6f; // 最初にパタパタする時間間隔
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

        // 使ってみたはいいが、使い方がわからない！！
        time += Time.deltaTime;
        if (State == 1) // 最初
        {
            if (FallTime < time)
            {
                time = 0f;
                State = 2;
            }
        }
        if (State == 2) // 最初
        {
            if (Input.GetKeyDown("space"))
            //if (StartPataPataTime < time)
            {
                //time = 0f;
                MoveValue.y = movey * Time.deltaTime;
                Debug.Log("ジャンプしたよ");
                //StartCount++;
            }

            //if (StartCount > 4) // 5回パタパタしたら
            //{
            //    State = 3; // 次の状態へ
            //}

        }
        else if (State == 3)// 1:敵として襲いかかってくる状態
        {
            // 襲いかかってくる動き,一定時間経過でPOS動かしたい。
            if (MoveTime < time)
            {
                time = 0f;
                MoveValue.y = movey * Time.deltaTime;
                movex *= -1;
            }

            MoveValue.x = movex * Time.deltaTime;


            // 地面と一定の距離検知したら、ジャンプする処理
            if (GroundCollision == true)// もし、Groundと当たったら
            {
                MoveValue.y = movey * Time.deltaTime;
                GroundCollision = false;
            }
        }

        // 移動を反映する前にふわふわした慣性をつけるといいのかな？？


        // 重力設定(当たり判定ワケワカランクなったので一旦コメントアウト)
        // MoveValue.y = MoveValue.y - movey / 5  * Time.deltaTime ;

        // 移動を反映
        transform.Translate(MoveValue);

        // 画面外判定どうする？？

    }

    public void SetJump() // GroundCollision君が当たり判定を検知したら教えてくれる
    {
        if (State == 3)
        {
            GroundCollision = true;

        }
    }
}


// 1.RigitBodyを外したときに地面との当たり判定なくなりました。
// 2.
// 
// 