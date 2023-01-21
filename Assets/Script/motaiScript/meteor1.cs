using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteor1 : MonoBehaviour
{
    //int frameCount = 0;
    //const int deleteFrame = 180;
    private float speed = -0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // à íuÇÃçXêV
        //transform.Translate(Time.deltaTime * speed, 0,0);
        transform.Translate(0,Time.deltaTime * speed,0);
    }

}
