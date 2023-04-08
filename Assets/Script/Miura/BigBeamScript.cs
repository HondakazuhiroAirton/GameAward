using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBeamScript : MonoBehaviour
{
    // public�]�[��*****************************************************
    // �傫��
    public float Scale;

    // �p�x
    public float Angle;

    // 1�t���[���ɐL�т��
    public float move = 2;

    // �傫���Ȃ�X�s�[�h
    public float Speed;

    // BoxCast�̏I�_
    public Vector3 EndPosition;

    // BoxCast�̍ő勗��
    public float MaxDistance = 50;

    // �r�[�����i�ޕ����x�N�g��
    public Vector3 Direction;

    // �v���C���[�I�u�W�F�N�g�ۑ�
    public GameObject Player;

    // private�]�[��*****************************************************

    // BoxCast�����i�[
    private RaycastHit hit;

    // BoxCast��Max�̒���
    private float maxDistance;

    // �����I�u�W�F�N�g�ɂԂ����Ă��邩�ǂ���
    bool isHit;

        [SerializeField] 
    bool isEnable = false; // �M�Y���ɐ���\�����邩�ǂ���

    void Start()
    {
        this.transform.position = Player.transform.position;
        // ������
        EndPosition = this.transform.position;
        Direction = new Vector3(1.0f,0.0f,0.0f);
        Direction = Direction.normalized;


    }

    void Update()
    {
        this.transform.position = Player.transform.position;

        // BoxCast�v�Z�]�[��*************************************************************************
        // �����蔻��̑傫��->���̑傫���̔����̈�����n���K�v�����邽��*0.5���Ă���
        Scale = transform.lossyScale.x * 0.5f;
        Vector3 BoxCastPosition = this.transform.position;



        
        // �r�[���̒��������ȏ�ɂȂ�����
        if (Vector3.Distance(EndPosition, transform.position) >= MaxDistance)
        {
            // �������Ȃ�
        }
        else
        {
            // �L�т��������傫������
            EndPosition.x = EndPosition.x + move;
        }

        // �v���C���[���Q�Ƃ��Ċp�x�ƐL�т����߂�

        // 2�_�Ԃ̋��������߂�
        maxDistance = Mathf.Pow((EndPosition.x - BoxCastPosition.x), 2.0f) +
                       Mathf.Pow((EndPosition.y - BoxCastPosition.y), 2.0f) +
                        Mathf.Pow((EndPosition.z - BoxCastPosition.z), 2.0f);

        // ��������[�g�ɂ���
        maxDistance = Mathf.Sqrt(maxDistance);

        // BoxCast���΂� �@�@�@�@�ꏊ                  �傫��             ����(�x�N�g��)              ��]����?  
        isHit = Physics.BoxCast(transform.position, Vector3.one * Scale, Direction, out hit, Quaternion.identity, maxDistance);
        //                                                                                �����������I�u�W�F�N�g�������Ɋi�[  

        // BoxCast�ɂ��������I�u�W�F�N�g�̏���
        if (isHit == true)
        {
            GameObject hitObject = hit.collider.gameObject;

            // �������̏����̓C���^�[�t�F�X�œn����Enemy���ō������������
            Destroy(hitObject);

        }
    }

    // �M�Y���Ń{�b�N�X�L���X�g�����ڂ�\��
    void OnDrawGizmos()
    {
        // �������邩�ǂ���
        if (isEnable == false) return;

        // ������܂Ő���`����
        Gizmos.DrawRay(transform.position, Direction * maxDistance);
        // �Ԃ������Ƃ����Box�𓯂��傫���ŕ`��
        Gizmos.DrawWireCube(transform.position + Direction * maxDistance, Vector3.one * Scale * 2);

    }
}
