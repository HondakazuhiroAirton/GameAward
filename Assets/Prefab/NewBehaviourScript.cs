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
    void Update()//押したとき　離したとき
    {
      
    }


    private void FixedUpdate()//物理演算　押し続けた
    {
        
    }



}
