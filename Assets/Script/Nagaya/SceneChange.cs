using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange: MonoBehaviour
{
    public GameObject Image;

    // Start is called before the first frame update
    void Start()
    {
        Image = GameObject.Find("Image");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("return"))
        {
            Image.GetComponent<Fade>().GameStart();
        }

        if (Input.GetKey("b"))
        {
            Image.GetComponent<Fade>().GameSelect();
        }

        if(Input.GetKey("space"))
        {
            Image.GetComponent<Fade>().GameTitle();
        }
    }

     
}
