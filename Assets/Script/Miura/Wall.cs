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
        Vector3 AngleOfIncidence = StartPosition - this.transform.position;
        AngleOfIncidence = AngleOfIncidence.normalized;

        //if (AngleOfIncidence)
        //{

        //}


        // 入射ベクトルと法線ベクトルの内積
        float h = Vector3.Dot(AngleOfIncidence, this.transform.up);
        
        // 反射ベクトルを計算する
        Vector3 n = this.transform.up; // 地面の法線ベクトルを入れる
        float Naiseki = Mathf.Abs(Vector3.Dot(moveDir,n)); // 絶対値を取る,移動ベクトルと地面の法線ベクトルの内積を取る

        Vector3 r = moveDir + 2 * n * h; // 下に2倍伸ばす
        obj.GetComponent<BeamParticleScript>().moveDir = r.normalized * obj.GetComponent<BeamParticleScript>().Speed;
        obj.GetComponent<BeamParticleScript>().StartPosition = this.transform.position;

        // 反射制限のカウント増やす
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
