using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Angle = this.transform.rotation.eulerAngles;
        Angle.x += 0.1f;
        //if (Angle.x >= 90) Angle.x = 0;
        this.transform.rotation = Quaternion.Euler(Angle);
        Debug.Log(Angle);
    }
}
