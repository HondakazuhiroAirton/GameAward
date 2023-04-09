using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBeamScript : MonoBehaviour
{
    // publicゾーン*****************************************************
    // 大きさ
    public float Scale;

    // 角度
    public float Angle;

    // 1フレームに伸びる量
    public float move = 2;

    // 大きくなるスピード
    public float Speed;

    // BoxCastの終点
    public Vector3 EndPosition;

    // BoxCastの最大距離
    public float MaxDistance = 50;

    // ビームが進む方向ベクトル
    public Vector3 Direction;

    // privateゾーン*****************************************************

    // プレイヤーオブジェクト保存
    public GameObject player;

    // BoxCast情報を格納
    private RaycastHit hit;

    // BoxCastのMaxの長さ
    private float maxDistance;

    // 何かオブジェクトにぶつかっているかどうか
    bool isHit;

    [SerializeField] 
    bool isEnable = false; // ギズモに線を表示するかどうか

    void Start()
    {
        // プレイヤーの情報取得プレイヤーは親としてInstantinateする
        player = transform.root.gameObject;
        // 初期位置に移動
        this.transform.position = player.transform.position;
        // プレイヤーの向きによってビームの角度変更
        this.transform.localRotation = Quaternion.Euler(0.0f,0.0f,player.transform.localRotation.z);
        Direction = player.transform.up;
        Direction = Direction.normalized;
        // 各種変数初期化
        EndPosition = this.transform.position;



    }

    void Update()
    {
        Direction = player.transform.up;
        Direction = Direction.normalized;
        // 毎フレームプレイヤーのポジションに移動して常にプレイヤーから発射されるようにする
        this.transform.position = player.transform.position;

        // BoxCast計算ゾーン*************************************************************************
        // 当たり判定の大きさ->箱の大きさの半分の引数を渡す必要があるため*0.5している
        Scale = transform.lossyScale.x * 0.5f;
        Vector3 BoxCastPosition = this.transform.position;



        
        // ビームの長さが一定以上になったら
        if (Vector3.Distance(EndPosition, transform.position) >= MaxDistance)
        {
            // 何もしない
        }
        else
        {
            // 伸びを少しずつ大きくする
            EndPosition.x = EndPosition.x + move;
        }

        // プレイヤーを参照して角度と伸びを決める

        // 2点間の距離を求める
        maxDistance = Mathf.Pow((EndPosition.x - BoxCastPosition.x), 2.0f) +
                       Mathf.Pow((EndPosition.y - BoxCastPosition.y), 2.0f) +
                        Mathf.Pow((EndPosition.z - BoxCastPosition.z), 2.0f);

        // これをルートにする
        maxDistance = Mathf.Sqrt(maxDistance);

        // BoxCastを飛ばす 　　　　場所                  大きさ             方向(ベクトル)              回転方向?  
        isHit = Physics.BoxCast(transform.position, Vector3.one * Scale, Direction, out hit, Quaternion.identity, maxDistance);
        //                                                                                ↑あたったオブジェクトをここに格納  

        // BoxCastにあたったオブジェクトの処理
        if (isHit == true)
        {
            GameObject hitObject = hit.collider.gameObject;

            // 多分この処理はインターフェスで渡してEnemy側で作った方がいい
            Destroy(hitObject);

        }
    }

    // ギズモでボックスキャスト見た目を表示
    void OnDrawGizmos()
    {
        // 可視化するかどうか
        if (isEnable == false) return;

        // 当たるまで線を描いて
        Gizmos.DrawRay(transform.position, Direction * maxDistance);
        // ぶつかったところにBoxを同じ大きさで描く
        Gizmos.DrawWireCube(transform.position + Direction * maxDistance, Vector3.one * Scale * 2);

    }
}
