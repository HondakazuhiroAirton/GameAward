using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionGround : MonoBehaviour
{
    public CollisionGround EnemyScript;

    void Start()
    {
    }
    void Update()
    {
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Groud")  // è∞Ç…Ç†ÇΩÇ¡ÇΩ
        {
            EnemyScript = GameObject.Find("Enemy");
            EnemyScript = sphereObject.GetComponent<SphereScript>();
            EnemyScript.GroundCollision = true;
        }
    }

}
