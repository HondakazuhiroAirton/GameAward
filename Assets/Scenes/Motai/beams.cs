using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beams : MonoBehaviour
{
    private float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 beamsPos = transform.position;
        Vector2 right = transform.right;

        if (Input.GetKey(KeyCode.A))
        {
            //beamsPos.x += speed * Time.deltaTime;// xç¿ïWÇ…speedÇâ¡éZ
            //beamsPos.x = transform.forward.x;

            //beamsPos.x += speed * Time.deltaTime;

            transform.position += transform.right;
        }
        
    }
}
