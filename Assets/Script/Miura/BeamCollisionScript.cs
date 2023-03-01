using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamCollisionScript : MonoBehaviour
{
    
    private GameObject collisionObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        collisionObject = collision.gameObject; // ぶつかったオブジェクトを取得

        if (collisionObject.tag == "Wall") // 衝突物が壁だったら
        {
            // レーザーパーティクルマネージャーを取得
            GameObject beamParticleManager = transform.parent.gameObject;

            // 反射させる
            Debug.Log("反射するよ");
        }
    }
}


// メモ
// 親子関係取得のアレコレ
//“transform.root.gameObject”は一番親のオブジェクトを取得
//“transform.parent.gameObject”は一つ上のオブジェクトを取得
