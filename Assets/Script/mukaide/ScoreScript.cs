using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    int Score = 0;
    public TextMeshProUGUI ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        this.ScoreText.text = "Score" + 0.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score:" + Score.ToString();

        if (Input.GetKeyDown(KeyCode.P))
        {
            GameObject.Find("Canvas").GetComponent<ScoreScript>().AddScore();
        }
    }

    public void AddScore()
    {
        this.Score += 10;
        this.ScoreText.text = "Score" + Score.ToString();
    }
}
