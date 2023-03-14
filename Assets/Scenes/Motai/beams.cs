using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beams : MonoBehaviour
{
    [SerializeField] GameObject particle;
    private Vector3 objPosition;
    private Quaternion objAng;
    private Quaternion psAng;
    public ParticleSystem ps;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            objPosition = this.gameObject.transform.position;
            objAng = this.gameObject.transform.rotation;
            psAng = particle.transform.rotation;

            Instantiate(particle,objPosition,objAng);   
        }
    }
}
