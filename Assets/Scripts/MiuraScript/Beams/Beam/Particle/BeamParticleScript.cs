// �r�[���̐擪�œ��������߂�X�N���v�g
// �p�x����̓v���C���[����Angle���X�V���Ă�������

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Effekseer;

public class BeamParticleScript : MonoBehaviour
{
    //public�]�[��***********************************************************
    // �R���{��
    public int combo;

    // �Q�[�����̕ϐ�����***********************
    // �ړ�����p�x
    public float Angle = 0.0f; // �e�̉�]�p�x�w��
    public float Speed = 2.0f; // �ړ����x�͂����ŕύX���Ă�

    // ���ˉ�
    public int ReflectMax = 1000; // 1000�Ŕ��ː����Ȃ�

    // ParticleManager
    public GameObject ParticleManager;

    // ���̃{�b�N�X�L���X�g(State�ύX���Ɏg�p)
    public GameObject NowBoxCast;

    // �X�^�[�g�ʒu�ۑ�
    public Vector3 StartPosition;

    // �ړ��ʕۑ�
    public Vector3 moveDir;

    // Beam�̍ő勗��
    public float BeamMax;

    // �p�x�̕␳�l(BeamCollision��AngleHosei��Wall������������)
    public float AngleHosei;

    // �v���n�u����*****************************
    // ���˗p�����蔻��v���n�u�i�[
    public GameObject BeamBoxCastReflect;

    // �v���C���[�����
    public GameObject Player;

    // �G�t�F�N�V�A�֘A�̊֐�
    //��](�O������X�V�������Ċp�x��ω�������)
    public float PlayerAngle;

    // ���̃r�[�����x����ێ����Ă���(�O������炤) 
    public int NowBeamLevel;

    // private�]�[��********************************************
    // ���̔��ˉ�
    private int reflectCount = 0;

    // ���˂̎q���Ǘ��ϐ�
    private int child = 0;

    // �ړ��������
    private float XMove = 1.0f;
    private float YMove = 0.0f;
    private float ZMove = 0.0f;

    // �G�t�F�N�V�A�p�֐��A���R��
    // �Đ�����A�Z�b�g�z��
    private EffekseerEffectAsset[] effect; 

    // �n���h��
    private EffekseerHandle handle;
    // �G�t�F�N�g�̉�]�v�Z
    private Quaternion EffectRot;

    // Update�̃G�t�F�N�g�\���񐔐���
    private int effectCount; 

    // �����蔻��̊g�嗦��ۑ�
    // private float xCollisionSize = 1.0f;


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

        // ParticleManager���擾
        ParticleManager = transform.root.gameObject;

        // �v���C���[���������ĒT��
        Player = GameObject.Find("Player");

        // �G�t�F�N�V�A�̃G�t�F�N�g���炤
        // Beam�̑傫���ɉ�����switch�����đ傫������
        effect = new EffekseerEffectAsset[5];

        effect[0] = Resources.Load<EffekseerEffectAsset>("beam0");
        effect[1] = Resources.Load<EffekseerEffectAsset>("beam1");
        effect[2] = Resources.Load<EffekseerEffectAsset>("beam2");
        effect[3] = Resources.Load<EffekseerEffectAsset>("beam3");
        effect[4] = Resources.Load<EffekseerEffectAsset>("beam4");
        // transform�̈ʒu�ŃG�t�F�N�g���Đ�����


        handle = EffekseerSystem.PlayEffect(effect[NowBeamLevel], transform.position);
        // tramsform�̉�]��ݒ肷��
        EffectRot = Quaternion.Euler(0 , 0 , PlayerAngle);

