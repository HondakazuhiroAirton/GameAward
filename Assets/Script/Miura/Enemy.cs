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
    Vector2 Screen;
    Rigidbody2D rb;
    float valuex;
    float valuey;
    float clampMin;
    float clampMax;
    float PlayerandEnemyradius;

    Vector3 ViewportLeftBottom;
    Vector3 ViewportRightTop;
    // プレイヤーのオブジェクトを取得

    public GameObject ScoreObj;

    void Start()
    {
        //time = 0f;
        //StartCount = 0;
        State = 1;
 
        Player = GameObject.Find("Player");
        PlayerPos = Player.transform.position ;
        rb = this.GetComponent<Rigidbody2D>();  // rigidbodyを取得
        clampMin = -50;
        clampMax = 50;
    }

    void Update()
    {
        // 毎フレームenemyのポジションを取得
        EnemyPos = this.transform.position;

        if (State == 1) // 1:ひとりで自由に動いてる
        {
            rb.AddForce(new Vector2(-0.1f, 0.0f));

            //Debug.Log(rb.velocity);

            if (EnemyPos.y < 0.0)
            {
                rb.AddForce(new Vector2(0.0f, 50.0f));
            }

            rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, clampMin, clampMax),
                          Mathf.Clamp(rb.velocity.y, clampMin, clampMax));
           // Debug.Log(Mathf.Clamp(rb.velocity.x, clampMin, clampMax));
        }
        else if (State == 2)// 2:プレイヤーを発見して追いかける状態
        {
            // 敵と自分の位置を比較
           
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
                rb.AddForce(new Vector2(0, 50));
            }

            rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, clampMin, clampMax),
                                      Mathf.Clamp(rb.velocity.y, clampMin, clampMax));


        }
        else if (State == 3)// 3:運ばれている状態
        {


        }
       


        // 画面外判定

        // ビューポート取得（カメラの端っこをワールド座標に変換してる）
        ViewportLeftBottom =  Camera.main.ViewportToWorldPoint(new Vector3(0, 0));
        ViewportRightTop =  Camera.main.ViewportToWorldPoint(new Vector3(1, 1));

        // 左端超えたら
        if (ViewportLeftBottom.x > EnemyPos.x)
        { // 右端に戻す
            transform.position = new Vector2 (ViewportRightTop.x,EnemyPos.y);
        }
        // 右端超えたら
        else if (ViewportRightTop.x < EnemyPos.x)
        { // 左端に戻す
            transform.position = new Vector2(ViewportLeftBottom.x, EnemyPos.y);
        }

        // 上端超えたら
        if (ViewportRightTop.y <= EnemyPos.y)
        { // ずっと頭ぶつける
            transform.position = new Vector2(EnemyPos.x, ViewportRightTop.y);
        }
        

    }

    public void SetEnemyState(int StateID)
    {
        State = StateID;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerandEnemyradius = collision.gameObject.transform.localScale.x / 2 + gameObject.transform.localScale.x / 2;
            Debug.Log("プレイヤーとあたったよ");
            EnemyPos = this.transform.position;
            PlayerPos = Player.transform.position;
            Vector2 Compare = new Vector2(EnemyPos.x - PlayerPos.x, EnemyPos.y - PlayerPos.y);
            float slash = Compare.x * Compare.x + Compare.y * Compare.y;
            float sqrt = Mathf.Sqrt(slash);
            float diameter = PlayerandEnemyradius - sqrt;
            //Rigidbody2D playerrb = collision.gameObject.GetComponent<Rigidbody2D>();
            //playerrb.velocity = Vector3.zero;
            //Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;

            if (Compare.x > 0)
            {
                rb.AddForce(new Vector2(1000f * diameter, 0f));
            }
            else if (Compare.x <= 0)
            {
                rb.AddForce(new Vector2(-1000f * diameter, 0f));
            }

            ScoreObj.GetComponent<ScoreScript>().AddScore();
        }

    }
}
