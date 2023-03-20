using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_kari : MonoBehaviour
{
    // �v���C���[�ړ��p
    public Vector3 moveDir = new Vector3(0,0,0);


    // �r�[���Ɏg�p���Ă���ϐ��B******************************************************************************
    // �v���n�u�i�[�p
    public GameObject BeamParticleManagerPrefab;
    // �`���[�W�������Ԃɂ���ăr�[���̑傫�����ς��T�C�Y�ύX�p�̕ϐ�
    public float ParticleSize = 0.0f;
    // �`���[�W�������Ԃ��i�[����ϐ�(�K�v)
    private float chargeTime = 0.0f;
    // �r�[����1�b�Ԃɑ傫���Ȃ�
    public float BeamExpansion = 30.0f;
    // �r�[���Ɏg�p���Ă���ϐ��B(�����܂�)******************************************************************************


    // Start is called before the first frame update
    void Start()
    {
        chargeTime = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // �r�[�����ˏ���*************************************************************
        if (Input.GetKeyDown(KeyCode.Space)) // �L�[�R�[�h�͕ύX���Ă�(*^^*)
        {
            chargeTime += BeamExpansion * Time.deltaTime ;

            // �ő�l�͑�������Ȋ����ł���
            //if (chargeTime >= �}�b�N�X�T�C�Y)
            //{
            //    �}�b�N�X�T�C�Y�ɂ���
            //}
            
        }
        if (Input.GetKeyUp(KeyCode.Space)) // Down�Ɠ����L�[�R�[�h�ɂ��Ă�
        {
           
            // �T�C�Y���X�V����
            ParticleSize = chargeTime; 

            // �r�[���}�l�[�W���[�̒���BeamCollision���擾
            BeamParticleManagerPrefab.gameObject.transform.GetChild(1).localScale 
                                                                    = new Vector3 (ParticleSize,1.0f,1.0f);
            // �v���n�u���w��ʒu�ɐ���
            Instantiate(BeamParticleManagerPrefab, this.transform.position, gameObject.transform.localRotation);
            // �`���[�W���Ԃ�߂�
            chargeTime = 0.0f;
        }

        // �r�[�����ˏ���(�����܂�)*************************************************************



        // �ړ�����(��)*************************************************************
        if (Input.GetKey(KeyCode.D))
        {
            moveDir.x = 0.05f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            moveDir.x = -0.05f;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            moveDir.y = 0.05f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveDir.y = -0.05f;
        }
        else
        {
            moveDir = new Vector3(0, 0, 0);
        }

        transform.position += moveDir;

    // �ړ�����(��)�I���*************************************************************
    }
}
