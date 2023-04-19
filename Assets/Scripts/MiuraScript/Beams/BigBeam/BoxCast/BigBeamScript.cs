using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBeamScript : MonoBehaviour
{
    // BoxCast�����i�[
    private RaycastHit hit;

    // �r�[���̍Œ�
    public float BeamMax;

    // �ړ���
    public float Movement = 0.01f;

    //  ���C���[�}�X�N(�g��Ȃ�����)
    public LayerMask LayerMask;

    // private�]�[��*****************************************************
    // �����I�u�W�F�N�g�ɂԂ����Ă��邩�ǂ���
    private bool isHit;

    // BoxCast�̑傫��������ϐ�
    private float scale;

    // BoxCast��Max�̒���
    private float maxDistance = 1.0f;

    // �ړ����ĐL�тĂ�����̃|�W�V����
    private Vector3 MaxPosition;

    // �ړ��x�N�g��
    private Vector3 moveVector;

    // �ړ��x�N�g��
    private Vector3 moveDir = new Vector3(1.0f, 0.0f, 0.0f);

    [SerializeField] // private�����Ǖ\��
    private bool isEnable = false; // �M�Y���ɐ���\�����邩�ǂ���


    void Start()
    {
        // ���L�΂�
        moveDir = this.transform.up;
    }

    void Update()
    {
        // BoxCast�v�Z�]�[��*************************************************************************
        // �����蔻��̑傫��->���̑傫���̔����̈�����n���K�v�����邽��*0.5���Ă���
        scale = transform.lossyScale.x * 0.5f;
        Vector3 BoxCastPosition = this.transform.position;

        // �x�N�g�����v�Z����
        maxDistance += Movement;

    }
    void OnDrawGizmos()
    {
        // �������邩�ǂ���
        if (isEnable == false) return;

        // maxDistance���ɐ���`����
        Gizmos.DrawRay(transform.position, moveDir * maxDistance);
        // �Ԃ������Ƃ����Box�𓯂��傫���ŕ`��
        Gizmos.DrawWireCube(transform.position + moveDir * maxDistance, Vector3.one * scale * 2);

    }

}
