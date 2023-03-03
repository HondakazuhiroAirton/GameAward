using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour
{
    public GameObject fade;

    // Start is called before the first frame update
    void Start()
    {
        fade = GameObject.Find("Panel");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            fade.GetComponent<Fade>().Color_FadeOut();
            Invoke("ChangeScene", 2.0f);
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("StageSelect");
    }
}
