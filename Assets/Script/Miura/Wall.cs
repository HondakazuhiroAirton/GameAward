using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour,CollisionAction
{

    public void CollisionEvent(GameObject obj)
    {
        Vector3 moveDir = obj.GetComponent<BeamParticleScript>().moveDir; // 移動方向ベクトル

        Vector3 StartPosition = obj.GetComponent<BeamParticleScript>().StartPosition;
        // パーティクルと平面の距離(入射ベクトルを求める)
        Vector3 inDirection =  obj.transform.position - StartPosition;
        // 単位ベクトル化
        inDirection = inDirection.normalized;
    
        // 法線ベクトル ここをBB3Dとか使ったら行けそうか？？
        Vector3 inNormal = transform.up.normalized;




        // 反射ベクトル
        Vector3 result = Vector3.Reflect(inDirection, inNormal);

        // 反射ベクトルを移動量としてビームパーティクルにわたす
        obj.GetComponent<BeamParticleScript>().moveDir = result * obj.GetComponent<BeamParticleScript>().Speed;

        // ビームパーティクルのスタートポジションを更新する
        obj.GetComponent<BeamParticleScript>().StartPosition = obj.transform.position;


        // 昔考えたプログラム******************************
        //// 入射ベクトルと法線ベクトルの内積←法線ベクトルの取得がおかしいの？？？？
        //Vector3 n = this.transform.up.normalized; // 地面の法線ベクトルを入れる
        //float h = Vector3.Dot(AngleOfIncidence, n);
        //// 反射ベクトルを計算する
        //float Naiseki = Mathf.Abs(Vector3.Dot(moveDir,n)); // 絶対値を取る,移動ベクトルと地面の法線ベクトルの内積を取る
        //Vector3 r = moveDir + 2 * n * h; // 下に2倍伸ばす
        //obj.GetComponent<BeamParticleScript>().moveDir = r.normalized * obj.GetComponent<BeamParticleScript>().Speed;
        // ************************************************


    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
