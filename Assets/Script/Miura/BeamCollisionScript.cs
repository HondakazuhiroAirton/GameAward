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

        if (collisionObject.tag == "wall") // �Փ˕������˕���������
        {
            // ���˂�����
            Debug.Log("���ˏ����J�n");
            GameObject beamParticle = transform.parent.gameObject; // �p�[�e�B�N��1�̃Q�[���I�u�W�F�N�g���擾����
            //beamParticle.gameObject.ParticleCollision();
        }
    }
}


// ����
// �e�q�֌W�擾�̃A���R��
//�gtransform.root.gameObject�h�͈�Ԑe�̃I�u�W�F�N�g���擾
//�gtransform.parent.gameObject�h�͈��̃I�u�W�F�N�g���擾
