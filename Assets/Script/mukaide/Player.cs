using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform mytransform = this.transform;
        Vector2 pos = mytransform.position;
        pos.x -= 0.1f;
        mytransform.position = pos;
    }
}
