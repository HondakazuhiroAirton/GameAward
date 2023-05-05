using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Effekseer;
public class Bullet : MonoBehaviour
{
    GameObject PD;
    GameObject objects;
    beamlife PlayerClasslife;
    public float ballSpeed = 10.0f;
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
    }


    // Update is called once per frame
    void Update()
    {

        var moveVal = transform.forward * ballSpeed * Time.deltaTime;
        transform.position += moveVal;

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
                LifePoint = LifePoint - 1;

                PlayerClasslife.SetLife(LifePoint);

            }
            else
            {
                Destroy(other.gameObject);
            }

            GameObject.Destroy(this.gameObject);
        }
    }
}
