using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Effekseer;

public class life : MonoBehaviour
{
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;
    public GameObject Obj;
    int Life;

    GameObject LeftSolar;
    GameObject RightSolar;
    GameObject Player;
    //Animator animator;
    //GameObject LeftSolar;

    // Start is called before the first frame update
    void Start()
    {
        LeftSolar = GameObject.Find("LeftSolar");
        RightSolar = GameObject.Find("RightSolar");
        Player = GameObject.Find("Player");

        life1 = GameObject.Find("life1");
        life2 = GameObject.Find("life2");
        life3 = GameObject.Find("life3");
        //Obj = GameObject.Find("GameObject");
        Life = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Life = Obj.GetComponent<beamlife>().GetLife();
        if (Life == 2)
        {
            life1.SetActive(false);
            // エフェクトを取得する。
            //EffekseerEffectAsset effect = Resources.Load<EffekseerEffectAsset>("Explosion");
            //// transformの位置でエフェクトを再生する
            //EffekseerHandle handle = EffekseerSystem.PlayEffect(effect, LeftSolar.transform.position);

            //LeftSolar.SetActive(false);
        }
        if (Life == 1)
        {
            life2.SetActive(false);
            //// エフェクトを取得する。
            //EffekseerEffectAsset effect = Resources.Load<EffekseerEffectAsset>("Explosion");
            //// transformの位置でエフェクトを再生する
            //EffekseerHandle handle = EffekseerSystem.PlayEffect(effect, RightSolar.transform.position);

            //RightSolar.SetActive(false);
        }
        if (Life <= 0)
        {
            life3.SetActive(false);
            //// エフェクトを取得する。
            //EffekseerEffectAsset effect = Resources.Load<EffekseerEffectAsset>("Explosion");
            //// transformの位置でエフェクトを再生する
            //EffekseerHandle handle = EffekseerSystem.PlayEffect(effect, Player.transform.position);
            //Player.SetActive(false);


            //Obj.GetComponent<beamlife>().GameOver();
        }

        //if(Input.GetKey(KeyCode.K))
        //{
        //    player = GameObject.Find("Player");
        //    Animator animator = player.GetComponent<Animator>();
        //    animator.SetBool("LeftSoalr_flag", true);
        //}

    }
    
}