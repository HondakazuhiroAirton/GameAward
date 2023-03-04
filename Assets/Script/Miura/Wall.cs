using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour,CollisionAction
{

    public void CollisionEvent(GameObject obj)
    {
        Vector3 moveDir = GetComponent<BeamParticleScript>().moveDir; ;          // �ړ������x�N�g��

        Vector3 StartPosition = GetComponent<BeamParticleScript>().StartPosition;
        // �p�[�e�B�N���ƕ��ʂ̋���
        Vector3 d = StartPosition - this.transform.position;
        // �ړ��x�N�g���Ɩ@���x�N�g���̓���
        float h = Vector3.Dot(d, this.transform.up);




        // ���˃x�N�g�����v�Z����
        Vector3 n = this.transform.up; // �n�ʂ̖@���x�N�g��������
        float Naseki = Mathf.Abs(Vector3.Dot(moveDir, n)); // ��Βl�����,�ړ��x�N�g���ƒn�ʂ̖@���x�N�g���̓��ς����
        Vector3 r = moveDir + 2 * n * h; // ����2�{�L�΂�
        moveDir = r;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
