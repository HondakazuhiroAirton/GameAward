using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollision : MonoBehaviour
{
    /// <summary>
    /// パーティクルが他のGameObject(Collider)に当たると呼び出される
    /// </summary>
    /// <param name="other"></param>
    private void OnParticleCollision(GameObject other)
    {
        // 当たった相手の色をランダムに変える
        //other.gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();

        // ここに敵がビームに当たったときの処理を書くとよさそう
        if (other.gameObject.tag == "Enemy")
        {
            GameObject obj = GameObject.FindGameObjectWithTag("Enemy");
            Destroy(obj);
        }
    }
}