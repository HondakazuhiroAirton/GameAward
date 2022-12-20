using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hiscore : MonoBehaviour
{
    public TextMeshProUGUI HiScoreText;
    int hiscore;

    // Start is called before the first frame update
    void Start()
    {

        this.HiScoreText.text = "Hiscore" + 0.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
