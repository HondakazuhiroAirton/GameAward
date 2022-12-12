// とりあえず作ったパターン１
// プレイヤーのことを考えず、自由に動く敵

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // グローバル変数みたいにフィールドを使います
    public int State = 1; // エネミーの状態を入れる変数。初期値は敵として襲いかかってくる状態
    public float MoveTime = 1.5f;  // 行動が変わる時間
    float time = 0f;

    void Start()
    {
        time = 0f;
    }

    void Update()
    {
        // 現在のポジション取得
        Vector2 pos = transform.position;
        float movex = 0.001f;

        // 使ってみたはいいが、、、
        time += Time.deltaTime;

        if (State == 1)// 1:敵として襲いかかってくる状態
        {
            // 襲いかかってくる動き
            MoveTime -= 1;
            if(MoveTime < time)
            {
                time = 0f;
                movex *= -1;
            }

            pos.x -= movex;

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

        // 移動を反映
        transform.position = pos;

        // 画面外判定どうする？？

    }
}
