using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BeamParticleScript : MonoBehaviour
{
    // �ړ�����p�x
    public float Angle = 1.0f;

    // �ړ��������
    public float XMove = 1.0f;
    public float YMove = 0.0f;
    public float ZMove = 0.0f;
    public float Speed = 0.1f; // �ړ����x�͂����ŕύX���Ă�
    // ���ˉ�
    public int ReflectMax = 1000; // 10000�Ŕ��ː����Ȃ�

    // �X�^�[�g�ʒu�ۑ�
    public Vector3 StartPosition;
    public Vector3 moveDir;

    // ���̔��ˉ�
    protected int reflectCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        // �p�x����ړ��������v�Z
        
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

    public void CollisionEvent(GameObject obj)
    {
        //throw new System.NotImplementedException();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (ReflectMax > reflectCount)
        {
            // ���ˉ񐔂��ݒ肳��Ă����1���炷
            if(ReflectMax < 1000)reflectCount--;

            // �ȉ��A����
            Debug.Log("���˂����");
            collision.gameObject.GetComponent<CollisionAction>().CollisionEvent(this.gameObject);

        }
        //else
        //{
        //    // �����Ŕ��ˉ񐔂��I�������ADestroy�I�ȏ���
        //    // �l����
        //}
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