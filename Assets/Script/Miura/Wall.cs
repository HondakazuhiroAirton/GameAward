using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour,CollisionAction
{

    public void CollisionEvent(GameObject obj)
    {
        Vector3 moveDir = obj.GetComponent<BeamParticleScript>().moveDir; // �ړ������x�N�g��

        Vector3 StartPosition = obj.GetComponent<BeamParticleScript>().StartPosition;
        // �p�[�e�B�N���ƕ��ʂ̋���(���˃x�N�g�������߂�)
        Vector3 AngleOfIncidence = StartPosition - this.transform.position;
        AngleOfIncidence = AngleOfIncidence.normalized;

        //if (AngleOfIncidence)
        //{

        //}


        // ���˃x�N�g���Ɩ@���x�N�g���̓���
        float h = Vector3.Dot(AngleOfIncidence, this.transform.up);
        
        // ���˃x�N�g�����v�Z����
        Vector3 n = this.transform.up; // �n�ʂ̖@���x�N�g��������
        float Naiseki = Mathf.Abs(Vector3.Dot(moveDir,n)); // ��Βl�����,�ړ��x�N�g���ƒn�ʂ̖@���x�N�g���̓��ς����

        Vector3 r = moveDir + 2 * n * h; // ����2�{�L�΂�
        obj.GetComponent<BeamParticleScript>().moveDir = r.normalized * obj.GetComponent<BeamParticleScript>().Speed;
        obj.GetComponent<BeamParticleScript>().StartPosition = this.transform.position;

        // ���ː����̃J�E���g���₷
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
