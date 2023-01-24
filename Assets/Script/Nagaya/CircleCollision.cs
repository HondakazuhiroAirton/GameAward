using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CircleCollision : MonoBehaviour
{
    public TextMeshPro counttext;
    public int EnemyCount=0;

    // Start is called before the first frame update
    void Start()
    {
        EnemyCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Cage"))
        {
            //Cage(壁)にぶつかったらCircle（プレイヤー）消える
            this.gameObject.SetActive(false);
            Invoke("GoToGameOver",1.0f);
        }
        
        if(other.gameObject.CompareTag("Triangle"))
        {
            EnemyCount += 1;
            counttext.text = string.Format("Count: 0", EnemyCount);
              if(EnemyCount>=5)
              {
                 Invoke("GotoNextStage",1.0f);
              }
          }

        

    }

    void GoToGameOver()
    {
        SceneManager.LoadScene("EndScene");
    }

    void GotoNextStage()
    {
        SceneManager.LoadScene("NextStage");
    }

    

}
