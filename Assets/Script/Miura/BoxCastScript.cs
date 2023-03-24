using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCastScript : MonoBehaviour
{
    // �񋓑̏�Ԑ���
    public enum State
    {
        SCALE_UP = 0,
        SCALE_DOWN,

        SCALE_STATE_MAX
    }


    // public�]�[��*****************************************************
    // BeamParticleManager�擾
    public GameObject ParticleManager;

    // BeamParticle�擾
    public GameObject BeamParticle;

    // �p�[�e�B�N���̈ʒu�擾
    public Vector3 ParticlePosition;

    // �p�[�e�B�N���̈ړ��x�N�g���擾
    public Vector3 ParticleVector;

    // ���݂̏�ԕۑ�(�傫���Ȃ��Ԃ�/�������Ȃ��Ԃ�)
    public State NowState;

    // private�]�[��*****************************************************
    // BoxCast�����i�[
    private RaycastHit hit;

    // BoxCast�̑傫��������ϐ�
    private float scale;

    // �����I�u�W�F�N�g�ɂԂ����Ă��邩�ǂ���
    bool isHit;

    [SerializeField] // ����悭�킩���
    bool isEnable = false; // �M�Y���ɐ���\�����邩�ǂ���

    void Start()
    {
        // �ŏ��͊g����
        NowState = State.SCALE_UP;

        // (BeamParticleManager)�e�̃I�u�W�F�N�g���擾
        ParticleManager = transform.root.gameObject;
        // BeamParticle�I�u�W�F�N�g���擾Manager���猩��1�ԏ�̎q
        BeamParticle = ParticleManager.transform.GetChild(0).gameObject;
    }

    void Update()
    {
        // BoxCast�v�Z�]�[��*************************************************************************
        // �����蔻��̑傫��->���̑傫���̔����̈�����n���K�v�����邽��*0.5���Ă���
        scale = transform.lossyScale.x * 0.5f;


        switch (NowState)
        {
            // �g���Ԃ̎�
            case State.SCALE_UP:

                // �g���Ԃ̎���BeamParticle�̃|�W�V�������擾����
                ParticlePosition = BeamParticle.transform.position;
                
                // �x�N�g�����v�Z����
                ParticleVector = ParticlePosition - this.transform.position;

                // �P�ʃx�N�g���ɂ���
                ParticleVector = ParticleVector.normalized;

               
                break;

            // �k����Ԃ̎�
            case State.SCALE_DOWN:

                // �k����Ԃ̎���BeamParticle�̃|�W�V��������Ȃ�(�Ō�̃|�W�V�������Q�Ƃ���)

         
                
                // ���̕ӂŃf���[�g��������ˁ[


                break;

        }

        // BoxCast���΂� �@�@�@�@�ꏊ                  �傫��             ����(�x�N�g��)              ��]����?  
        isHit = Physics.BoxCast(transform.position, Vector3.one * scale, ParticleVector, out hit);
        //                                                                                �����������I�u�W�F�N�g�������Ɋi�[  
    }

    void OnDrawGizmos()
    {
        // �������邩�ǂ���
        if (isEnable == false)return;

        // �q�b�g���Ă���ꍇ
        if (isHit == true)
        {
            // ������܂Ő���`����
            Gizmos.DrawRay(transform.position, ParticleVector * hit.distance);
            // �Ԃ������Ƃ����Box�𓯂��傫���ŕ`��
            Gizmos.DrawWireCube(transform.position + ParticleVector * hit.distance, Vector3.one * scale * 2);
        }
        else
        {
            // ����L�΂�������
            Gizmos.DrawRay(transform.position, ParticleVector * 100);
        }
    }
}


/*
 
(�p�[�e�B�N���݌v�})     
     
     BeamParticleManager
      |__BeamParticle(���˂��邽�т�EndPos��n���Ď��̂���)
          |__BeamBoxCast1
          |__BeamBoxCast2...(���˂̂��тɃv���n�u���畡��)
     
     
     
     
     
*/
