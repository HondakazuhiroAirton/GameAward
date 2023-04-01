using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Beam")
        {
            // BoxCastのステイトを止める
            // ぶつかってきたオブジェクトの親オブジェクトを取得
            GameObject Parent = other.transform.root.gameObject;

            // 子オブジェクトの数を取得
            int childCount = Parent.transform.childCount;

            // 0からスタートなので-1する
            childCount--;

            // 一番新しいBoxCastを取得
            GameObject NewBoxCast = Parent.transform.GetChild(childCount).gameObject;

            // 一番最新のBoxCastをState.SCALE_STAYにする
            NewBoxCast.GetComponent<BoxCastScript>().NowState = BoxCastScript.State.SCALE_STAY;

            // 先行するParticleを非アクティブにする
            other.gameObject.SetActive(false);

        }
    }
}
