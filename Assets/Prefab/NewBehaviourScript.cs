using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{


    private GameObject obj;

    Rigidbody rb;



    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody>();
        rb = obj.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()//�������Ƃ��@�������Ƃ�
    {
      
    }


    private void FixedUpdate()//�������Z�@����������
    {
        
    }



}
