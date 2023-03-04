using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamParticleScript : MonoBehaviour
{
    // 移動する方向
    public float XMove = 1;
    public float YMove = -1;
    public float ZMove = 0.0f;
    public float Speed = 0.1f; // 移動速度はここで変更してね

    // スタート位置保存
    public Vector3 StartPosition;
    public Vector3 moveDir;

    // Start is called before the first frame update
    void Start()
    {
        // 移動量を最初に代入
        moveDir = new Vector3(XMove, YMove, ZMove).normalized * Speed;

        // 開始時に初期位置を格納
        StartPosition = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // 移動
        transform.position += moveDir;

    }
    public void ParticleCollision()
    {


    }

    public void CollisionEvent(GameObject obj)
    {
        throw new System.NotImplementedException();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //collisionObject = collision.gameObject; // ぶつかったオブジェクトを取得

        //if (collisionObject.tag == "wall") // 衝突物が反射物だったら
        //{
        //    // 反射させる
        //    
        //    GameObject beamParticle = transform.parent.gameObject; // パーティクル1個のゲームオブジェクトを取得する
        //    //beamParticle.gameObject.ParticleCollision();
        //}
        Debug.Log("反射するよ");
        // なんやねんこれ
        collision.gameObject.GetComponent<CollisionAction>().CollisionEvent(this.gameObject);
    }
}

// 0301 三浦瞬
// このレーザーを途中で曲げる仕様に変更する場合、大改造が必要かも
// ①開始地点の場所を保存しておく
// ②当たり判定取った瞬間に開始地点->今の位置と壁の法線ベクトルで内積を取る
// ③開始地点更新
// ④反射カウント+1
// これでできそうじゃない??
// 当たるゲームオブジェクト全部格納??



// メモ
// 親子関係取得のアレコレ
//“transform.root.gameObject”は一番親のオブジェクトを取得
//“transform.parent.gameObject”は一つ上のオブジェクトを取得