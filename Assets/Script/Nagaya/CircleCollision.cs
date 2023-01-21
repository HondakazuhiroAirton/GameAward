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
         
        //変数addTextを1加算
        addText = addText + 1;


         //カゴにぶつかったら消える
         //          Destroy(this.gameObject);


             if (addText == 5)
             {
                 SceneManager.LoadScene("EndScene");   //５回当たったらクリア
             }
        }

       
    }
    


   

}
