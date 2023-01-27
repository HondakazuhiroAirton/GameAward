using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CircleCollision : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int addText = 1;
    GameObject MainScene;
    GameObject SecondStage;
    GameObject ThirdStage;
    GameObject EndScene;

    public static List<string> GetActiceSceneNames()
    {
        int sceneCount = SceneManager.sceneCount;
        List<string> activeSceneNames = new List<string>();
        for (int i = 0; i < sceneCount; i++)
        {
            Scene scene = SceneManager.GetSceneAt(i);
            activeSceneNames.Add(scene.name);
        }
        return activeSceneNames;
    }

    // Start is called before the first frame update
    void Start()
    {

        addText = 0;

        Debug.Log(SceneManager.GetActiveScene().name);

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

    


           int sceneCount = SceneManager.sceneCount;
    
        if(other.gameObject.CompareTag("Triangle"))
        {
            addText+=1;

            switch (sceneCount)
            {
                case 1: //MainScene
                    if (addText >= 5 && SceneManager.GetActiveScene().name == "MainScene")
                    {
                        SceneManager.LoadScene("SecondStage");
                    }
                    break;
                case 2: //SecondStage
                    if (addText >= 10 && SceneManager.GetActiveScene().name == "SecondStage")
                    {
                        SceneManager.LoadScene("ThirdStage");
                    }
                    break;
                case 3: //ThirdStage
                    if (addText >= 15 && SceneManager.GetActiveScene().name == "ThirdStage")
                    {
                        SceneManager.LoadScene("EndScene");
                    }
                    break;
            }

        }
       
    
    


    }

    void GoToGameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }

    
    

}
