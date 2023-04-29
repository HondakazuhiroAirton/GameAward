using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Effekseer;

public class BeamEffect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // エフェクシアのエフェクトもらう
        EffekseerEffectAsset effect = Resources.Load<EffekseerEffectAsset>("beemeee");

        // transformの位置でエフェクトを再生する
        EffekseerHandle handle = EffekseerSystem.PlayEffect(effect, transform.position);

        //// プレイヤーのZ角度持ってくる
        //float tmp = Player.transform.eulerAngles.z;
        //// tramsformの回転を設定する
        //Quaternion rot = Quaternion.Euler(tmp - 90, 270, 90);
        handle.SetRotation(Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
