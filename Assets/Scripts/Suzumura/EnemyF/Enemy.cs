using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, CollisionAction, EnemyInstance
{
    public int EnemyNo;
    public Vector3 EffectPos;
    public Boomef explosion;
    public bool explosionFlug;
    //private GameObject ThisEnemy;

    // Start is called before the first frame update
    void Start()
    {
        // EnemyManager King = EnemyManager.getinstace();
        //EnemyNo = EnemyManager.GetEnemyNo();
        //ThisEnemy = this.gameObject.GetComponent<GameObject>();
        //Debug.Log(ThisEnemy);
        explosion = GetComponent<Boomef>();
        explosionFlug = false;
    }
    // Update is called once per fram
    void Update()
    {
        //Debug.Log("���݁F" + (EnemyNo + 1));
    }

    public void CollisionEvent(GameObject obj)
    {
        //if (explosionFlug) return;
        explosionFlug = true;
        //throw new System.NotImplementedException();
        Debug.Log((EnemyNo + 1) + "��������...!");
        EffectPos = EnemyManager.GetEnemyPos(EnemyNo);
        if (EffectPos != Vector3.zero) Debug.Log("enemy" + (EnemyNo + 1) + "�����W" + EffectPos + "�ŏ���");

        // �����Ŕ����̃G�t�F�N�g�Đ�
        explosion.BoomCreate();

        EnemyManager.DestroyEnemy(EnemyNo);
    }


    public void EnemyIns(int no)
    {
        //throw new System.NotImplementedException();
        EnemyNo = no;
        Debug.Log((EnemyNo + 1) + "�������Ƃ����I");
    }

    // �G���擾
    public int GetEnemyIndex()
    {
        return EnemyNo;
    }

    // �G���Z�b�g
    //public static void SetEnemyIndex(int date)
    //{
    //    //EnemyNo = date;
    //}

}
