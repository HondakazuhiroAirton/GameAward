using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletplayer : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    public float ballSpeed = 10.0f;
    // 玉の移動方向
    public Vector3 moveVal;

    private float Wx;
    private float Wy;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.Find("koa");

        if (enemy != null)
        {
            // プレイヤーの場所取得
            Vector3 EnemyPos = enemy.transform.position;

            // ベクトル計算
            moveVal = EnemyPos - this.transform.position;

            // 正規化
            moveVal = moveVal.normalized;

            // 補正係数をかける
            moveVal.x *= ballSpeed;
            moveVal.y *= ballSpeed;
            moveVal.z *= ballSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // 玉を毎フレームを動かしてる
        transform.position += moveVal;

        Wx = Camera.main.WorldToViewportPoint(transform.position).x;
        Wy = Camera.main.WorldToViewportPoint(transform.position).y;

        if (0 >= Wx || Wx >= 1)
        {
            GameObject.Destroy(this.gameObject);
        }
        else if (0 >= Wy || Wy >= 1)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Destroy(this.gameObject);
    }
}