        //handle.SetRotation(EffectRot);
        effectCount = 0;
    }

    void Update()
    {
        if (Time.deltaTime <= 0) return;

        // �ړ�����
        transform.position += moveDir;

        // �\���񐔐��䏈��
        switch (NowBeamLevel)
        {
            case 0: // �r�[�����S�R���܂��ĂȂ��� 5���1��Ă�
                effectCount++;
                if (effectCount >= 3)
                {
                    BeamEffect();
                    effectCount = 0;
                }
                break;
            
            default:
                BeamEffect();

                break;
        }

    }

    public void CollisionEvent(GameObject obj)
    {
        //throw new System.NotImplementedException();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reflector") // ���˂���I�u�W�F�N�g�ɂ��������甭��
        {
            if (ReflectMax > reflectCount)
            {
                // ���ˉ񐔂��ݒ肳��Ă����1���炷
                if (ReflectMax < 1000) reflectCount--;

                // �q���̕ϐ���1�i�߂�
                child++;

                Debug.Log("���˕��ɂ���������");

                // �L�тĂ�BoxCast���k����Ԃɂ���
                // BoxCast���擾
                NowBoxCast = ParticleManager.transform.GetChild(child).gameObject;

                // �傫�����L�^���Ă���
                float BoxCastScale = NowBoxCast.transform.localScale.x;

                // BoxCast�̏�Ԃ�����ێ���Ԃɂ���
                NowBoxCast.GetComponent<BoxCastScript>().NowState = BoxCastScript.State.SCALE_STAY;

                // Wall�̔��˃A�N�V�������N����
                other.gameObject.GetComponent<CollisionAction>().CollisionEvent(this.gameObject);


                // �G�t�F�N�g�p�x���X�V����
                PlayerAngle = Angle - 270;

                // �O�����ăv���n�u�̑傫����ύX���Ă���
                BeamBoxCastReflect.transform.localScale = new Vector3(BoxCastScale, BoxCastScale, BoxCastScale);

                // ���̃v���n�u��BoxCast��No��ݒ肷��
                BeamBoxCastReflect.GetComponent<BoxCastScript>().ChildNo = child + 1;


                // ���̔��˂̓����蔻��𐶂ݏo������
                Instantiate(BeamBoxCastReflect, this.transform.position, Quaternion.identity, ParticleManager.transform);

            }
            else
            {
                // ���ˉ񐔂��Ȃ��Ȃ�����A��A�N�e�B�u�ɂ���
                this.gameObject.SetActive(false);
            }
        }
    }

    public void BeamStart()
    {
     
    }

    public void BeamEffect()
    {
        //�G�t�F�N�V�A�̃G�t�F�N�g���炤
        //transform�̈ʒu�ŃG�t�F�N�g���Đ�����
        //�ꏊ�w��
        EffekseerHandle handle = EffekseerSystem.PlayEffect(effect[NowBeamLevel], transform.position);

        // tramsform�̉�]��ݒ肷��
        EffectRot = Quaternion.Euler(0, 0, PlayerAngle);
        //�p�x�w��
        handle.SetRotation(EffectRot);
    }


    // �R���{���\���֐�


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


/*
// Box��L�΂��Ă����Ƃ��̃X�N���v�g
     if (ReflectMax > reflectCount)
       {
           // ���ˉ񐔂��ݒ肳��Ă����1���炷
           if(ReflectMax < 1000)reflectCount--;

           //reflectCount++;

           // �ȉ��A����
           Debug.Log("���˂����");
           // ��1 �����Ő��Angle�̔��ˍX�V��Wall���������
           collision.gameObject.GetComponent<CollisionAction>().CollisionEvent(this.gameObject);

           // ���˂̓����蔻��𐶂ݏo������************************************************

           // ���˓����蔻��̉���������Collision�Ɠ����ɂ���
           BeamCollisionReflect.transform.localScale = new Vector3(xCollisionSize,1.0f,1.0f);

           // �p�x������(�␳�l��BeamCollision������ύX)
           // ��2 Wall������ύX���ꂽ�p�x���g���ĐV���������蔻������
           Instantiate(BeamCollisionReflect, this.transform.position, Quaternion.Euler(0.0f, 0.0f, Angle - AngleHosei), ParticleManager.transform);

       }
       else
       {
           // ���ˉ񐔂��Ȃ��Ȃ�����ADestroy����
           Destroy(this.gameObject);
       }
    */
