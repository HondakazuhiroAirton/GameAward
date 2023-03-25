using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCastScript : MonoBehaviour
{
    // 列挙体状態制御
    public enum State
    {
        SCALE_UP = 0,
        SCALE_DOWN,

        SCALE_STATE_MAX
    }


    // publicゾーン*****************************************************
    // BeamParticleManager取得
    public GameObject ParticleManager;

    // BeamParticle取得
    public GameObject BeamParticle;

    // パーティクルの位置取得
    public Vector3 ParticlePosition;

    // パーティクルの移動ベクトル取得
    public Vector3 ParticleVector;

    // 現在の状態保存(大きくなる状態か/小さくなる状態か)
    public State NowState;

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
        // 最初は拡大状態
        NowState = State.SCALE_UP;

        // (BeamParticleManager)親のオブジェクトを取得
        ParticleManager = transform.root.gameObject;
        // BeamParticleオブジェクトを取得Managerから見て1番上の子
        BeamParticle = ParticleManager.transform.GetChild(0).gameObject;
    }

    void Update()
    {
        // BoxCast計算ゾーン*************************************************************************
        // 当たり判定の大きさ->箱の大きさの半分の引数を渡す必要があるため*0.5している
        scale = transform.lossyScale.x * 0.5f;


        switch (NowState)
        {
            // 拡大状態の時
            case State.SCALE_UP:

                // 拡大状態の時はBeamParticleのポジションを取得する
                ParticlePosition = BeamParticle.transform.position;
                
                // ベクトルを計算する
                ParticleVector = ParticlePosition - this.transform.position;

                // 単位ベクトルにする
                ParticleVector = ParticleVector.normalized;

               
                break;

            // 縮小状態の時
            case State.SCALE_DOWN:

                // 縮小状態の時はBeamParticleのポジションを貰わない(最後のポジションを参照する)

         
                
                // この辺でデリートしたいよねー


                break;

        }

        // BoxCastを飛ばす 　　　　場所                  大きさ             方向(ベクトル)              回転方向?  
        isHit = Physics.BoxCast(transform.position, Vector3.one * scale, ParticleVector, out hit);
        //                                                                                ↑あたったオブジェクトをここに格納  
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
