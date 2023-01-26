using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CircleCollision : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int addText = 1;
    

    // Start is called before the first frame update
    void Start()
    {

        addText = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //変数addTextを文字列に変換し、text.textに代入＝表示する文章を変更
       text.text = addText.ToString();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Cage"))
        {
            //Cage(壁)にぶつかったらCircle（プレイヤー）消える
            this.gameObject.SetActive(false);
            Invoke("GoToGameOver", 1.0f);
        }

        if(other.gameObject.CompareTag("Triangle"))
        {//
            addText = addText + 1;
            if (addText == 5)
            {
                SceneManager.LoadScene("SecondStage");   //５回当たったらクリア
            }

        }




    }

    void GoToGameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }






}
