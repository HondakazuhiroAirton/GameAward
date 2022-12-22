using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hiscore : MonoBehaviour
{
    public TextMeshProUGUI HiScoreText;
    int hiscore;
    public GameObject hiscoreObj;
    ScoreScript scoreScript;
    // Start is called before the first frame update
    void Start()
    {
        scoreScript = hiscoreObj.GetComponent<ScoreScript>();

        this.HiScoreText.text = "Hiscore:" + 0.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        HiScoreText.text = "Hiscore:" + scoreScript.Hiscore().ToString();
    }

}
