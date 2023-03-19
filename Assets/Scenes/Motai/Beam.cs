using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    //private Vector3 objPosition;
    Rigidbody2D m_Rigidbody;
    float m_Speed;
    // Start is called before the first frame update
    void Start()
    {

        m_Rigidbody = GetComponent<Rigidbody2D>();

        m_Speed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //Move the Rigidbody to the right constantly at speed you define (the red arrow axis in Scene view)
            m_Rigidbody.velocity = transform.right * m_Speed;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //Move the Rigidbody to the left constantly at the speed you define (the red arrow axis in Scene view)
            m_Rigidbody.velocity = -transform.right * m_Speed;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //rotate the sprite about the Z axis in the positive direction
            transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * m_Speed, Space.World);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //rotate the sprite about the Z axis in the negative direction
            transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime * m_Speed, Space.World);
        }
    }
}
