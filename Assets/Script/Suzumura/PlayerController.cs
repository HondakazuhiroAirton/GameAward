using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    float buoyancy;

    readonly float clampMinX = -1.0f;
    readonly float clampMaxX = 1.0f;
    readonly float clampMinY = -200.0f;
    readonly float clampMaxY = 200.0f;

    Vector2 PlayerPos;
    Vector2 ViewportLB;     // 左下
    Vector2 ViewportRT;     // 右上

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
        // 入力をxに代入
        float x = Input.GetAxis("Horizontal");

        //x軸に加わる力を格納
        Vector2 force = new Vector2(x * 10, 0);

        // ジャンプ入力
        if (Input.GetKeyDown("space"))
        {
            force = new Vector2(x * 10, buoyancy);
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

        // 移動速度の制限
        force.x = Mathf.Clamp(force.x, clampMinX, clampMaxX);
        force.y = Mathf.Clamp(force.y, clampMinY, clampMaxY);

        // Rigidbody2Dに力を加える
        rb.AddForce(force);
    }
}
