using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamCollision : MonoBehaviour
{
    // ビームパーティクルオブジェクト
    public GameObject BeamParticle;
    // ビームが進む方向
    public Vector3 ParticlemoveDir;
    // ビームの回転角
    public float ParticleAngle;
    // ビームの移動スピード
    public float ParticleSpeed = 0.1f;

    // 当たり判定の初期位置保存
    protected Vector3 startPosition;
    // パーティクルのポジション保存
    protected Vector3 beamParticlePosition;
    // 回転補正値
    protected float AngleHosei = 45; 

    // Start is called before the first frame update
    void Start()
    {
        // ビームパーティクルからビームの進行方向をもらう
        ParticlemoveDir = BeamParticle.GetComponent<BeamParticleScript>().moveDir;

        // ビームパーティクルからビームの回転方向ををもらう
        ParticleAngle = BeamParticle.GetComponent<BeamParticleScript>().Angle;

        // スピード値
        //ParticleSpeed = 0.1f;

        // 初期位置取得
        startPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // 少しずつ大きくなる
        this.GetComponent<BoxCollider>().size += new Vector3 (0.0f, ParticleSpeed, 0.0f);
        
        // 補正値決定
        float xSize = this.GetComponent<BoxCollider>().size.x;
        float ySize = this.GetComponent<BoxCollider>().size.y;
        float zSize = this.GetComponent<BoxCollider>().size.z;

        // 1.BoxColliderの位置決定
        // 毎フレームパーティクルの位置をもらう(この処理重いかも)
        beamParticlePosition = BeamParticle.transform.position;

        // 開始位置とビームの現在値を/2して移動量を出す
        Vector3 collisionPosition;
        collisionPosition = beamParticlePosition - startPosition;
        collisionPosition = collisionPosition / 2;
        Debug.Log("真ん中の値は" + collisionPosition + "ですにゃん。");

        // スタートポジションに移動量を足してポジションを出す
        collisionPosition = startPosition + collisionPosition;
        // 位置を反映(おかしい)
         this.transform.position = collisionPosition;

        // 回転を反映(おかしい)
        this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, ParticleAngle - AngleHosei);
    }
}
