using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour
{
    public GameObject CircleColl;
    int EnemyCount;

    // Start is called before the first frame update
    void Start()
    {
        
        EnemyCount = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            EnemyCount--;
        }

        Debug.Log(EnemyCount);

        if(EnemyCount==0 && SceneManager.GetActiveScene().name == "MainScene")
        {
            CircleColl.GetComponent<CircleCollision>().SceneChange();
        }
        else if(EnemyCount == 0 && SceneManager.GetActiveScene().name == "SecondStage")
        {
            CircleColl.GetComponent<CircleCollision>().SceneChange();
        }
        else if(EnemyCount == 0 && SceneManager.GetActiveScene().name == "ThirdStage")
        {
            CircleColl.GetComponent<CircleCollision>().SceneChange();
        }
    }
}
