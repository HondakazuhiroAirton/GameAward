using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam_SC : MonoBehaviour
{
    CapsuleCollider2D capsuleCollider;

    
    void Start()
    {
       
        capsuleCollider = GetComponent<CapsuleCollider2D>();
    }


    void Update()
    {
        transform.position += transform.up * Time.deltaTime * 5;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<CollisionAction>();
    }
}
