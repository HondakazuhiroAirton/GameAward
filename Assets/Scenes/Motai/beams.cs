using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beams : MonoBehaviour
{
    //public ParticleSystem ps;
    //GameObject obj;
    //private Vector3 mousePosition;

    [SerializeField] GameObject particle;
    private Vector3 objPosition;
    


    // Start is called before the first frame update
    void Start()
    {
        //ps.Stop();
    }
    
    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.A))
        {
            //mousePosition = Input.mousePosition;
            //mousePosition.z = 3f;
            //Instantiate(ps, Camera.main.ScreenToWorldPoint(mousePosition), Quaternion.identity);
            //ps.Play();
        }*/
        if (Input.GetKey(KeyCode.A))
        {
            objPosition = this.gameObject.transform.position;
            Instantiate(particle,objPosition, Quaternion.identity);   
        }
    }
}
