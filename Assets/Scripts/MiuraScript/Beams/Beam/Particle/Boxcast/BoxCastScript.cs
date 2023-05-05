using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCastScript : MonoBehaviour
{
    // �񋓑̏�Ԑ���
    public enum State
    {
        SCALE_UP = 0,
        SCALE_UPandDOWN,
        SCALE_STAY,
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

    // �r�[���̍Œ�
    public float BeamMax;

    // �p�[�e�B�N���̈ړ��x�N�g���擾
    public Vector3 ParticleVector;

    // �p�[�e�B�N���̈ړ���(Vector x Speed)���擾
    public Vector3 moveDir;

    // ���݂̏�ԕۑ�(�傫���Ȃ��Ԃ�/�������Ȃ��Ԃ�)
    public State NowState;

    // ���Ԗڂ̎q����
    public int ChildNo = 1;

    //  ���C���[�}�X�N
    public LayerMask LayerMask;
    // private�]�[��*****************************************************
    // BoxCast�����i�[
    private RaycastHit[] hit;

    // BoxCast�̑傫��������ϐ�
    private float scale;

    // BoxCast��Max�̒���
    private float maxDistance = 1.0f;

    // �����I�u�W�F�N�g�ɂԂ����Ă��邩�ǂ���
    RaycastHit[] isHit;

    [SerializeField] // private�����Ǖ\��
    bool isEnable = false; // �M�Y���ɐ���\�����邩�ǂ���

    void Start()
    {
        // �ŏ��͊g����
        NowState = State.SCALE_UP;

        // (BeamParticleManager)�e�̃I�u�W�F�N�g���擾
        ParticleManager = transform.root.gameObject;
        // BeamParticle�I�u�W�F�N�g���擾Manager���猩��1�ԏ�̎q
        BeamParticle = ParticleManager.transform.GetChild(0).gameObject;

        // BeamParticle�̃X�s�[�h���擾����
        moveDir = BeamParticle.GetComponent<BeamParticleScript>().moveDir;

        // BeamParticle�̒������擾����
        BeamMax = BeamParticle.GetComponent<BeamParticleScript>().BeamMax;
    }

    void Update()
    {
        // BoxCast�v�Z�]�[��*************************************************************************
        // �����蔻��̑傫��->���̑傫���̔����̈�����n���K�v�����邽��*0.5���Ă���
        scale = transform.lossyScale.x * 0.5f;
        Vector3 BoxCastPosition = this.transform.position;

        switch (NowState)
        {
            // �g���Ԃ̎�
            case State.SCALE_UP:

                // �g���Ԃ̎���BeamParticle�̃|�W�V�������擾����
                ParticlePosition = BeamParticle.transform.position;
                
                // �x�N�g�����v�Z����
                ParticleVector = ParticlePosition - BoxCastPosition;

                // �P�ʃx�N�g���ɂ���
                ParticleVector = ParticleVector.normalized;

                // �r�[���̒��������ȏ�ɂȂ�����
                if (Vector3.Distance(ParticlePosition, transform.position) >= BeamMax)
                {
                    // �L�яk�݂�State�ɕύX����
                    NowState = State.SCALE_UPandDOWN;
                }


                break;

            // �L�тȂ���k�ގ�
            case State.SCALE_UPandDOWN:

                // �k��
                transform.position += moveDir;

                // �g���Ԃ̎���BeamParticle�̃|�W�V�������擾����
                ParticlePosition = BeamParticle.transform.position;

                // �x�N�g�����v�Z����
                ParticleVector = ParticlePosition - BoxCastPosition;

                // �P�ʃx�N�g���ɂ���
                ParticleVector = ParticleVector.normalized;


                break;



            // ��Ԉێ��̎�
            case State.SCALE_STAY:

                // ��ɑO�̓����蔻��̃`�F�b�N�{�b�N�X�����Ă�
                GameObject BeforeChild = ParticleManager.transform.GetChild(ChildNo - 1).gameObject;
                
                // �O�����蔻��̃`�F�b�N�{�b�N�X������
                if (BeforeChild.activeSelf == false || ChildNo == 1) // �O�̃`�F�b�N���������玩����Scale_Down�ɕύX
                {
                    NowState = State.SCALE_DOWN;
                    Debug.Log(ChildNo+"�͏k�����J�n���܂�");
                }
                
                break;

            // �k����Ԃ̎�
            case State.SCALE_DOWN:

                // ���񂾂�k��
                transform.position += moveDir;


                // ���������������Ȃ����玩���̃`�F�b�N�{�b�N�X������
                if (Vector3.Distance(ParticlePosition, transform.position) <= 1.0f)
                {
                    Debug.Log("��������܂�");
                    // ���̃I�u�W�F�N�g���A�N�e�B�v�ɂ���
                    this.gameObject.SetActive(false);
                }

                break;

                

        }


        // 2�_�Ԃ̋��������߂�
        maxDistance = Mathf.Pow((ParticlePosition.x - BoxCastPosition.x), 2.0f) +
                       Mathf.Pow((ParticlePosition.y - BoxCastPosition.y), 2.0f) +
                        Mathf.Pow((ParticlePosition.z - BoxCastPosition.z), 2.0f);

        // ��������[�g�ɂ���
        maxDistance = Mathf.Sqrt(maxDistance);

        // BoxCast���΂� �@�@�@�@�ꏊ                  �傫��             ����(�x�N�g��)              ��]����?  
        isHit = Physics.BoxCastAll(transform.position, Vector3.one * scale, ParticleVector, Quaternion.identity, maxDistance,LayerMask);
        //                                                                                �����������I�u�W�F�N�g�������Ɋi�[  

        // BoxCast�ɂ��������I�u�W�F�N�g�̏���
        foreach(var obj in isHit)
        {
            GameObject hitObject = obj.collider.gameObject;
            Debug.Log("����������");
            // �C���^�[�t�F�X�œn����
            hitObject.GetComponent<CollisionAction>().CollisionEvent(this.gameObject);
            
        }


    }

    void OnDrawGizmos()
    {
        // �������邩�ǂ���
        if (isEnable == false)return;

        // ������܂Ő���`����
        Gizmos.DrawRay(transform.position, ParticleVector * maxDistance);
        // �Ԃ������Ƃ����Box�𓯂��傫���ŕ`��
        Gizmos.DrawWireCube(transform.position + ParticleVector * maxDistance, Vector3.one * scale * 2);

    }

    //public void CollisionEvent(GameObject obj)
    //{
    //    throw new System.NotImplementedException();
    //}
}


/*
 
(�p�[�e�B�N���݌v�})     
     
     BeamParticleManager
      |__BeamParticle(���˂��邽�т�EndPos��n���Ď��̂���)
          |__BeamBoxCast1
          |__BeamBoxCast2...(���˂̂��тɃv���n�u���畡��)
     
     
     
     
     
*/
