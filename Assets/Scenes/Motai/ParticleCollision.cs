using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollision2 : MonoBehaviour
{
    //public Vector3 pos;
    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            GameObject obj = GameObject.FindGameObjectWithTag("Enemy");
            Destroy(obj);
        }
        if (other.gameObject.tag == "Warp")
        {
            other.gameObject.transform.position = new Vector3(-50f,-97f,10);
        }
    }
}