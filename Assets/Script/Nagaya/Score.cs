using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    int score = 0;
    TextMeshProUGUI textComponent;

    // Start is called before the first frame update
    void Start()
    {
        this.textComponent = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
        this.textComponent.text = "Score: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("p"))
        {
            AddScore();
        }

    }

    public void AddScore()
    {
        this.score += 10;
        this.textComponent.text = "Score: " + score.ToString();
    }

    public int ResultScore()
    {
        score;
    }
}
