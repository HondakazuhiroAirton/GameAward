using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    // キューブ(敵に)
    [SerializeField] GameObject ball;
    [SerializeField] GameObject player;
    // 弾に
    public float ballSpeed = 10.0f;
    public float time = 5.0f;

    void Update()
    {
        transform.LookAt(player.transform);// キューブ(敵に)

        time -= Time.deltaTime;// 弾に
        if (time <= 0)
        {
            BallShot();
            time = 5.0f;
        }
    }

    void BallShot()// キューブ(敵に)
    {
        GameObject shotObj = Instantiate(ball, transform.position, Quaternion.identity);
        shotObj.GetComponent<Rigidbody>().velocity = transform.forward * ballSpeed;
    }

}