using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gimmick : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Beamline CollisionEvent()
    {
        Beamline beamline = new Beamline();
        //beamline.startPos = 0;


        return beamline;
    }

    public Beamline CollisionEvent(Beamline beamline)
    {
        Beamline newBeamline = new Beamline();


        //newBeamline.startPos = beamline
        //Vector3 moveDir = obj.GetComponent<BeamParticleScript>().moveDir; // �ړ������x�N�g��

        //Vector3 StartPosition = obj.GetComponent<BeamParticleScript>().StartPosition;
        //// �p�[�e�B�N���ƕ��ʂ̋���(���˃x�N�g�������߂�)
        //Vector3 inDirection = obj.transform.position - StartPosition;
        //// �P�ʃx�N�g����
        //inDirection = inDirection.normalized;

        //// �@���x�N�g�� (�擾������B����΂�!!)
        //Vector3 inNormal = transform.up.normalized;




        //// ���˃x�N�g��
        //Vector3 result = Vector3.Reflect(inDirection, inNormal);

        //// ���˃x�N�g�����ړ��ʂƂ��ăr�[���p�[�e�B�N���ɂ킽��
        //obj.GetComponent<BeamParticleScript>().moveDir = result * obj.GetComponent<BeamParticleScript>().Speed;

        //// �r�[���p�[�e�B�N���̃X�^�[�g�|�W�V�������X�V����
        //obj.GetComponent<BeamParticleScript>().StartPosition = obj.transform.position;

        //// ���˃A���O�����X�V����(�x�N�g������p�x�����߂�) <- ���W�A���l�������B
        //float Angle = Mathf.Atan2(result.y, result.x);

        //// ���W�A���l���f�B�O���[�l�ɕϊ�
        //Angle = Angle * Mathf.Rad2Deg;

        //// �r�[���p�[�e�B�N���̃A���O�����X�V����
        //obj.GetComponent<BeamParticleScript>().Angle = Angle;


        return newBeamline;
    }
}
