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
    public GameObject playerbeam;

    int enemyCount;

//   private bool beingMeasured; // 計測中であることを表す変数
//   private float limit;

    // Start is called before the first frame update
    void Start()
    {
//      beingMeasured = false;
//      limit = 5.0f;

        Enemy = GameObject.Find("Enemy");
        playerbeam = GameObject.Find("PlayerBeam");
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        enemycount.text = enemycount.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }



    void onButtonCount()
    {
        
        count++;
        enemycount.text = "Enemy:" + count;
    }

    

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit"); // ログを表示する
        // もし衝突した相手オブジェクトの名前が"プレイヤービーム"ならば
       if (collision.gameObject.name == "PlayerBeam")
       {
//            beingMeasured = !beingMeasured;
           // 衝突した相手オブジェクトを削除する
           Destroy(Enemy);
           onButtonCount();
            

       }
    }
    
}
