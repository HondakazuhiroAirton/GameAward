using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCastScript : MonoBehaviour
{
    // 列挙体状態制御
    public enum State
    {
        SCALE_UP = 0,
        SCALE_UPandDOWN,
        SCALE_STAY,
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

    // ビームの最長
    public float BeamMax;

    // パーティクルの移動ベクトル取得
    public Vector3 ParticleVector;

    // パーティクルの移動量(Vector x Speed)を取得
    public Vector3 moveDir;

    // 現在の状態保存(大きくなる状態か/小さくなる状態か)
    public State NowState;

    // 何番目の子供か
    public int ChildNo = 1;

    //  レイヤーマスク
    public LayerMask LayerMask;
    // privateゾーン*****************************************************
    // BoxCast情報を格納
    private RaycastHit[] hit;

    // BoxCastの大きさを入れる変数
    private float scale;

    // BoxCastのMaxの長さ
    private float maxDistance = 1.0f;

    // 何かオブジェクトにぶつかっているかどうか
    RaycastHit[] isHit;

    [SerializeField] // privateだけど表示
    bool isEnable = false; // ギズモに線を表示するかどうか

    void Start()
    {
        // 最初は拡大状態
        NowState = State.SCALE_UP;

        // (BeamParticleManager)親のオブジェクトを取得
        ParticleManager = transform.root.gameObject;
        // BeamParticleオブジェクトを取得Managerから見て1番上の子
        BeamParticle = ParticleManager.transform.GetChild(0).gameObject;

        // BeamParticleのスピードを取得する
        moveDir = BeamParticle.GetComponent<BeamParticleScript>().moveDir;

        // BeamParticleの長さを取得する
        BeamMax = BeamParticle.GetComponent<BeamParticleScript>().BeamMax;
    }

    void Update()
    {
        // BoxCast計算ゾーン*************************************************************************
        // 当たり判定の大きさ->箱の大きさの半分の引数を渡す必要があるため*0.5している
        scale = transform.lossyScale.x * 0.5f;
        Vector3 BoxCastPosition = this.transform.position;

        switch (NowState)
        {
            // 拡大状態の時
            case State.SCALE_UP:

                // 拡大状態の時はBeamParticleのポジションを取得する
                ParticlePosition = BeamParticle.transform.position;
                
                // ベクトルを計算する
                ParticleVector = ParticlePosition - BoxCastPosition;

                // 単位ベクトルにする
                ParticleVector = ParticleVector.normalized;

                // ビームの長さが一定以上になったら
                if (Vector3.Distance(ParticlePosition, transform.position) >= BeamMax)
                {
                    // 伸び縮みのStateに変更する
                    NowState = State.SCALE_UPandDOWN;
                }


                break;

            // 伸びながら縮む時
            case State.SCALE_UPandDOWN:

                // 縮小
                transform.position += moveDir;

                // 拡大状態の時はBeamParticleのポジションを取得する
                ParticlePosition = BeamParticle.transform.position;

                // ベクトルを計算する
                ParticleVector = ParticlePosition - BoxCastPosition;

                // 単位ベクトルにする
                ParticleVector = ParticleVector.normalized;


                break;



            // 状態維持の時
            case State.SCALE_STAY:

                // 常に前の当たり判定のチェックボックスを見てる
                GameObject BeforeChild = ParticleManager.transform.GetChild(ChildNo - 1).gameObject;
                
                // 前当たり判定のチェックボックスを見る
                if (BeforeChild.activeSelf == false || ChildNo == 1) // 前のチェックが消えたら自分をScale_Downに変更
                {
                    NowState = State.SCALE_DOWN;
                    Debug.Log(ChildNo+"は縮小を開始します");
                }
                
                break;

            // 縮小状態の時
            case State.SCALE_DOWN:

                // だんだん縮小
                transform.position += moveDir;


                // 長さがちいさくなったら自分のチェックボックスを消す
                if (Vector3.Distance(ParticlePosition, transform.position) <= 1.0f)
                {
                    Debug.Log("判定消えます");
                    // このオブジェクトを非アクティプにする
                    this.gameObject.SetActive(false);
                }

                break;

                

        }


        // 2点間の距離を求める
        maxDistance = Mathf.Pow((ParticlePosition.x - BoxCastPosition.x), 2.0f) +
                       Mathf.Pow((ParticlePosition.y - BoxCastPosition.y), 2.0f) +
                        Mathf.Pow((ParticlePosition.z - BoxCastPosition.z), 2.0f);

        // これをルートにする
        maxDistance = Mathf.Sqrt(maxDistance);

        // BoxCastを飛ばす 　　　　場所                  大きさ             方向(ベクトル)              回転方向?  
        isHit = Physics.BoxCastAll(transform.position, Vector3.one * scale, ParticleVector, Quaternion.identity, maxDistance,LayerMask);
        //                                                                                ↑あたったオブジェクトをここに格納  

        // BoxCastにあたったオブジェクトの処理
        foreach(var obj in isHit)
        {
            GameObject hitObject = obj.collider.gameObject;
            Debug.Log("あたったよ");
            // インターフェスで渡して
            hitObject.GetComponent<CollisionAction>().CollisionEvent(this.gameObject);
            
        }


    }

    void OnDrawGizmos()
    {
        // 可視化するかどうか
        if (isEnable == false)return;

        // 当たるまで線を描いて
        Gizmos.DrawRay(transform.position, ParticleVector * maxDistance);
        // ぶつかったところにBoxを同じ大きさで描く
        Gizmos.DrawWireCube(transform.position + ParticleVector * maxDistance, Vector3.one * scale * 2);

    }

    //public void CollisionEvent(GameObject obj)
    //{
    //    throw new System.NotImplementedException();
    //}
}


/*
 
(パーティクル設計図)     
     
     BeamParticleManager
      |__BeamParticle(反射するたびにEndPosを渡して次のやつ作る)
          |__BeamBoxCast1
          |__BeamBoxCast2...(反射のたびにプレハブから複製)
     
     
     
     
     
*/
