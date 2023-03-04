using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamParticleScript : MonoBehaviour
{
    public GameObject plane;
    Vector3 moveDir;           // 移動方向ベクトル
    // 移動する方向
    public float XMove = 1;
    public float YMove = -1;
    public float ZMove = 0.0f;
    public float Speed = 0.1f; // 移動速度はここで変更してね

    // スタート位置保存
    public Vector3 StartPosition;

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

         // パーティクルと平面の距離
         Vector3 d = transform.position - plane.transform.position;
        // 移動ベクトルと法線ベクトルの内積
         float h = Vector3.Dot(d, plane.transform.up);

    }
    public void ParticleCollision()
    {
        // 反射ベクトルを計算する
        Vector3 n = plane.transform.up; // 地面の法線ベクトルを入れる
        float h = Mathf.Abs(Vector3.Dot(moveDir, n)); // 絶対値を取る,移動ベクトルと地面の法線ベクトルの内積を取る
        Vector3 r = moveDir + 2 * n * h; // 下に2倍伸ばす
        moveDir = r;

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
