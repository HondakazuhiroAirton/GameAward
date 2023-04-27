using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    // �L���[�u(�G��)
    [SerializeField] GameObject ball;
    [SerializeField] GameObject player;
    public const float maxtime = 5.0f;
    public float time;
    

    void Update()
    {
        time += Time.deltaTime;
        transform.LookAt(player.transform);// �L���[�u(�G��)]

        if(time >= maxtime)
        {
            BallShot();

            time = 0;
        }
    }

    void BallShot()// �L���[�u(�G��)
    {
        Instantiate(ball, transform.position, this.transform.rotation);
    }

}