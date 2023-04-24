using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    // �L���[�u(�G��)
    [SerializeField] GameObject ball;
    [SerializeField] GameObject player;
    // �e��
    public float ballSpeed = 10.0f;
    public float time = 5.0f;

    void Update()
    {
        transform.LookAt(player.transform);// �L���[�u(�G��)

        time -= Time.deltaTime;// �e��
        if (time <= 0)
        {
            BallShot();
            time = 5.0f;
        }
    }

    void BallShot()// �L���[�u(�G��)
    {
        GameObject shotObj = Instantiate(ball, transform.position, Quaternion.identity);
        shotObj.GetComponent<Rigidbody>().velocity = transform.forward * ballSpeed;
    }

}