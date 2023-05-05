using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, CollisionAction
{
    public int EnemyNo;
    public Vector3 EffectPos;

    // Start is called before the first frame update
    void Start()
    {
        // EnemyManager King = EnemyManager.getinstace();
        EnemyNo = EnemyManager.GetEnemyNo();
        //Debug.Log(EnemyNo);
    }

    // Update is called once per fram
    void Update()
    {
        
    }

    public void CollisionEvent(GameObject obj)
    {
        //Debug.Log(EnemyNo + "番の敵に当たった");
        //throw new System.NotImplementedException();
        EffectPos = EnemyManager.GetEnemyPos(EnemyNo);
        if (EffectPos != Vector3.zero) Debug.Log("enemy" + (EnemyNo + 1) + "が座標" + EffectPos + "で消滅");

        // ここで爆発のエフェクト再生


        EnemyManager.DestroyEnemy(EnemyNo);
    }


    // 敵情報取得
    public int GetEnemyIndex()
    {
        return EnemyNo;
    }

    // 敵情報セット
    public void SetEnemyIndex(int date)
    {
        EnemyNo = date;
    }

}
