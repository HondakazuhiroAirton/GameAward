using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BeamCollision : MonoBehaviour
{

    // 状態を表す列挙体
    public enum State
    {
        SCALE_UP = 0,
        SCALE_DOWN,

        SCALE_STATE_MAX
    }

    // ビームパーティクルオブジェクト
    public GameObject BeamParticle;
    // ビームが進む方向
    public Vector3 ParticlemoveDir;
    // ビームの回転角
    public float ParticleAngle;
    // ビームの移動スピード
    public float ParticleSpeed = 0.1f;
    // 現在の状態保存(大きくなる状態か/小さくなる状態か)
    public State CollisionState;

    // BeamParticleスクリプトの保存
    BeamParticleScript beamParticleScript;

    // 当たり判定の初期位置保存
    private Vector3 startPosition;
    // パーティクルのポジション保存
    private Vector3 beamParticlePosition;
    // 回転補正値
    private float AngleHosei = 90;


    // Start is called before the first frame update
    public void Start()
    {
        // ビームパーティクルのスクリプトを取得
        beamParticleScript = BeamParticle.GetComponent<BeamParticleScript>();

        // ビームパーティクルからビームの進行方向をもらう
        ParticlemoveDir = beamParticleScript.moveDir;

        // ビームパーティクルからビームの回転方向ををもらう
        ParticleAngle = beamParticleScript.Angle;

        // もらった値(ラジアン値)をディグリー値に変更
        ParticleAngle = ParticleAngle * Mathf.Rad2Deg;

        // 補正値を引く
        ParticleAngle = ParticleAngle - AngleHosei;

        // スピード値
        ParticleSpeed = beamParticleScript.Speed;

        // 初期位置取得
        startPosition = this.transform.position;

        // 最初は拡大状態
        CollisionState = State.SCALE_UP;

        // BeamParticleScriptの補正値を合わせる
        BeamParticle.GetComponent<BeamParticleScript>().AngleHosei = AngleHosei;
    }

    // Update is called once per frame
    void Update()
    {
        // 当たり判定の位置を計算するための変数
        Vector3 collisionPosition = new Vector3(0, 0, 0);
        // 補正値決定
        float xSize = this.GetComponent<BoxCollider>().size.x;
        float ySize = this.GetComponent<BoxCollider>().size.y;
        float zSize = this.GetComponent<BoxCollider>().size.z;



        switch (CollisionState)
        {
            case State.SCALE_UP:
                // 少しずつ大きくなる
                this.GetComponent<BoxCollider>().size += new Vector3(0.0f, ParticleSpeed, 0.0f);

                // 1.BoxColliderの位置決定
                // 毎フレームパーティクルの位置をもらう(この処理重いかも)
                beamParticlePosition = BeamParticle.transform.position;

                // 開始位置とビームの現在値を/2して移動量を出す
                collisionPosition = beamParticlePosition + startPosition;
                collisionPosition = collisionPosition / 2;
                break;

            case State.SCALE_DOWN:
                // 少しずつ小さくなる
                this.GetComponent<BoxCollider>().size -= new Vector3(0.0f, ParticleSpeed, 0.0f);

                // 開始位置とビームの現在値を/2して移動量を出す
                collisionPosition = beamParticlePosition + startPosition;
                collisionPosition = collisionPosition / 2;
                // 開始位置を引っ張る
                startPosition = startPosition + ParticlemoveDir;

                // 開始位置とビームのポジションが一緒になったら
                if (Vector3.Distance(startPosition, collisionPosition) <= 1.0f)
                {
                    Debug.Log("判定消えます");
                    // このオブジェクトをデストロイする
                    //Destroy(this.gameObject);
                }

                break;
        }

        // 位置を反映
        this.transform.position = collisionPosition;

        // 回転を反映
        this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, ParticleAngle);
    }

    private void OnTriggerEnter(Collider other)
    {
        // 反射物にあたった場合
        if (other.gameObject.tag == "Reflector")
        {
            Debug.Log("縮むよ");
            // 縮む状態にする
            CollisionState = State.SCALE_DOWN;
            // ビームパーティクルからビームの進行方向をもらう
            //ParticlemoveDir = BeamParticle.GetComponent<BeamParticleScript>().moveDir;
        }

    }

}