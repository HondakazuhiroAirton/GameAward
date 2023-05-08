using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyCount : MonoBehaviour
{
    private int count;
    public TextMeshProUGUI enemycount;
    public GameObject Enemy;

   

    int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
       
        Enemy = GameObject.Find("Enemy");
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

    //    enemycount.text = enemycount.ToString();

    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.R))
        {
            onButtonCount();
        }
    }



    void onButtonCount()
    {
        count++;
        enemycount.text = "Enemy" + count;
    }


    
}
