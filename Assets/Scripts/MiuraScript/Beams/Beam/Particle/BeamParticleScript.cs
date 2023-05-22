// ビームの先頭で動きを決めるスクリプト
// 角度操作はプレイヤー側でAngleを更新してください

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Effekseer;

public class BeamParticleScript : MonoBehaviour
{
    //publicゾーン***********************************************************
    // コンボ数
    public int combo;

    // ゲーム中の変数属性***********************
    // 移動する角度
    public float Angle = 0.0f; // 親の回転角度指定
    public float Speed = 2.0f; // 移動速度はここで変更してね

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

    // Beamの最大距離
    public float BeamMax;

    // 角度の補正値(BeamCollisionのAngleHoseiをWall側から代入する)
    public float AngleHosei;

    // プレハブ属性*****************************
    // 反射用当たり判定プレハブ格納
    public GameObject BeamBoxCastReflect;

    // プレイヤーいれる
    public GameObject Player;

    // エフェクシア関連の関数
    //回転(外部から更新をかけて角度を変化させる)
    public float PlayerAngle;

    // 今のビームレベルを保持しておく(外からもらう) 
    public int NowBeamLevel;

    // privateゾーン********************************************
    // 今の反射回数
    private int reflectCount = 0;

    // 反射の子供管理変数
    private int child = 0;

    // 移動する方向
    private float XMove = 1.0f;
    private float YMove = 0.0f;
    private float ZMove = 0.0f;

    // エフェクシア用関数アレコレ
    // 再生するアセット配列
    private EffekseerEffectAsset[] effect; 

    // ハンドル
    private EffekseerHandle handle;
    // エフェクトの回転計算
    private Quaternion EffectRot;

    // Updateのエフェクト表示回数制御
    private int effectCount; 

    // 当たり判定の拡大率を保存
    // private float xCollisionSize = 1.0f;


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

        // プレイヤーを検索して探す
        Player = GameObject.Find("Player");

        // エフェクシアのエフェクトもらう
        // Beamの大きさに応じてswitchかけて大きさ調整
        effect = new EffekseerEffectAsset[5];

        effect[0] = Resources.Load<EffekseerEffectAsset>("beam0");
        effect[1] = Resources.Load<EffekseerEffectAsset>("beam1");
        effect[2] = Resources.Load<EffekseerEffectAsset>("beam2");
        effect[3] = Resources.Load<EffekseerEffectAsset>("beam3");
        effect[4] = Resources.Load<EffekseerEffectAsset>("beam4");
        // transformの位置でエフェクトを再生する


        handle = EffekseerSystem.PlayEffect(effect[NowBeamLevel], transform.position);
        // tramsformの回転を設定する
        EffectRot = Quaternion.Euler(0 , 0 , PlayerAngle);

        //handle.SetRotation(EffectRot);
        effectCount = 0;
    }

    void Update()
    {
        if (Time.deltaTime <= 0) return;

        // 移動処理
        transform.position += moveDir;

        // 表示回数制御処理
        switch (NowBeamLevel)
        {
            case 0: // ビームが全然溜まってない時 5回に1回呼ぶ
                effectCount++;
                if (effectCount >= 3)
                {
                    BeamEffect();
                    effectCount = 0;
                }
                break;
            
            default:
                BeamEffect();

                break;
        }

    }

    public void CollisionEvent(GameObject obj)
    {
        //throw new System.NotImplementedException();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reflector") // 反射するオブジェクトにあたったら発動
        {
            if (ReflectMax > reflectCount)
            {
                // 反射回数が設定されていれば1減らす
                if (ReflectMax < 1000) reflectCount--;

                // 子供の変数を1進める
                child++;

                Debug.Log("反射物にあたったよ");

                // 伸びてたBoxCastを縮小状態にする
                // BoxCastを取得
                NowBoxCast = ParticleManager.transform.GetChild(child).gameObject;

                // 大きさを記録しておく
                float BoxCastScale = NowBoxCast.transform.localScale.x;

                // BoxCastの状態を現状維持状態にする
                NowBoxCast.GetComponent<BoxCastScript>().NowState = BoxCastScript.State.SCALE_STAY;

                // Wallの反射アクションを起こす
                other.gameObject.GetComponent<CollisionAction>().CollisionEvent(this.gameObject);


                // エフェクト角度も更新する
                PlayerAngle = Angle - 270;

                // 前もってプレハブの大きさを変更しておく
                BeamBoxCastReflect.transform.localScale = new Vector3(BoxCastScale, BoxCastScale, BoxCastScale);

                // 次のプレハブのBoxCastのNoを設定する
                BeamBoxCastReflect.GetComponent<BoxCastScript>().ChildNo = child + 1;


                // つぎの反射の当たり判定を生み出す処理
                Instantiate(BeamBoxCastReflect, this.transform.position, Quaternion.identity, ParticleManager.transform);

            }
            else
            {
                // 反射回数がなくなったら、非アクティブにする
                this.gameObject.SetActive(false);
            }
        }
    }

    public void BeamStart()
    {
     
    }

    public void BeamEffect()
    {
        //エフェクシアのエフェクトもらう
        //transformの位置でエフェクトを再生する
        //場所指定
        EffekseerHandle handle = EffekseerSystem.PlayEffect(effect[NowBeamLevel], transform.position);

        // tramsformの回転を設定する
        EffectRot = Quaternion.Euler(0, 0, PlayerAngle);
        //角度指定
        handle.SetRotation(EffectRot);
    }


    // コンボ数表示関数


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
