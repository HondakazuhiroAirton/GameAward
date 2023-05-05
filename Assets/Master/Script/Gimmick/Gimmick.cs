using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gimmick : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Beamline CollisionEvent()
    {
        Beamline beamline = new Beamline();
        //beamline.startPos = 0;


        return beamline;
    }

    public Beamline CollisionEvent(Beamline beamline)
    {
        Beamline newBeamline = new Beamline();


        //newBeamline.startPos = beamline
        //Vector3 moveDir = obj.GetComponent<BeamParticleScript>().moveDir; // 移動方向ベクトル

        //Vector3 StartPosition = obj.GetComponent<BeamParticleScript>().StartPosition;
        //// パーティクルと平面の距離(入射ベクトルを求める)
        //Vector3 inDirection = obj.transform.position - StartPosition;
        //// 単位ベクトル化
        //inDirection = inDirection.normalized;

        //// 法線ベクトル (取得が難しい。がんばる!!)
        //Vector3 inNormal = transform.up.normalized;




        //// 反射ベクトル
        //Vector3 result = Vector3.Reflect(inDirection, inNormal);

        //// 反射ベクトルを移動量としてビームパーティクルにわたす
        //obj.GetComponent<BeamParticleScript>().moveDir = result * obj.GetComponent<BeamParticleScript>().Speed;

        //// ビームパーティクルのスタートポジションを更新する
        //obj.GetComponent<BeamParticleScript>().StartPosition = obj.transform.position;

        //// 反射アングルを更新する(ベクトルから角度を求める) <- ラジアン値だった。
        //float Angle = Mathf.Atan2(result.y, result.x);

        //// ラジアン値をディグリー値に変換
        //Angle = Angle * Mathf.Rad2Deg;

        //// ビームパーティクルのアングルを更新する
        //obj.GetComponent<BeamParticleScript>().Angle = Angle;


        return newBeamline;
    }
}
