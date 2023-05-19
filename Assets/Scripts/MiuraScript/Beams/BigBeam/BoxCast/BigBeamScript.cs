using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Effekseer;

public class BigBeamScript : MonoBehaviour
{    //  ���C���[�}�X�N
    public LayerMask LayerMask;

    // 
    public float PlayerAngle;

    // �r�[���̎���
    public int StopTime = 270;

    // �v���C���[�I�u�W�F�N�g
    private PlayerMove_MIURA playerScript;
    // BoxCast�����i�[
    private RaycastHit[] hit;
    // BoxCast�̑傫��������ϐ�
    private float scale;
    // BoxCast��Max�̒���
    public float maxDistance = 10.0f;
    // �����I�u�W�F�N�g�ɂԂ����Ă��邩�ǂ���
    RaycastHit[] isHit;
    // �{�b�N�X�L���X�g�̕����x�N�g��
    public Vector3 boxCastVecor;

    [SerializeField] bool isEnable = true; // �M�Y���ɐ���\�����邩�ǂ���

    // �G�t�F�N�V�A�p�֐��A���R��
    // �Đ�����A�Z�b�g�z��
    private EffekseerEffectAsset effect;
    // �n���h��
    private EffekseerHandle handle;
    // �G�t�F�N�g�̉�]�v�Z
    private Quaternion EffectRot;




    void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerMove_MIURA>();

        // ����r�[���G�t�F�N�g���n�߂�
        effect = Resources.Load<EffekseerEffectAsset>("BigBeam");
        handle = EffekseerSystem.PlayEffect(effect, transform.position);
        EffectRot = Quaternion.Euler(0.0f,0.0f,PlayerAngle);
        handle.SetRotation(EffectRot);
    }

    void Update()
    {
        // �傫������
        scale = transform.lossyScale.x * 0.5f;

        // �r�[���G�t�F�N�g�̎��Ԃ��I���܂�BoxCollider�������Ƃ�
        StopTime--;

        // �r�[���̃G�t�F�N�g���I�������
        if (StopTime < 0)
        {
            // BigBeam������
            Destroy(this.gameObject);
        }

        // BoxCast���΂� �@�@�@�@�ꏊ                  �傫��             ����(�x�N�g��)              ��]����?  
        isHit = Physics.BoxCastAll(transform.position, Vector3.one * scale, boxCastVecor, Quaternion.identity, maxDistance, LayerMask);
        //                                                                                �����������I�u�W�F�N�g�������Ɋi�[  

        // BoxCast�ɂ��������I�u�W�F�N�g�̏���
        foreach (var obj in isHit)
        {
            GameObject hitObject = obj.collider.gameObject;
            // �C���^�[�t�F�X�œn����
            hitObject.GetComponent<CollisionAction>().CollisionEvent(this.gameObject);
        }
    }
    void OnDrawGizmos()
    {
        // �������邩�ǂ���
        if (isEnable == false) return;

        // ������܂Ő���`����
        Gizmos.DrawRay(transform.position, boxCastVecor * maxDistance);
        // �Ԃ������Ƃ����Box�𓯂��傫���ŕ`��
        Gizmos.DrawWireCube(transform.position + boxCastVecor * maxDistance, Vector3.one * scale * 2);
    }
}
