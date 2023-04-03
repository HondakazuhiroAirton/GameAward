using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppearanceNotice : MonoBehaviour
{
    Color color;

    // Start is called before the first frame update
    void Start()
    {
        color = gameObject.GetComponent<AppearanceNotice> ().color;
    }

    // Update is called once per frame
    void Update()
    {
        //mesh.material.color = mesh.material.color - new Color32(0, 0, 0, 1);
        color.a -= 0.1f;
        gameObject.GetComponent<AppearanceNotice>().color = color;
    }
}
