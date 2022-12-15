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
    float movey = 5.0f;   // 移動量 上にいっかいパタッとしたときに動く量
    int StartCount; // 最初にパタパタする回数
    float StartPataPataTime = 1.0f; // 最初にパタパタする時間間隔
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

        // 使ってみたはいいが、使い方がわからない！！
        time += Time.deltaTime;

        if(State == 0) // 最初0
        {
            if (StartPataPataTime < time)
            {
                time = 0f;
                MoveValue.y = movey * Time.deltaTime;
                StartCount++;
            }


            if (StartCount > 5) // 5回パタパタしたら
            {
                State = 1; // 次の状態へ
            }

        }
        else if (State == 1)// 1:敵として襲いかかってくる状態
        {
            // 襲いかかってくる動き,一定時間経過でPOS動かしたい。
            if (MoveTime < time)
            {
                time = 0f;
                MoveValue.y = movey * Time.deltaTime;
                movex *= -1;
            }


            MoveValue.x = movex * Time.deltaTime;
            // この辺に地面と一定の距離検知したら、上に力を加える処理書いたら、落ちなそう

            if (CollisionGroundScript.GroundCollision == true)// もし、Groundと当たったら
            {
                MoveValue.y = movey * Time.deltaTime;
            }


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

        // 移動を反映
        transform.Translate(MoveValue);

        // 画面外判定どうする？？

    }
}
