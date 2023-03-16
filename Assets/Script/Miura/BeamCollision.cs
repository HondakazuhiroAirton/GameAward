using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamCollision : MonoBehaviour
{
    // �r�[���p�[�e�B�N���I�u�W�F�N�g
    public GameObject BeamParticle;
    // �r�[�����i�ޕ���
    public Vector3 ParticlemoveDir;
    // �r�[���̉�]�p
    public float ParticleAngle;
    // �r�[���̈ړ��X�s�[�h
    public float ParticleSpeed = 0.1f;

    // �����蔻��̏����ʒu�ۑ�
    protected Vector3 startPosition;
    // �p�[�e�B�N���̃|�W�V�����ۑ�
    protected Vector3 beamParticlePosition;
    // ��]�␳�l
    protected float AngleHosei = 45; 

    // Start is called before the first frame update
    void Start()
    {
        // �r�[���p�[�e�B�N������r�[���̐i�s���������炤
        ParticlemoveDir = BeamParticle.GetComponent<BeamParticleScript>().moveDir;

        // �r�[���p�[�e�B�N������r�[���̉�]�����������炤
        ParticleAngle = BeamParticle.GetComponent<BeamParticleScript>().Angle;

        // �X�s�[�h�l
        //ParticleSpeed = 0.1f;

        // �����ʒu�擾
        startPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // �������傫���Ȃ�
        this.GetComponent<BoxCollider>().size += new Vector3 (0.0f, ParticleSpeed, 0.0f);
        
        // �␳�l����
        float xSize = this.GetComponent<BoxCollider>().size.x;
        float ySize = this.GetComponent<BoxCollider>().size.y;
        float zSize = this.GetComponent<BoxCollider>().size.z;

        // 1.BoxCollider�̈ʒu����
        // ���t���[���p�[�e�B�N���̈ʒu�����炤(���̏����d������)
        beamParticlePosition = BeamParticle.transform.position;

        // �J�n�ʒu�ƃr�[���̌��ݒl��/2���Ĉړ��ʂ��o��
        Vector3 collisionPosition;
        collisionPosition = beamParticlePosition - startPosition;
        collisionPosition = collisionPosition / 2;
        Debug.Log("�^�񒆂̒l��" + collisionPosition + "�ł��ɂ��B");

        // �X�^�[�g�|�W�V�����Ɉړ��ʂ𑫂��ă|�W�V�������o��
        collisionPosition = startPosition + collisionPosition;
        // �ʒu�𔽉f(��������)
         this.transform.position = collisionPosition;

        // ��]�𔽉f(��������)
        this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, ParticleAngle - AngleHosei);
    }
}
