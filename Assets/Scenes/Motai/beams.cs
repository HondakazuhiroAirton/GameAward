using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beams : MonoBehaviour
{
    private Vector3 mousePosition;
    private Vector3 objPosition;
    [SerializeField] GameObject particle;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.A))
        //{
        //    obj.SetActive(true);
        //    ps.Play();
        //}
        if (Input.GetMouseButtonDown(0))
        {
            mousePosition = Input.mousePosition;
            mousePosition.z = 3f;
            objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Instantiate(particle, objPosition, Quaternion.identity);
        
            
        }
    }
}
