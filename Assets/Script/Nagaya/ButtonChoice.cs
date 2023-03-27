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


        //ボタンが選択された状態になる
        resume.Select();
    }
}
