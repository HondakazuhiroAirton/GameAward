using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBeamScript : MonoBehaviour
{
    // BoxCast情報を格納
    private RaycastHit hit;

    // ビームの最長
    public float BeamMax;

    // 移動量
    public float Movement = 0.01f;

    //  レイヤーマスク(使わないかも)
    public LayerMask LayerMask;

    // privateゾーン*****************************************************
    // 何かオブジェクトにぶつかっているかどうか
    private bool isHit;

    // BoxCastの大きさを入れる変数
    private float scale;

    // BoxCastのMaxの長さ
    private float maxDistance = 1.0f;

    // 移動して伸びていく先のポジション
    private Vector3 MaxPosition;

    // 移動ベクトル
    private Vector3 moveVector;

    // 移動ベクトル
    private Vector3 moveDir = new Vector3(1.0f, 0.0f, 0.0f);

    [SerializeField] // privateだけど表示
    private bool isEnable = false; // ギズモに線を表示するかどうか


    void Start()
    {
        // 先を伸ばす
        moveDir = this.transform.up;
    }

    void Update()
    {
        // BoxCast計算ゾーン*************************************************************************
        // 当たり判定の大きさ->箱の大きさの半分の引数を渡す必要があるため*0.5している
        scale = transform.lossyScale.x * 0.5f;
        Vector3 BoxCastPosition = this.transform.position;

        // ベクトルを計算する
        maxDistance += Movement;

    }
    void OnDrawGizmos()
    {
        // 可視化するかどうか
        if (isEnable == false) return;

        // maxDistance分に線を描いて
        Gizmos.DrawRay(transform.position, moveDir * maxDistance);
        // ぶつかったところにBoxを同じ大きさで描く
        Gizmos.DrawWireCube(transform.position + moveDir * maxDistance, Vector3.one * scale * 2);

    }

}
