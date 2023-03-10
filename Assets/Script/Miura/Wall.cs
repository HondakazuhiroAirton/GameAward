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
        Vector3 inDirection =  obj.transform.position - StartPosition;
        // �P�ʃx�N�g����
        inDirection = inDirection.normalized;
    
        // �@���x�N�g�� ������BB3D�Ƃ��g������s���������H�H
        Vector3 inNormal = transform.up.normalized;




        // ���˃x�N�g��
        Vector3 result = Vector3.Reflect(inDirection, inNormal);

        // ���˃x�N�g�����ړ��ʂƂ��ăr�[���p�[�e�B�N���ɂ킽��
        obj.GetComponent<BeamParticleScript>().moveDir = result * obj.GetComponent<BeamParticleScript>().Speed;

        // �r�[���p�[�e�B�N���̃X�^�[�g�|�W�V�������X�V����
        obj.GetComponent<BeamParticleScript>().StartPosition = obj.transform.position;


        // �̍l�����v���O����******************************
        //// ���˃x�N�g���Ɩ@���x�N�g���̓��ρ��@���x�N�g���̎擾�����������́H�H�H�H
        //Vector3 n = this.transform.up.normalized; // �n�ʂ̖@���x�N�g��������
        //float h = Vector3.Dot(AngleOfIncidence, n);
        //// ���˃x�N�g�����v�Z����
        //float Naiseki = Mathf.Abs(Vector3.Dot(moveDir,n)); // ��Βl�����,�ړ��x�N�g���ƒn�ʂ̖@���x�N�g���̓��ς����
        //Vector3 r = moveDir + 2 * n * h; // ����2�{�L�΂�
        //obj.GetComponent<BeamParticleScript>().moveDir = r.normalized * obj.GetComponent<BeamParticleScript>().Speed;
        // ************************************************


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
