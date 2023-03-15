using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamCollision : MonoBehaviour
{
    // ビームが進む方向
    public Vector3 ParticlemoveDir;
    // ビームの回転角
    public float ParticleAngle;
    // ビームの移動スピード
    public float ParticleSpeed = 0.1f;

    // 初期位置保存
    protected Vector3 startPosition;
    // 回転補正値
    protected float AngleHosei = 90; 

    // Start is called before the first frame update
    void Start()
    {
        // ビームパーティクルからビームの進行方向をもらう
        ParticlemoveDir = transform.parent.GetComponent<BeamParticleScript>().moveDir;

        // ビームパーティクルからビームの回転方向ををもらう
        ParticleAngle = transform.parent.GetComponent<BeamParticleScript>().Angle;

        // スピード値
        //ParticleSpeed = 0.1f;

        // 初期位置もらってくる
        startPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<BoxCollider>().size += new Vector3 (0.0f,0.1f,0.0f);
        
        // 補正値決定
        float xSize = this.GetComponent<BoxCollider>().size.x;
        float ySize = this.GetComponent<BoxCollider>().size.y;
        float zSize = this.GetComponent<BoxCollider>().size.z;

        // BoxColliderサイズの半分分下に戻して補正
        this.transform.position = startPosition + new Vector3 (xSize / 2,ySize / 2 ,zSize / 2);

        // 回転を反映
        this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, ParticleAngle - AngleHosei);
    }
}
