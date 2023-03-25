using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpPointPS : MonoBehaviour
{
    public Vector3 pos;
    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.tag == "Warp")
        {
            other.gameObject.transform.position = new Vector3(pos.x, pos.y, pos.z);
        }
    }
}
