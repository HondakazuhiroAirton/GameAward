using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Beam")
        {
            // BoxCast�̃X�e�C�g���~�߂�
            // �Ԃ����Ă����I�u�W�F�N�g�̐e�I�u�W�F�N�g���擾
            GameObject Parent = other.transform.root.gameObject;

            // �q�I�u�W�F�N�g�̐����擾
            int childCount = Parent.transform.childCount;

            // 0����X�^�[�g�Ȃ̂�-1����
            childCount--;

            // ��ԐV����BoxCast���擾
            GameObject NewBoxCast = Parent.transform.GetChild(childCount).gameObject;

            // ��ԍŐV��BoxCast��State.SCALE_STAY�ɂ���
            NewBoxCast.GetComponent<BoxCastScript>().NowState = BoxCastScript.State.SCALE_STAY;

            // ��s����Particle���A�N�e�B�u�ɂ���
            other.gameObject.SetActive(false);

        }
    }
}
