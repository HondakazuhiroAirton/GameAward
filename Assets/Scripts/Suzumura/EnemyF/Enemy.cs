using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, CollisionAction, EnemyInstance
{
    public int EnemyNo;
    public Vector3 EffectPos;
    public Boomef explosion;
    public Score score;
    public GameObject scoreUI;
    public bool explosionFlug;

    // Start is called before the first frame update
    void Start()
    {
        scoreUI = GameObject.Find("Score");
        explosion = GetComponent<Boomef>();
        score = scoreUI.GetComponent<Score>();
        explosionFlug = false;
    }
    // Update is called once per fram
    void Update()
    {

    }

    public void CollisionEvent(GameObject obj)
    {
        //if (explosionFlug) return;
        explosionFlug = true;
        //throw new System.NotImplementedException();
        Debug.Log((EnemyNo + 1) + "を消すよ...!");
        //EffectPos = EnemyManager.GetEnemyPos(EnemyNo);
        /*if (EffectPos != Vector3.zero) */Debug.Log("enemy" + (EnemyNo + 1) + "が座標" + transform.position + "で消滅");
        score.AddScore();
        // ここで爆発のエフェクト再生
        explosion.BoomCreate();

        EnemyManager.DestroyEnemy(EnemyNo);
    }


    public void EnemyIns(int no)
    {
        //throw new System.NotImplementedException();
        EnemyNo = no;
        Debug.Log((EnemyNo + 1) + "をうけとった！");
    }

    // 敵情報取得
    public int GetEnemyIndex()
    {
        return EnemyNo;
    }

}
