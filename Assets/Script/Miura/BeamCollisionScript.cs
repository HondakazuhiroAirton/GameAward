using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamCollisionScript : MonoBehaviour
{
    
    private GameObject collisionObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        collisionObject = collision.gameObject; // �Ԃ������I�u�W�F�N�g���擾

        if (collisionObject.tag == "Wall") // �Փ˕����ǂ�������
        {
            // ���[�U�[�p�[�e�B�N���}�l�[�W���[���擾
            GameObject beamParticleManager = transform.parent.gameObject;

            // ���˂�����
            Debug.Log("���˂����");
        }
    }
}


// ����
// �e�q�֌W�擾�̃A���R��
//�gtransform.root.gameObject�h�͈�Ԑe�̃I�u�W�F�N�g���擾
//�gtransform.parent.gameObject�h�͈��̃I�u�W�F�N�g���擾
