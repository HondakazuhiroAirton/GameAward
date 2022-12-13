using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    void Start()
    {
        // 同一のGameObjectが持つRigidbodyコンポーネントを取得
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // 入力をxに代入
        float x = Input.GetAxis("Horizontal");


        //x軸に加わる力を格納
        Vector2 force = new Vector2(x * 10, 0);

        // Rigidbody2Dに力を加える
        rb.AddForce(force);
    }
}
