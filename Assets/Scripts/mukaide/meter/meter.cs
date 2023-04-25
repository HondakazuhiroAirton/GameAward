using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meter : MonoBehaviour
{
    public GameObject hari;
    int add = -100;

    // Start is called before the first frame update
    void Start()
    {
        hari = GameObject.Find("Hari");
    }

    // Update is called once per frame
    void Update()
    {
        if (add <= 100 && add >= -100)
        {
            add++;
            hari.transform.eulerAngles = new Vector3(0, 0, add);
        }
    }
}
