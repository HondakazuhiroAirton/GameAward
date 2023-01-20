using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteor : MonoBehaviour
{
    //int frameCount = 0;
    //const int deleteFrame = 180;
    private float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ˆÊ’u‚ÌXV
        transform.Translate(Time.deltaTime * speed, 0,0);
        

        //if (++frameCount > deleteFrame)
        //{
        //    Destroy(gameObject);
        //}
    }
}
