// BeamCollision�̃X�N���v�g���g���A
// ���˂ŏo�������铖���蔻��v���n�u�ɂ���X�N���v�g

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamCollisionReflect : MonoBehaviour
{
    // BeamManager�I�u�W�F�N�g������ϐ�
    private GameObject beamManager;
    // BeamParticle�I�u�W�F�N�g������ϐ�
    private GameObject beamParticle;

    // Start is called before the first frame update
    void Start()
    {
        // �o�����󔒂ɂȂ��Ă��܂�BeamCollision��[public GameObject BeamParticle]�ϐ����O���������Ă�����********

        // BeamManager�I�u�W�F�N�g�擾(BeamCollisionReflect���猩�Đe)
        beamManager = transform.parent.gameObject;

        // BeamParticle�I�u�W�F�N�g�擾(BeamManager�I�u�W�F�N�g���猩��0�Ԗڂ̎q)
        beamParticle = beamManager.transform.GetChild(0).gameObject;

        // �X�N���v�g���BeamParticle�Ɏ擾����BeamParticle�I�u�W�F�N�g��������
        this.gameObject.GetComponent<BeamCollision>().BeamParticle = beamParticle;

    }

    // Update is called once per frame
    void Update()
    {
    }
}
