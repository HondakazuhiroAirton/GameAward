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

    // 当たり判定の初期位置保存
    private Vector3 startPosition;
    // パーティクルのポジション保存
    private Vector3 beamParticlePosition;
    // 回転補正値
    private float AngleHosei = 90;
    // 現在の状態保存(大きくなる状態か/小さくなる状態か)
    private State collisionState;

    // Start is called before the first frame update
    void Start()
    {
        // ビームパーティクルのスクリプトを取得
        var beamParticleScript = BeamParticle.GetComponent<BeamParticleScript>();

        // ビームパーティクルからビームの進行方向をもらう
        ParticlemoveDir = beamParticleScript.moveDir;

        // ビームパーティクルからビームの回転方向ををもらう
        ParticleAngle = beamParticleScript.Angle;
        // 補正値を引く
        ParticleAngle = ParticleAngle - AngleHosei;

       // スピード値
        ParticleSpeed = beamParticleScript.Speed;

        // 初期位置取得
        startPosition = this.transform.position;

        // 最初は拡大状態
        collisionState = State.SCALE_UP;

        Debug.Log(ParticlemoveDir);
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



        switch (collisionState)
        {
            case State.SCALE_UP:
                // 少しずつ大きくなる
                this.GetComponent<BoxCollider>().size += new Vector3(0.0f, ParticleSpeed, 0.0f);

                // 1.BoxColliderの位置決定
                // 毎フレームパーティクルの位置をもらう(この処理重いかも)
                beamParticlePosition = BeamParticle.transform.position;

                // 開始位置とビームの現在値を/2して移動量を出す
                collisionPosition = beamParticlePosition - startPosition;
                collisionPosition = collisionPosition / 2;
                break;

            case State.SCALE_DOWN:
                // 少しずつ小さくなる
                this.GetComponent<BoxCollider>().size -= new Vector3(0.0f, ParticleSpeed, 0.0f);

                // 開始位置とビームの現在値を/2して移動量を出す
                collisionPosition = beamParticlePosition - startPosition;
                collisionPosition = collisionPosition / 2;
                // 開始位置を引っ張る
                startPosition = startPosition + ParticlemoveDir;

                // 開始位置とビームのポジションが一緒になったら
                if (startPosition == beamParticlePosition)
                {
                    // このオブジェクトをデストロイする
                    Destroy(this.gameObject);
                }

                Debug.Log(ParticlemoveDir);

                break;
        }

        // スタートポジションに移動量を足してポジションを出す
        collisionPosition = startPosition + collisionPosition;
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
            collisionState = State.SCALE_DOWN;
            // ビームパーティクルからビームの進行方向をもらう
            ParticlemoveDir = BeamParticle.GetComponent<BeamParticleScript>().moveDir;
        }
    }

    // インターフェスが上手く使えてない
    public void CreateParticleEvent(GameObject obj,float angle)
    {
        Instantiate(this, this.transform.position,Quaternion.Euler(0.0f, 0.0f, angle - AngleHosei));
    }
}
