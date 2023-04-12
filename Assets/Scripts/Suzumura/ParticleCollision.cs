using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollision : MonoBehaviour
{
    /// <summary>
    /// パーティクルが他のGameObject(Collider)に当たると呼び出される
    /// </summary>
    /// <param name="other"></param>

    public float stopcount = 2.0f;
    public float currenttime = 0;
    public float rotatetime = 0;
    public bool bUse;

    // Start is called before the first frame update
    void Start()
    {
        bUse = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!bUse)
        {
            currenttime += Time.deltaTime;
            rotatetime++;
            if (rotatetime <= 30) BoardCollision.instance.CollisionBoard(3.0f);
            if (currenttime >= stopcount)
            {
                bUse = true;
                currenttime = 0;
                rotatetime = 0;
                Debug.Log("解除!");
            }
        }
    }

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

        // 回転させる板に当たった時の処理
        if (other.gameObject.tag == "shaft" && bUse)
        {
            // 一つのパーティクルでも当たったら当たり判定を一時的に切る
            if (bUse) bUse = false;
            Debug.Log("停止...");
        }
    }

}