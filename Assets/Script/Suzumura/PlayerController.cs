using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    float buoyancy;
    float clampMinX = -5.0f;
    float clampMaxX = 5.0f;
    float clampMinY = -200.0f;
    float clampMaxY = 200.0f;

    Vector2 PlayerPos;
    Vector2 ViewportLB;     // 左下
    Vector2 ViewportRT;     // 右上

    bool dashflug = false;
    int dashcount = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Rigidbodyコンポーネントを取得
        rb = GetComponent<Rigidbody2D>();

        buoyancy = 200;

        // ビューポート取得
        ViewportLB = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        ViewportRT = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

    }

    // Update is called once per frame
    void Update()
    {
        float dash = 10.0f;
        if (Input.GetKeyDown("b"))  // ダッシュ
        {
            dashflug = true;
            dash = 1000.0f;
            clampMinX = -60.0f;     // 速度の上限解放
            clampMaxX = 60.0f;      // 速度の下限解放
            dashcount = 100;
        }

        // 数フレーム後にダッシュ状態解除
        dashcount--;
        if (dashcount <= 0)
        {
            dashcount = 0;
            // 元に戻す
            dashflug = false;
            dash = 10.0f;
            clampMinX = -5.0f;
            clampMaxX = 5.0f;
        }

        // 入力をxに代入
        float x = Input.GetAxis("Horizontal");

        //x軸に加わる力を格納
        Vector2 force = new Vector2(x * dash, 0);

        // ジャンプ入力
        if (Input.GetKeyDown("space"))
        {
            force = new Vector2(x * dash, buoyancy);
        }

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
            transform.position = new Vector2(ViewportLB.x, PlayerPos.y);       // 右側に移動
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
        rb.velocity = new Vector3(Mathf.Clamp(rb.velocity.x, clampMinX, clampMaxX), Mathf.Clamp(rb.velocity.y, clampMinY, clampMaxY), 0);

    }
}
