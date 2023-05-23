using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Effekseer;
public class Bullet : MonoBehaviour
{
    GameObject PD;
    //GameObject LeftSolar;
    //GameObject RightSolar;
    //GameObject Player;
    GameObject objects;
    beamlife PlayerClasslife;
    [SerializeField] GameObject player;
    public float ballSpeed = 10.0f;

    // 玉の移動方向
    public Vector3 moveVal;
    private float Wx;
    private float Wy;


    void Start()
    {
        //// エフェクトを取得する。
        //EffekseerEffectAsset effect = Resources.Load<EffekseerEffectAsset>("Bullet");
        //// transformの位置でエフェクトを再生する
        //EffekseerHandle handle = EffekseerSystem.PlayEffect(effect, transform.position);
        //// transformの回転を設定する。
        //handle.SetRotation(transform.rotation);

        // ビームライフへのアクセス
        //PlayerDateもってくる
        PD = GameObject.Find("PD");

        //Geter / Seter使用用スクリプト保持
        PlayerClasslife = PD.GetComponent<beamlife>();

        player = GameObject.Find("Player");

        //Animator animator = player.GetComponent<Animator>();
        //animator.SetBool("LeftSolar_flag", false);
        //RightSolar = GameObject.Find("RightSolar");


        //LeftSolar = GameObject.Find("LeftSolar");

        if (player != null)
        {
            // プレイヤーの場所取得
            Vector3 PlayerPos = player.transform.position;

            // ベクトル計算
            moveVal = PlayerPos - this.transform.position;

            // 正規化
            moveVal = moveVal.normalized;

            // 補正係数をかける
            moveVal.x *= ballSpeed;
            moveVal.y *= ballSpeed;
            moveVal.z *= ballSpeed;
        }
    }


    // Update is called once per frame
    void Update()
    {
        // 玉を毎フレームを動かしてる
        transform.position += moveVal * Time.deltaTime;

        Wx = Camera.main.WorldToViewportPoint(transform.position).x;
        Wy = Camera.main.WorldToViewportPoint(transform.position).y;

        if (0 >= Wx || Wx >= 1 )
        {
            GameObject.Destroy(this.gameObject);
        }
        else if (0 >= Wy || Wy >= 1)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        int LifePoint = PlayerClasslife.GetLife();
        if (other.gameObject.tag == "Player")
        {
            Debug.Log(LifePoint);
            if (LifePoint > 0)
            {
                bool Muteki = player.GetComponent<PlayerMove_MIURA>().Hidan();

                if (Muteki == false)
                {

                    LifePoint = LifePoint - 1;

                    PlayerClasslife.SetLife(LifePoint);

                }

                Destroy(this.gameObject);
            }
        }
    }
}
