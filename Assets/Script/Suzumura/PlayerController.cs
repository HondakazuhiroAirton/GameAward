using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    float buoyancy;

    // Start is called before the first frame update
    void Start()
    {
        // Rigidbodyコンポーネントを取得
        rb = GetComponent<Rigidbody2D>();

        buoyancy = 200;
    }

    // Update is called once per frame
    void FixedUpdate()
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

        // Rigidbody2Dに力を加える
        rb.AddForce(force);

        // 画面外判定
    }
}
