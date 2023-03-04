using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour
{
    public GameObject Panel;
    
   

    // Start is called before the first frame update
    void Start()
    {
    //    Fadeout = GameObject.Find("Panel");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
//          Invoke("ChangeScene", 2.0f);
            Panel.GetComponent<Fade>().SceneMove(0);
        }
    }

     public void ChangeScene()
     {
//         SceneManager.LoadScene(1);
     }
}
