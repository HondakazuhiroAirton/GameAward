using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beams : MonoBehaviour
{
    private float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 beamsPos = transform.position;



        if (Input.GetKey(KeyCode.A))
        {
            beamsPos.x += speed * Time.deltaTime;// x���W��speed�����Z
            
        }
        transform.position = beamsPos;//���݂̈ʒu���ɔ��f������
    }
}
