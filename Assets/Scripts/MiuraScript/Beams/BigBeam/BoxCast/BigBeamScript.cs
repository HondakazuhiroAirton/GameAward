using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Effekseer;

public class BigBeamScript : MonoBehaviour
{    //  レイヤーマスク
    public LayerMask LayerMask;

    // 
    public float PlayerAngle;

    // ビームの時間
    public int StopTime = 270;

    // プレイヤーオブジェクト
    private PlayerMove_MIURA playerScript;
    // BoxCast情報を格納
    private RaycastHit[] hit;
    // BoxCastの大きさを入れる変数
    private float scale;
    // BoxCastのMaxの長さ
    public float maxDistance = 10.0f;
    // 何かオブジェクトにぶつかっているかどうか
    RaycastHit[] isHit;
    // ボックスキャストの方向ベクトル
    public Vector3 boxCastVecor;

    [SerializeField] bool isEnable = true; // ギズモに線を表示するかどうか

    // エフェクシア用関数アレコレ
    // 再生するアセット配列
    private EffekseerEffectAsset effect;
    // ハンドル
    private EffekseerHandle handle;
    // エフェクトの回転計算
    private Quaternion EffectRot;




    void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerMove_MIURA>();

        // 巨大ビームエフェクトを始める
        effect = Resources.Load<EffekseerEffectAsset>("BigBeam");
        handle = EffekseerSystem.PlayEffect(effect, transform.position);
        EffectRot = Quaternion.Euler(0.0f,0.0f,PlayerAngle);
        handle.SetRotation(EffectRot);
    }

    void Update()
    {
        // 大きさ調整
        scale = transform.lossyScale.x * 0.5f;

        // ビームエフェクトの時間が終わるまでBoxColliderを消しとく
        StopTime--;

        // ビームのエフェクトが終わったら
        if (StopTime < 0)
        {
            // BigBeamを消す
            Destroy(this.gameObject);
        }

        // BoxCastを飛ばす 　　　　場所                  大きさ             方向(ベクトル)              回転方向?  
        isHit = Physics.BoxCastAll(transform.position, Vector3.one * scale, boxCastVecor, Quaternion.identity, maxDistance, LayerMask);
        //                                                                                ↑あたったオブジェクトをここに格納  

        // BoxCastにあたったオブジェクトの処理
        foreach (var obj in isHit)
        {
            GameObject hitObject = obj.collider.gameObject;
            // インターフェスで渡して
            hitObject.GetComponent<CollisionAction>().CollisionEvent(this.gameObject);
        }
    }
    void OnDrawGizmos()
    {
        // 可視化するかどうか
        if (isEnable == false) return;

        // 当たるまで線を描いて
        Gizmos.DrawRay(transform.position, boxCastVecor * maxDistance);
        // ぶつかったところにBoxを同じ大きさで描く
        Gizmos.DrawWireCube(transform.position + boxCastVecor * maxDistance, Vector3.one * scale * 2);
    }
}
