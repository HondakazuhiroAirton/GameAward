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
        //Debug.Log(EnemyNo + "�Ԃ̓G�ɓ�������");
        //throw new System.NotImplementedException();
        EffectPos = EnemyManager.GetEnemyPos(EnemyNo);
        if (EffectPos != Vector3.zero) Debug.Log("enemy" + (EnemyNo + 1) + "�����W" + EffectPos + "�ŏ���");

        // �����Ŕ����̃G�t�F�N�g�Đ�


        EnemyManager.DestroyEnemy(EnemyNo);
    }


    // �G���擾
    public int GetEnemyIndex()
    {
        return EnemyNo;
    }

    // �G���Z�b�g
    public void SetEnemyIndex(int date)
    {
        EnemyNo = date;
    }

}
