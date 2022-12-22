using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    int Score = 0;
    public int highScore = 0; // �n�C�X�R�A��ێ�

    // Start is called before the first frame update
    void Start()
    {
        Score = PlayerPrefs.GetInt("Score",0);
        highScore = PlayerPrefs.GetInt("highScore", 0);
        this.ScoreText.text = "Score" + 0.ToString();
    }
    
    void OnDestroy()
    {
        // �X�R�A��ۑ�
        PlayerPrefs.SetInt("Score", Score);
        PlayerPrefs.Save();

        if (highScore < Score)
        {
            highScore = Score;
            // �X�R�A��ۑ�
            PlayerPrefs.SetInt("highScore", highScore);
            PlayerPrefs.Save();
        }
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score:" + Score.ToString();

        if (Input.GetKeyDown(KeyCode.P))
        {
            GameObject.Find("Canvas").GetComponent<ScoreScript>().AddScore();
        }

        //�X�R�A�ۑ��m�F�p
        if (Input.GetKeyDown(KeyCode.O))
        {
            Score = 0;
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            highScore = 0;
        }

    }

    public void AddScore()
    {
        this.Score += 10;
        this.ScoreText.text = "Score" + Score.ToString();
    }

    public int Hiscore()
    {
        return highScore;
    }
}