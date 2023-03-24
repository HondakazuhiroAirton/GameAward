using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCast : MonoBehaviour
{
    // publicゾーン*****************************************************
    // BeamParticleManager取得
    public GameObject ParticleManager;
    // BeamParticle取得
    public GameObject BeamParticle;
    // パーティクルの位置取得
    public Vector3 ParticlePosition;
    // パーティクルの移動ベクトル取得
    public Vector3 ParticleVector;


    // privateゾーン*****************************************************

    // BoxCast情報を格納
    private RaycastHit hit;

    // BoxCastの大きさを入れる変数
    private float scale;

    // 何かオブジェクトにぶつかっているかどうか
    bool isHit;

    [SerializeField] // これよくわからん
    bool isEnable = false; // ギズモに線を表示するかどうか

    void Start()
    {
        // (BeamParticleManager)親のオブジェクトを取得
        ParticleManager = transform.root.gameObject;
        // BeamParticleオブジェクトを取得Managerから見て1番上の子
        BeamParticle = ParticleManager.transform.GetChild(0).gameObject;
    }

    void Update()
    {
        // BeamParticleのポジションを取得する
        ParticlePosition = BeamParticle.transform.position;
        ParticleVector = ParticlePosition - this.transform.position;
        // 単位ベクトルにする
        ParticleVector = ParticleVector.normalized;

        // BoxCast計算ゾーン*************************************************************************
        // 当たり判定の大きさ->箱の大きさの半分の引数を渡す必要があるため*0.5している
        scale = transform.lossyScale.x * 0.5f;

        // BoxCastを飛ばしてる　　　　場所                  大きさ             方向(ベクトル)              回転方向?  
        isHit = Physics.BoxCast(transform.position, Vector3.one * scale, ParticleVector, out hit);
        //                                                                                      ↑あたったオブジェクトをここに格納  

    }

    void OnDrawGizmos()
    {
        // 可視化するかどうか
        if (isEnable == false)return;

        // ヒットしている場合
        if (isHit == true)
        {
            // 当たるまで線を描いて
            Gizmos.DrawRay(transform.position, ParticleVector * hit.distance);
            // ぶつかったところにBoxを同じ大きさで描く
            Gizmos.DrawWireCube(transform.position + ParticleVector * hit.distance, Vector3.one * scale * 2);
        }
        else
        {
            // 線を伸ばし続ける
            Gizmos.DrawRay(transform.position, ParticleVector * 100);
        }
    }
}


/*
 
(パーティクル設計図)     
     
     BeamParticleManager
      |__BeamParticle(反射するたびにEndPosを渡して次のやつ作る)
          |__BeamBoxCast1
          |__BeamBoxCast2...(反射のたびにプレハブから複製)
     
     
     
     
     
*/
