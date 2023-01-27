using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    float buoyancy;             // 浮力
    float dash;                 // 速度
    float clampMinX = -5.0f;    // 下限
    float clampMaxX = 5.0f;     // 上限
    float clampMinY = -200.0f;
    float clampMaxY = 200.0f;

    Vector2 PlayerPos;      // プレイヤーの位置
    Vector2 EnemyPos;       // 敵の位置
    Vector2 ViewportLB;     // 画面の左下座標
    Vector2 ViewportRT;     // 右上の右上座標

    bool isGround = false;  // 接地判定
    bool dashflug = false;  // ダッシュフラグ
    int dashcount = 0;      // ダッシュカウント
    int cooltime = 0;       // クールタイム

    float PlayerandEnemyradius;
    // Start is called before the first frame update
    void Start()
    {
        // Rigidbodyコンポーネントを取得
        rb = GetComponent<Rigidbody2D>();

        // ビューポート取得
        ViewportLB = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        ViewportRT = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

    }

    // Update is called once per frame
    void Update()
    {
        buoyancy = 0.0f;
        dash = 10.0f;
        // ダッシュ
        // 条件: Bボタン　クールタイムなし　空中にいる
        if ((Input.GetKeyDown("b")) && (cooltime == 0) && (!isGround))
        {
            dashflug = true;
            dash = 1000.0f;
            clampMinX = -60.0f;     // 速度の上限解放
            clampMaxX = 60.0f;      // 速度の下限解放
            dashcount = 100;        // ダッシュ時間設定
            cooltime = 500;         // クールタイム設定
        }

        dashcount--;
        cooltime--;

        // 数フレーム後にダッシュ状態解除
        if (dashcount <= 0)
        {
            dashcount = 0;
            // 元に戻す
            dashflug = false;
            dash = 10.0f;
            clampMinX = -5.0f;
            clampMaxX = 5.0f;
        }

        // クールタイムが0以下にならないようにする
        if (cooltime <= 0)
        {
            cooltime = 0;
        }

        // 入力をxに代入
        float x = Input.GetAxis("Horizontal");

        // ジャンプ入力
        if (Input.GetKeyDown("space"))
        {
            buoyancy = 200;     // 浮力設定
        }

        //x軸に加わる力を格納
        Vector2 force = new Vector2(x * dash, buoyancy);

        // 画面外判定
        PlayerPos = this.transform.position;
        // 左端
        if (PlayerPos.x <= ViewportLB.x)
        {
            transform.position = new Vector2(ViewportRT.x, PlayerPos.y);       // 右側に移動
        }
        // 右端
        else if (PlayerPos.x >= ViewportRT.x)
        {
            transform.position = new Vector2(ViewportLB.x, PlayerPos.y);       // 左側に移動
        }

        // 上端
        if (PlayerPos.y >= ViewportRT.y)
        {
            transform.position = new Vector2(PlayerPos.x, ViewportRT.y);
            force.y = -30;
        }

        // Rigidbody2Dに力を加える
        rb.AddForce(force);

        // 移動速度の制限
        rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, clampMinX, clampMaxX), Mathf.Clamp(rb.velocity.y, clampMinY, clampMaxY));

    }

    //地面に触れているときに呼び出される関数
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGround = true;
        }
    }

    //地面から離れたときに呼び出される関数
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGround = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            PlayerandEnemyradius = collision.gameObject.transform.localScale.x / 2 + gameObject.transform.localScale.x / 2;
            Debug.Log("接敵");
            PlayerPos = this.transform.position;
            EnemyPos = collision.transform.position;
            Vector2 Compare = new Vector2(PlayerPos.x - EnemyPos.x, PlayerPos.y - EnemyPos.y);
            float slash = Compare.x * Compare.x + Compare.y * Compare.y;
            float sqrt = Mathf.Sqrt(slash);
            float diameter = PlayerandEnemyradius - sqrt;
            //Rigidbody2D enemyrb = collision.gameObject.GetComponent<Rigidbody2D>();
            //enemyrb.velocity = Vector3.zero;
            //Rigidbody2D playerrb = gameObject.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;

            if (Compare.x > 0)
            {
                rb.AddForce(new Vector2(1000f * diameter, 0f));
            }
            else if (Compare.x <= 0)
            {
                rb.AddForce(new Vector2(-1000f * diameter, 0f));
            }
        }



    }
    



}
