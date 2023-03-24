// BeamCollisionのスクリプトを使いつつ、
// 反射で出現させる当たり判定プレハブにつけるスクリプト

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamCollisionReflect : MonoBehaviour
{
    // BeamManagerオブジェクトを入れる変数
    private GameObject beamManager;
    // BeamParticleオブジェクトを入れる変数
    private GameObject beamParticle;

    // Start is called before the first frame update
    void Start()
    {
        // 出現時空白になってしまうBeamCollisionの[public GameObject BeamParticle]変数を外から代入してあげる********

        // BeamManagerオブジェクト取得(BeamCollisionReflectから見て親)
        beamManager = transform.parent.gameObject;

        // BeamParticleオブジェクト取得(BeamManagerオブジェクトから見て0番目の子)
        beamParticle = beamManager.transform.GetChild(0).gameObject;

        // スクリプト上のBeamParticleに取得したBeamParticleオブジェクトを代入する
        this.gameObject.GetComponent<BeamCollision>().BeamParticle = beamParticle;

    }

    // Update is called once per frame
    void Update()
    {
    }
}
