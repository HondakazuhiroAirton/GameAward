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
    public GameObject Enemycount;

    private float _countdown=5.0f;    //繰り返す間隔
    private float _timeElapsed;   //経過時間



    float seconds;

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


        GameObject Enemycount = GameObject.Find("EnemyCount");

        _countdown = 5;    //実行間隔を５に設定
        


        //    TextMeshProUGUI.enemycount = Enemycount.GetComponent<TextMeshProUGUI>();
        enemycount.enabled=false;

    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
    

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit"); // ログを表示する


        // もし衝突した相手オブジェクトの名前が"プレイヤービーム"ならば
        if (collision.gameObject.name == "PlayerBeam")
       {
            enemycount.enabled = true;
            //beingMeasured = !beingMeasured;
            // 衝突した相手オブジェクトを削除する
            Destroy(Enemy);

            count++;
            enemycount.text = "Combo:" + count;

            //時間をカウントダウンする
            _timeElapsed -= Time.deltaTime;


            //countdownが0以下になったとき
            if (_timeElapsed <= 0)
            {
                Debug.Log("TimeOut"); // ログを表示する
                _timeElapsed = 0;   //経過時間をリセットする
                enemycount.enabled = false;
            }
            else if(collision.gameObject.name == "PlayerBeam")
            {
                Destroy(Enemy);

                count++;
                enemycount.text = "Combo:" + count;
                
            }


            
           
         
            
            
            

        }
    }
    
}
