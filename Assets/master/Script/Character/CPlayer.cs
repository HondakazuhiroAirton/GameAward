using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayer : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(CameraManager.GetViewportRect().Left);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
