using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour,CollisionAction
{

    public void CollisionEvent(GameObject obj)
    {
        Vector3 moveDir = GetComponent<BeamParticleScript>().moveDir; ;          // 移動方向ベクトル

        Vector3 StartPosition = GetComponent<BeamParticleScript>().StartPosition;
        // パーティクルと平面の距離
        Vector3 d = StartPosition - this.transform.position;
        // 移動ベクトルと法線ベクトルの内積
        float h = Vector3.Dot(d, this.transform.up);




        // 反射ベクトルを計算する
        Vector3 n = this.transform.up; // 地面の法線ベクトルを入れる
        float Naseki = Mathf.Abs(Vector3.Dot(moveDir, n)); // 絶対値を取る,移動ベクトルと地面の法線ベクトルの内積を取る
        Vector3 r = moveDir + 2 * n * h; // 下に2倍伸ばす
        moveDir = r;
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
