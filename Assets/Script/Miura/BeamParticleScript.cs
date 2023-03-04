using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamParticleScript : MonoBehaviour
{
    // �ړ��������
    public float XMove = 1;
    public float YMove = -1;
    public float ZMove = 0.0f;
    public float Speed = 0.1f; // �ړ����x�͂����ŕύX���Ă�

    // �X�^�[�g�ʒu�ۑ�
    public Vector3 StartPosition;
    public Vector3 moveDir;

    // Start is called before the first frame update
    void Start()
    {
        // �ړ��ʂ��ŏ��ɑ��
        moveDir = new Vector3(XMove, YMove, ZMove).normalized * Speed;

        // �J�n���ɏ����ʒu���i�[
        StartPosition = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // �ړ�
        transform.position += moveDir;

    }
    public void ParticleCollision()
    {


    }

    public void CollisionEvent(GameObject obj)
    {
        throw new System.NotImplementedException();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //collisionObject = collision.gameObject; // �Ԃ������I�u�W�F�N�g���擾

        //if (collisionObject.tag == "wall") // �Փ˕������˕���������
        //{
        //    // ���˂�����
        //    
        //    GameObject beamParticle = transform.parent.gameObject; // �p�[�e�B�N��1�̃Q�[���I�u�W�F�N�g���擾����
        //    //beamParticle.gameObject.ParticleCollision();
        //}
        Debug.Log("���˂����");
        // �Ȃ��˂񂱂�
        collision.gameObject.GetComponent<CollisionAction>().CollisionEvent(this.gameObject);
    }
}

// 0301 �O�Y�u
// ���̃��[�U�[��r���ŋȂ���d�l�ɕύX����ꍇ�A��������K�v����
// �@�J�n�n�_�̏ꏊ��ۑ����Ă���
// �A�����蔻�������u�ԂɊJ�n�n�_->���̈ʒu�ƕǂ̖@���x�N�g���œ��ς����
// �B�J�n�n�_�X�V
// �C���˃J�E���g+1
// ����łł���������Ȃ�??
// ������Q�[���I�u�W�F�N�g�S���i�[??



// ����
// �e�q�֌W�擾�̃A���R��
//�gtransform.root.gameObject�h�͈�Ԑe�̃I�u�W�F�N�g���擾
//�gtransform.parent.gameObject�h�͈��̃I�u�W�F�N�g���擾