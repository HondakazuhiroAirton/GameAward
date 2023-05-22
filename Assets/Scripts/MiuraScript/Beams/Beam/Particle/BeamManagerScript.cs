using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamManagerScript : MonoBehaviour
{
    // AudioSource�R���|�[�l���g�擾
    private AudioSource audio;
    
    void Start()
    {
        // AudioSource�擾
        audio = this.GetComponent<AudioSource>();
    }

    void Update()
    {
        // �q�I�u�W�F�N�g�S�Ă���A�N�e�B�u�̎��A�}�l�[�W���[�f���[�g

        // �q�I�u�W�F�N�g�̐����擾
        int childCount = transform.childCount;

        // ��A�N�e�B�v�̐�
        int falseCount = 0;

        // �O���珇�Ɏq�I�u�W�F�N�g�̃A�N�e�B�u���m�F����
        for (int i = 0; i < childCount; i++)
        {
            // �q�I�u�W�F�N�g�����Ɏ擾����
            Transform childTransform = transform.GetChild(i);
            GameObject childObject = childTransform.gameObject;

            // �A�N�e�B�u���m�F����
            // ��A�N�e�B�u�������ꍇ
            if (childObject.activeSelf == false)
            {
                falseCount++;
            }
            else // �A�N�e�B�u�������ꍇ
            {
                // for���I���
                break;
            }

        }


        if (Time.deltaTime <= 0)
        {
            audio.enabled = false;
        }
        else
        {
            audio.enabled = true;
        }

        // �q�I�u�W�F�N�g���S����A�N�e�B�v�̏ꍇ
        if (falseCount >= childCount)
        {
            // �}�l�[�W���[�폜
            Destroy(this.gameObject);
        }
    }
}
