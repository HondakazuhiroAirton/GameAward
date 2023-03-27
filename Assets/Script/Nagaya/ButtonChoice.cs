using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonChoice : MonoBehaviour
{
    Button resume;
    Button restart;
    Button stageselect;

    void Start()
    {
        resume = GameObject.Find("Canvas/Panel").GetComponent<Button>();
        restart = GameObject.Find("Canvas/Panel").GetComponent<Button>();
        stageselect = GameObject.Find("Canvas/Panel").GetComponent<Button>();


        //ƒ{ƒ^ƒ“‚ª‘I‘ğ‚³‚ê‚½ó‘Ô‚É‚È‚é
        resume.Select();
    }
}
