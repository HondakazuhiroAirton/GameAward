// �r�[���̐擪�œ��������߂�X�N���v�g
// �p�x����̓v���C���[����Angle���X�V���Ă�������


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BeamParticleScript : MonoBehaviour
{
    // �ړ�����p�x
    public float Angle = 0.0f; // �e�̉�]�p�x�w��
    public float Speed = 0.1f; // �ړ����x�͂����ŕύX���Ă�
    // ���ˉ�
    public int ReflectMax = 1000; // 10000�Ŕ��ː����Ȃ�
    //�e��Manager���擾
    public GameObject ParticleManager;
    // �v���n�u�i�[�p
    public GameObject BeamParticleManagerPrefab;
    // �X�^�[�g�ʒu�ۑ�
    public Vector3 StartPosition;
    // �ړ��ʕۑ�
    public Vector3 moveDir;
    // BeamCollision��AngleHosei����������������
    public float AngleHosei;

    // ���̔��ˉ�
    private int reflectCount = 0;
    // �ړ��������
    private float XMove = 1.0f;
    private float YMove = 0.0f;
    private float ZMove = 0.0f;



    // Start is called before the first frame update
    void Start()
    {
      // Angle����ړ��ʂ����߂鏈��
        
        // Angle(�x)�����W�A���ɕύX
        Angle = Mathf.Deg2Rad * Angle;

        // XMove��YMove��Cos/Sin�ňړ��ʂ����߂�
        XMove = Mathf.Cos(Angle);
        YMove = Mathf.Sin(Angle);

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
            // ��1 �����Ő��Angle�̔��ˍX�V��Wall���������
            collision.gameObject.GetComponent<CollisionAction>().CollisionEvent(this.gameObject);

            // ���˂̓����蔻����X�V���鏈��

            // �r�[�������蔻����v���n�u�������Ă���
            var BeamCollision = BeamParticleManagerPrefab.gameObject.transform.GetChild(1);
            // �v���n�u�̒��g�L���C�ɂ���
            // x�̊g�嗦������Ă���
            float xSize = BeamCollision.transform.localScale.x;
            // ����������
            BeamCollision.GetComponent<BeamCollision>().Start();

            // �X�P�[�������Ƃɖ߂�
            BeamCollision.transform.localScale = new Vector3(xSize,1.0f,1.0f);


            // �p�x������(�␳�l��BeamCollision������ύX)
            // ��2 Wall������ύX���ꂽ�p�x���g���ĐV���������蔻������
            Instantiate(BeamCollision, this.transform.position, Quaternion.Euler(0.0f, 0.0f, Angle - AngleHosei));
            
        }
        else
        {
            // ���ˉ񐔂��Ȃ��Ȃ�����ADestroy����
            Destroy(this.gameObject);
        }
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