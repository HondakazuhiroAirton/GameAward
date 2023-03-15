using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BeamParticleScript : MonoBehaviour
{
    // 移動する角度
    public float Angle = 0.0f; // 親の回転角度指定
    public float Speed = 0.1f; // 移動速度はここで変更してね
    // 反射回数
    public int ReflectMax = 1000; // 10000で反射制限なし
    //親のManagerを取得
    public GameObject ParticleManager;
    // スタート位置保存
    public Vector3 StartPosition;
    public Vector3 moveDir;

    // 今の反射回数
    protected int reflectCount = 0;
    // 移動する方向
    protected float XMove = 1.0f;
    protected float YMove = 0.0f;
    protected float ZMove = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
      // Angleから移動量を求める処理
        
        // Angle(度)をラジアンに変更
        Angle = Mathf.Deg2Rad * Angle;

        // XMoveとYMoveにCos/Sinで移動量を求める
        XMove = Mathf.Cos(Angle);
        YMove = Mathf.Sin(Angle);

        // 移動量を最初に代入
        moveDir = new Vector3(XMove, YMove, ZMove).normalized * Speed;

        // 開始時に初期位置を格納
        StartPosition = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // 移動
        transform.position += moveDir;

    }

    public void CollisionEvent(GameObject obj)
    {
        //throw new System.NotImplementedException();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (ReflectMax > reflectCount)
        {
            // 反射回数が設定されていれば1減らす
            if(ReflectMax < 1000)reflectCount--;

            // 以下、反射
            Debug.Log("反射するよ");
            collision.gameObject.GetComponent<CollisionAction>().CollisionEvent(this.gameObject);

        }
        //else
        //{
        //    // ここで反射回数が終わったら、Destroy的な処理
        //    // 考え中
        //}
    }
}

// 0301 三浦瞬
// このレーザーを途中で曲げる仕様に変更する場合、大改造が必要かも
// ①開始地点の場所を保存しておく
// ②当たり判定取った瞬間に開始地点->今の位置と壁の法線ベクトルで内積を取る
// ③開始地点更新
// ④反射カウント+1
// これでできそうじゃない??
// 当たるゲームオブジェクト全部格納??



// メモ
// 親子関係取得のアレコレ
//“transform.root.gameObject”は一番親のオブジェクトを取得
//“transform.parent.gameObject”は一つ上のオブジェクトを取得