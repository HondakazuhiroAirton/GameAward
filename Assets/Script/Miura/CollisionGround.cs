using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionGround : MonoBehaviour
{
    public bool GroundCollision; 
    void Start()
    {
        GroundCollision = false;
    }
    void Update()
    {
        GroundCollision = false;
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Groud")  // è∞Ç…Ç†ÇΩÇ¡ÇΩ
        {
            GroundCollision = true;
        }
    }

}
