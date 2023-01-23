using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CircleCollision : MonoBehaviour
{
    public TextMeshProUGUI text;
    

    // Start is called before the first frame update
    void Start()
    {
        
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
    }
    
    void GoToGameOver()
    {
        SceneManager.LoadScene("EndScene");
    }

   

}
