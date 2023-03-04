using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamParticleScript : MonoBehaviour
{
    public GameObject plane;
    Vector3 moveDir;           // �ړ������x�N�g��
    // �ړ��������
    public float XMove = 1;
    public float YMove = -1;
    public float ZMove = 0.0f;
    public float Speed = 0.1f; // �ړ����x�͂����ŕύX���Ă�

    // �X�^�[�g�ʒu�ۑ�
    public Vector3 StartPosition;

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

         // �p�[�e�B�N���ƕ��ʂ̋���
         Vector3 d = transform.position - plane.transform.position;
        // �ړ��x�N�g���Ɩ@���x�N�g���̓���
         float h = Vector3.Dot(d, plane.transform.up);

    }
    public void ParticleCollision()
    {
        // ���˃x�N�g�����v�Z����
        Vector3 n = plane.transform.up; // �n�ʂ̖@���x�N�g��������
        float h = Mathf.Abs(Vector3.Dot(moveDir, n)); // ��Βl�����,�ړ��x�N�g���ƒn�ʂ̖@���x�N�g���̓��ς����
        Vector3 r = moveDir + 2 * n * h; // ����2�{�L�΂�
        moveDir = r;

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
