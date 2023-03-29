// ビームの先頭で動きを決めるスクリプト
// 角度操作はプレイヤー側でAngleを更新してください

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamParticleScript : MonoBehaviour
{
    //publicゾーン***********************************************************

    // ゲーム中の変数属性***********************
    // 移動する角度
    public float Angle = 0.0f; // 親の回転角度指定
    public float Speed = 0.1f; // 移動速度はここで変更してね

    // 反射回数
    public int ReflectMax = 1000; // 1000で反射制限なし

    // ParticleManager
    public GameObject ParticleManager;

    // 今のボックスキャスト(State変更時に使用)
    public GameObject NowBoxCast;

    // スタート位置保存
    public Vector3 StartPosition;

    // 移動量保存
    public Vector3 moveDir;

    // 角度の補正値(BeamCollisionのAngleHoseiをWall側から代入する)
    public float AngleHosei;

    // プレハブ属性*****************************
    // 反射用当たり判定プレハブ格納
    public GameObject BeamBoxCastReflect;

    // ビームの見た目パーティクル格納
    public GameObject BeamParticleSystemPrefab;

    // privateゾーン********************************************
    // 今の反射回数
    private int reflectCount = 0;

    // 反射の子供管理変数
    private int child = 0;

    // 移動する方向
    private float XMove = 1.0f;
    private float YMove = 0.0f;
    private float ZMove = 0.0f;

    // 当たり判定の拡大率を保存
    private float xCollisionSize = 1.0f;


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

        // ParticleManagerを取得
        ParticleManager = transform.root.gameObject;
        
    }

    void Update()
    {
        Instantiate(BeamParticleSystemPrefab, this.transform.position, Quaternion.identity/*, this.transform*/);
        // 移動処理
        transform.position += moveDir;
    }

    public void CollisionEvent(GameObject obj)
    {
        //throw new System.NotImplementedException();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Reflector") // 反射するオブジェクトにあたったら発動
        {
            if (ReflectMax > reflectCount)
            {
                // 反射回数が設定されていれば1減らす
                if (ReflectMax < 1000) reflectCount--;

                // 子供の変数を1進める
                child++;

                // 伸びてたBoxCastを縮小状態にする
                // BoxCastを取得
                NowBoxCast = ParticleManager.transform.GetChild(child).gameObject;

                // 大きさを記録しておく
                float BoxCastScale = NowBoxCast.transform.localScale.x;

                // BoxCastの状態を現状維持状態にする
                NowBoxCast.GetComponent<BoxCastScript>().NowState = BoxCastScript.State.SCALE_STAY;

                // Wallの反射アクションを起こす
                collision.gameObject.GetComponent<CollisionAction>().CollisionEvent(this.gameObject);

                // 前もってプレハブの大きさを変更しておく
                BeamBoxCastReflect.transform.localScale = new Vector3(BoxCastScale, BoxCastScale, BoxCastScale);

                // 次のプレハブのBoxCastのNoを設定する
                BeamBoxCastReflect.GetComponent<BoxCastScript>().ChildNo = child + 1;

                // つぎの反射の当たり判定を生み出す処理
                Instantiate(BeamBoxCastReflect, this.transform.position, Quaternion.identity, ParticleManager.transform);


            }
            else
            {
                // 反射回数がなくなったら、Destroyする
                Destroy(this.gameObject);
            }
        }
    }
}

// 0301 三浦瞬
// このレーザーを途中で曲げる仕様に変更する場合、大改造が必要かも
// �@開始地点の場所を保存しておく
// �A当たり判定取った瞬間に開始地点->今の位置と壁の法線ベクトルで内積を取る
// �B開始地点更新
// �C反射カウント+1
// これでできそうじゃない??
// 当たるゲームオブジェクト全部格納??



// メモ
// 親子関係取得のアレコレ
//“transform.root.gameObject”は一番親のオブジェクトを取得
//“transform.parent.gameObject”は一つ上のオブジェクトを取得


/*
// Boxを伸ばしていたときのスクリプト
     if (ReflectMax > reflectCount)
       {
           // 反射回数が設定されていれば1減らす
           if(ReflectMax < 1000)reflectCount--;

           //reflectCount++;

           // 以下、反射
           Debug.Log("反射するよ");
           // ※1 ここで先にAngleの反射更新がWall側から入る
           collision.gameObject.GetComponent<CollisionAction>().CollisionEvent(this.gameObject);

           // 反射の当たり判定を生み出す処理************************************************

           // 反射当たり判定の横幅を元のCollisionと同じにする
           BeamCollisionReflect.transform.localScale = new Vector3(xCollisionSize,1.0f,1.0f);

           // 角度を入れる(補正値はBeamCollision側から変更)
           // ※2 Wall側から変更された角度を使って新しい当たり判定を作る
           Instantiate(BeamCollisionReflect, this.transform.position, Quaternion.Euler(0.0f, 0.0f, Angle - AngleHosei), ParticleManager.transform);

       }
       else
       {
           // 反射回数がなくなったら、Destroyする
           Destroy(this.gameObject);
       }
    */
