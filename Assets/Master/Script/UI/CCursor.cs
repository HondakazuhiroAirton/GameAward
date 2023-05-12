using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CCursor : MonoBehaviour
{

    Image _cursorIcon;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetPos(Vector3 pos)
    {
        transform.position = pos;
    }
}
