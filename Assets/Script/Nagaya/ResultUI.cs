using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultUI : MonoBehaviour
{
    //クリア時に表示するUI
    [SerializeField]
    private GameObject resultUI;

    public GameObject Image;
    public GameObject Score;
    static int score;

    // Start is called before the first frame update
    void Start()
    {
        //Fadeの取得
        Image = GameObject.Find("Image");

        //スコアの取得
        Score = GameObject.Find("Score");
        score = Score.GetComponent<Score>().ResultScore();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("k"))
        {

            // パネルUIのアクティブ非アクティブを切り替え
            Active();

           

        }
        }

    public void Active()
    {
        //パネルUIのアクティブ、非アクティブを切り替え
        resultUI.SetActive(!resultUI.activeSelf);
    }
}
