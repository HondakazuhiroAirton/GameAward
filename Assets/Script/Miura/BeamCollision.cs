using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamCollision : MonoBehaviour
{
    // �r�[�����i�ޕ���
    public Vector3 ParticlemoveDir;
    // �r�[���̉�]�p
    public float ParticleAngle;
    // �r�[���̈ړ��X�s�[�h
    public float ParticleSpeed = 0.1f;

    // �����ʒu�ۑ�
    protected Vector3 startPosition;
    // ��]�␳�l
    protected float AngleHosei = 90; 

    // Start is called before the first frame update
    void Start()
    {
        // �r�[���p�[�e�B�N������r�[���̐i�s���������炤
        ParticlemoveDir = transform.parent.GetComponent<BeamParticleScript>().moveDir;

        // �r�[���p�[�e�B�N������r�[���̉�]�����������炤
        ParticleAngle = transform.parent.GetComponent<BeamParticleScript>().Angle;

        // �X�s�[�h�l
        //ParticleSpeed = 0.1f;

        // �����ʒu������Ă���
        startPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<BoxCollider>().size += new Vector3 (0.0f,0.1f,0.0f);
        
        // �␳�l����
        float xSize = this.GetComponent<BoxCollider>().size.x;
        float ySize = this.GetComponent<BoxCollider>().size.y;
        float zSize = this.GetComponent<BoxCollider>().size.z;

        // BoxCollider�T�C�Y�̔��������ɖ߂��ĕ␳
        this.transform.position = startPosition + new Vector3 (xSize / 2,ySize / 2 ,zSize / 2);

        // ��]�𔽉f
        this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, ParticleAngle - AngleHosei);
    }
}
