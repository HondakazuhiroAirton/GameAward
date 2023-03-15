using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beams : MonoBehaviour
{
    [SerializeField] GameObject particle;
    private Vector3 objPosition;
    private Quaternion objAng;
    private Vector3 Position;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //Vector3 right = transform.right;
            //particle.transform.position += particle.transform.right;
            objPosition = this.gameObject.transform.position;
            objAng = this.gameObject.transform.rotation;

            Instantiate(particle,objPosition,objAng);   
        }
    }
}
