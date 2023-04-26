using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    // キューブ(敵に)
    [SerializeField] GameObject ball;
    [SerializeField] GameObject player;
    public const float maxtime = 5.0f;
    public float time;
    

    void Update()
    {
        time += Time.deltaTime;
        transform.LookAt(player.transform);// キューブ(敵に)]

        if(time >= maxtime)
        {
            BallShot();

            time = 0;
        }
    }

    void BallShot()// キューブ(敵に)
    {
        Instantiate(ball, transform.position, this.transform.rotation);
    }

}