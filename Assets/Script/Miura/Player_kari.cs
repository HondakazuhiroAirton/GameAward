using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_kari : MonoBehaviour
{
    // プレイヤー移動用
    public Vector3 moveDir = new Vector3(0,0,0);


    // ビームに使用している変数達******************************************************************************
    // プレハブ格納用
    public GameObject BeamParticleManagerPrefab;
    // チャージした時間によってビームの大きさが変わるサイズ変更用の変数
    public float ParticleSize = 0.0f;
    // チャージした時間を格納する変数(必要)
    private float chargeTime = 0.0f;
    // ビームが1秒間に大きくなる基準
    public float BeamExpansion = 30.0f;
    // ビームに使用している変数達(ここまで)******************************************************************************


    // Start is called before the first frame update
    void Start()
    {
        chargeTime = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // ビーム発射処理*************************************************************
        if (Input.GetKeyDown(KeyCode.Space)) // キーコードは変更してね(*^^*)
        {
            chargeTime += BeamExpansion * Time.deltaTime ;

            // 最大値は多分こんな感じでつくる
            //if (chargeTime >= マックスサイズ)
            //{
            //    マックスサイズにする
            //}
            
        }
        if (Input.GetKeyUp(KeyCode.Space)) // Downと同じキーコードにしてね
        {
           
            // サイズを更新する
            ParticleSize = chargeTime; 

            // ビームマネージャーの中のBeamCollisionを取得
            BeamParticleManagerPrefab.gameObject.transform.GetChild(1).localScale 
                                                                    = new Vector3 (ParticleSize,1.0f,1.0f);
            // プレハブを指定位置に生成
            Instantiate(BeamParticleManagerPrefab, this.transform.position, gameObject.transform.localRotation);
            // チャージ時間を戻す
            chargeTime = 0.0f;
        }

        // ビーム発射処理(ここまで)*************************************************************



        // 移動処理(仮)*************************************************************
        if (Input.GetKey(KeyCode.D))
        {
            moveDir.x = 0.05f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            moveDir.x = -0.05f;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            moveDir.y = 0.05f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveDir.y = -0.05f;
        }
        else
        {
            moveDir = new Vector3(0, 0, 0);
        }

        transform.position += moveDir;

    // 移動処理(仮)終わり*************************************************************
    }
}
