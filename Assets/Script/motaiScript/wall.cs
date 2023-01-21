using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    public GameObject meteor;
    Vector3 createPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        createPosition = transform.position;
        createPosition.x += 1.0f;

        Instantiate(meteor, createPosition, Quaternion.identity);
    }
}
