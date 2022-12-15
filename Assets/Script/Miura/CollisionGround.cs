using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionGround : MonoBehaviour
{
    public Enemy EnemyScript;


    void Start()
    {
        EnemyScript = EnemyScript.GetComponent<Enemy>();
    }
    void Update()
    {
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Groud")  // 床にあたったら親EnemyのGroundCollision = trueにしてジャンプさせる
        {

            EnemyScript.SetJump();
        }
    }

}
