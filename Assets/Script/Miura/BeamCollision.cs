using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BeamCollision : MonoBehaviour
{

    // ��Ԃ�\���񋓑�
    public enum State
    {
        SCALE_UP = 0,
        SCALE_DOWN,

        SCALE_STATE_MAX
    }

    // �r�[���p�[�e�B�N���I�u�W�F�N�g
    public GameObject BeamParticle;
    // �r�[�����i�ޕ���
    public Vector3 ParticlemoveDir;
    // �r�[���̉�]�p
    public float ParticleAngle;
    // �r�[���̈ړ��X�s�[�h
    public float ParticleSpeed = 0.1f;

    // �����蔻��̏����ʒu�ۑ�
    private Vector3 startPosition;
    // �p�[�e�B�N���̃|�W�V�����ۑ�
    private Vector3 beamParticlePosition;
    // ��]�␳�l
    private float AngleHosei = 90;
    // ���݂̏�ԕۑ�(�傫���Ȃ��Ԃ�/�������Ȃ��Ԃ�)
    private State collisionState;

    // Start is called before the first frame update
    void Start()
    {
        // �r�[���p�[�e�B�N���̃X�N���v�g���擾
        var beamParticleScript = BeamParticle.GetComponent<BeamParticleScript>();

        // �r�[���p�[�e�B�N������r�[���̐i�s���������炤
        ParticlemoveDir = beamParticleScript.moveDir;

        // �r�[���p�[�e�B�N������r�[���̉�]�����������炤
        ParticleAngle = beamParticleScript.Angle;
        // �␳�l������
        ParticleAngle = ParticleAngle - AngleHosei;

       // �X�s�[�h�l
        ParticleSpeed = beamParticleScript.Speed;

        // �����ʒu�擾
        startPosition = this.transform.position;

        // �ŏ��͊g����
        collisionState = State.SCALE_UP;

        Debug.Log(ParticlemoveDir);
    }

    // Update is called once per frame
    void Update()
    {
        // �����蔻��̈ʒu���v�Z���邽�߂̕ϐ�
        Vector3 collisionPosition = new Vector3(0, 0, 0);
        // �␳�l����
        float xSize = this.GetComponent<BoxCollider>().size.x;
        float ySize = this.GetComponent<BoxCollider>().size.y;
        float zSize = this.GetComponent<BoxCollider>().size.z;



        switch (collisionState)
        {
            case State.SCALE_UP:
                // �������傫���Ȃ�
                this.GetComponent<BoxCollider>().size += new Vector3(0.0f, ParticleSpeed, 0.0f);

                // 1.BoxCollider�̈ʒu����
                // ���t���[���p�[�e�B�N���̈ʒu�����炤(���̏����d������)
                beamParticlePosition = BeamParticle.transform.position;

                // �J�n�ʒu�ƃr�[���̌��ݒl��/2���Ĉړ��ʂ��o��
                collisionPosition = beamParticlePosition - startPosition;
                collisionPosition = collisionPosition / 2;
                break;

            case State.SCALE_DOWN:
                // �������������Ȃ�
                this.GetComponent<BoxCollider>().size -= new Vector3(0.0f, ParticleSpeed, 0.0f);

                // �J�n�ʒu�ƃr�[���̌��ݒl��/2���Ĉړ��ʂ��o��
                collisionPosition = beamParticlePosition - startPosition;
                collisionPosition = collisionPosition / 2;
                // �J�n�ʒu����������
                startPosition = startPosition + ParticlemoveDir;

                // �J�n�ʒu�ƃr�[���̃|�W�V�������ꏏ�ɂȂ�����
                if (startPosition == beamParticlePosition)
                {
                    // ���̃I�u�W�F�N�g���f�X�g���C����
                    Destroy(this.gameObject);
                }

                Debug.Log(ParticlemoveDir);

                break;
        }

        // �X�^�[�g�|�W�V�����Ɉړ��ʂ𑫂��ă|�W�V�������o��
        collisionPosition = startPosition + collisionPosition;
        // �ʒu�𔽉f
        this.transform.position = collisionPosition;

        // ��]�𔽉f
        this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, ParticleAngle);
    }

    private void OnTriggerEnter(Collider other)
    {
        // ���˕��ɂ��������ꍇ
        if (other.gameObject.tag == "Reflector")
        {
            Debug.Log("�k�ނ�");
            // �k�ޏ�Ԃɂ���
            collisionState = State.SCALE_DOWN;
            // �r�[���p�[�e�B�N������r�[���̐i�s���������炤
            ParticlemoveDir = BeamParticle.GetComponent<BeamParticleScript>().moveDir;
        }
    }

    // �C���^�[�t�F�X����肭�g���ĂȂ�
    public void CreateParticleEvent(GameObject obj,float angle)
    {
        Instantiate(this, this.transform.position,Quaternion.Euler(0.0f, 0.0f, angle - AngleHosei));
    }
}
