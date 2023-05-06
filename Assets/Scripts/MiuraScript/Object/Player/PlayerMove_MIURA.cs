using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMove_MIURA : MonoBehaviour
{
    // public�]�[��**************************************************************
    public float speed; //�v���C���[�̃X�s�[�h 

    // �r�[���̍ő嗭�ߎ���*************************
    public float MaxChargeTime = 8;// ������2�ʂ܂œ��͂����Ɖ�����

    // �r�[���̏��B(public��)********************************
    // Lv0
    public float Lv0_Scale;
    public float Lv0_Distance;
    public float Lv0_Use;
    // Lv1
    public float Lv1_Scale;
    public float Lv1_Distance;
    public float Lv1_Use;
    // Lv2
    public float Lv2_Scale;
    public float Lv2_Distance;
    public float Lv2_Use; 
    // Lv3
    public float Lv3_Scale;
    public float Lv3_Distance;
    public float Lv3_Use;
    // Lv4
    public float Lv4_Scale;
    public float Lv4_Distance;
    public float Lv4_Use;

    //���[�v�t���O�p
    public bool Up;
    public bool Down;
    public bool Right;
    public bool Left;

    // private�]�[��*************************************************************
    // �r�[����1�i�K�̎���*************************
    private int OneChargeFrame;
    // �r�[���ő嗭�ߎ���
    private float MaxFrame;

    // �ړ��o�[
    private GameObject wallUp;
    private GameObject wallDown;
    private GameObject wallLeft;
    private GameObject wallRight;

    // �o�[�̏��B**************************************
    private Vector3 Upos;        //��̈ʒu
    private Vector3 UScale;      //��̃X�P�[��
    private Vector3 Dpos;        //���̈ʒu
    private Vector3 DScale;      //���̃X�P�[��
    private Vector3 Rpos;        //�E�̈ʒu
    private Vector3 RScale;      //�E�̃X�P�[��
    private Vector3 Lpos;        //���̈ʒu
    private Vector3 LScale;      //���̃X�P�[��

    private float URpos;
    private float ULpos;
    private float DRpos;
    private float DLpos;
    private float RRpos;
    private float RLpos;
    private float LRpos;
    private float LLpos;

    private Vector3 pos; // �v���C���[�̃|�W�V�����擾
    private Vector3 Scale; // �v���C���[�̑傫���擾


    // �r�[���̏��B********************************
    // �v���C���[�f�[�^�ۑ��p�I�u�W�F�N�g�擾
    private GameObject PlayerDate;
    // Geter/Seter�p�X�N���v�g�ۑ�
    private PlayerClass PlayerClassScript;

    // �v���n�u�i�[�p
    private GameObject BeamParticleManagerPrefab;

    // �`���[�W�������Ԃ��i�[����ϐ�(�K�v)
    private int ChargeTime = 0;

    // ����r�[���v���n�u�i�[
    private GameObject BigBeamPrefabs;

    // ���̃I�u�W�F�N�g�̃A�j���[�^�[
    [SerializeField]Animator animator;

    //********************************************************************************

    void Start()
    {
        // �A�j���[�^�[���擾
        animator = this.GetComponent<Animator>();

        // �r�[�����ߎ��Ԍv�Z********************************************
        // ���͂��ꂽ�ő嗭�ߎ��Ԃ̒P�ʂ�b����t���[���ɕύX
        MaxFrame = MaxChargeTime * 60;

        // ������2�ʂ܂œ��͂����Ɖ�����
        // 1������̗��ߎ��Ԃɕϊ�
        OneChargeFrame = (int)MaxFrame / 5;

        // �e��o�[�擾
        wallUp = GameObject.Find("UP");
        wallDown = GameObject.Find("Down");
        wallLeft = GameObject.Find("Left");
        wallRight = GameObject.Find("Right");

        //WallUp�̒[�擾
        Upos = wallUp.gameObject.transform.position;
        UScale = wallUp.gameObject.transform.localScale;
        URpos = Upos.x + UScale.x / 2;
        ULpos = Upos.x - UScale.x / 2;

        //WallDown�̒[�擾
        Dpos = wallDown.gameObject.transform.position;
        DScale = wallDown.gameObject.transform.localScale;
        DRpos = Dpos.x + DScale.x / 2;
        DLpos = Dpos.x - DScale.x / 2;

        //WallRight�̒[�擾
        Rpos = wallRight.gameObject.transform.position;
        RScale = wallRight.gameObject.transform.localScale;
        RRpos = Rpos.y + RScale.y / 2;
        RLpos = Rpos.y - RScale.y / 2;

        //WallLeft�̒[�擾
        Lpos = wallLeft.gameObject.transform.position;
        LScale = wallLeft.gameObject.transform.localScale;
        LRpos = Lpos.y + LScale.y / 2;
        LLpos = Lpos.y - LScale.y / 2;

        this.gameObject.transform.position = new Vector3(Upos.x, Upos.y, Upos.z - 1);

        //wall�F�ύX
        wallUp.GetComponent<Renderer>().material.color = Color.red;
        wallDown.GetComponent<Renderer>().material.color = Color.red;
        wallRight.GetComponent<Renderer>().material.color = Color.red;
        wallLeft.GetComponent<Renderer>().material.color = Color.red;

        SetWallFlag(0, true);
        SetWallFlag(1, true);
        SetWallFlag(2, false);
        SetWallFlag(3, true);

        //0402_�O�Y�u�ǋL****************************************************************

        // �`���[�W�������Ԃ𒙂߂�
        ChargeTime = 0;
        // �r�[����Resources����擾
        BeamParticleManagerPrefab = Resources.Load<GameObject>("BeamParticleManager");

        // ����r�[����Resources����擾
        BigBeamPrefabs = Resources.Load<GameObject>("BigBeam");

        // �r�[���c�ʂւ̃A�N�Z�X
        //PlayerDate�����Ă���
        PlayerDate = GameObject.Find("PlayerDate");

        //Geter / Seter�g�p�p�X�N���v�g�ێ�
        PlayerClassScript = PlayerDate.GetComponent<PlayerClass>();

        //�r�[���c�ʂ�100 % �ɐݒ�
        PlayerClassScript.SetAmount(100);

    }


    void Update()
    {
        //�v���C���[�̍��W�擾
        pos = this.gameObject.transform.position;
        //�v���C���[�̃X�P�[���擾
        Scale = this.gameObject.transform.localScale;

        // q�{�^���������Ă���ƒx���Ȃ�
        float DownSpeed = 1.0f;
        if (Input.GetKey("q"))
        {
            DownSpeed = 0.1f;
        }


        //<<<��̃��C���ړ�>>>
        if (pos.y == Upos.y)
        {

            pos.y = Upos.y;

            //���C���O�ɂ����Ȃ�����
            if (pos.x >= URpos - Scale.x / 2)
            {
                pos.x = URpos - Scale.x / 2;
            }
            else if (pos.x <= ULpos + Scale.x / 2)
            {
                pos.x = ULpos + Scale.x / 2;
            }

            //d���͂ŉE�����ɓ���
            if (Input.GetKey("d"))
            {
                this.gameObject.transform.position = new Vector3(pos.x + speed * DownSpeed, pos.y, pos.z);
            }
            //a���͂ō������ɓ���
            else if (Input.GetKey("a"))
            {
                this.gameObject.transform.position = new Vector3(pos.x - speed * DownSpeed, pos.y, pos.z);
            }

        }
        // <<<���̃��C���ړ�>>>
        if (pos.y == Dpos.y)
        {

            pos.y = Dpos.y;

            //���C���O�ɂ����Ȃ�����
            if (pos.x >= DRpos - Scale.x / 2)
            {
                pos.x = DRpos - Scale.x / 2;
            }
            else if (pos.x <= DLpos + Scale.x / 2)
            {
                pos.x = DLpos + Scale.x / 2;
            }

            //d���͂ŉE�����ɓ���
            if (Input.GetKey("d"))
            {
                this.gameObject.transform.position = new Vector3(pos.x + speed * DownSpeed, pos.y, pos.z);
            }
            //a���͂ō������ɓ���
            else if (Input.GetKey("a"))
            {
                this.gameObject.transform.position = new Vector3(pos.x - speed * DownSpeed, pos.y, pos.z);
            }

        }
        // <<<�E�̃��C���ړ�>>>
        if (pos.x == Rpos.x)
        {

            pos.x = Rpos.x;

            //���C���O�ɂ����Ȃ�����
            if (pos.y >= RRpos - Scale.y / 2)
            {
                pos.y = RRpos - Scale.y / 2;
            }
            else if (pos.y <= RLpos + Scale.y / 2)
            {
                pos.y = RLpos + Scale.y / 2;
            }

            //w���͂ŏ�����ɓ���
            if (Input.GetKey("w"))
            {
                this.gameObject.transform.position = new Vector3(pos.x, pos.y + speed * DownSpeed, pos.z);
            }
            //s���͂ŉ������ɓ���
            else if (Input.GetKey("s"))
            {
                this.gameObject.transform.position = new Vector3(pos.x, pos.y - speed * DownSpeed, pos.z);
            }

        }
        //<<<���̃��C���ړ�>>>
        if (pos.x == Lpos.x)
        {

            pos.x = Lpos.x;

            //���C���O�ɂ����Ȃ�����
            if (pos.y >= LRpos - Scale.y / 2)
            {
                pos.y = LRpos - Scale.y / 2;
            }
            else if (pos.y <= LLpos + Scale.y / 2)
            {
                pos.y = LLpos + Scale.y / 2;
            }

            //w���͂ŏ�����ɓ���
            if (Input.GetKey("w"))
            {
                this.gameObject.transform.position = new Vector3(pos.x, pos.y + speed * DownSpeed, pos.z);
            }
            //s���͂ŉ������ɓ���
            else if (Input.GetKey("s"))
            {
                this.gameObject.transform.position = new Vector3(pos.x, pos.y - speed * DownSpeed, pos.z);
            }

        }

        //���[�v
        if (Up == true)
        {
            //�F�ύX
            wallUp.GetComponent<Renderer>().material.color = Color.green;
            if (Input.GetKey("1"))//��
            {
                this.gameObject.transform.position = new Vector3(Upos.x, Upos.y, Upos.z - 1);
                this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
        if (Down == true)
        {
            //�F�ύX
            wallDown.GetComponent<Renderer>().material.color = Color.green;
            if (Input.GetKey("2"))//��
            {
                this.gameObject.transform.position = new Vector3(Dpos.x, Dpos.y, Dpos.z - 1);
                this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
            }
        }
        if (Right == true)
        {
            //�F�ύX
            wallRight.GetComponent<Renderer>().material.color = Color.green;
            if (Input.GetKey("3"))//�E
            {
                this.gameObject.transform.position = new Vector3(Rpos.x, Rpos.y, Rpos.z - 1);
                this.gameObject.transform.rotation = Quaternion.Euler(0, 0, -90);
            }
        }
        if (Left == true)
        {
            //�F�ύX
            wallLeft.GetComponent<Renderer>().material.color = Color.green;
            if (Input.GetKey("4"))//��
            {
                this.gameObject.transform.position = new Vector3(Lpos.x, Lpos.y, Lpos.z - 1);
                this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
            }
        }

        //0329_�O�Y�u�ǋL****************************************************************


        // �A�j���[�^�[�ʏ��Ԃ�False
        animator.SetBool("fCharge", false);

        // �r�[�����ˏ���*************************************************************
        if (Input.GetKey(KeyCode.Space)) // �L�[�R�[�h�͕ύX���Ă�(*^^*)
        {
            // �A�j���[�^�[���邮���Ԃ�True
            animator.SetBool("fCharge",true);

            // ���t���[��1�������Ƃɂ���Ď��Ԃ�}��
            ChargeTime = ChargeTime + 1; 

            // �ő�l�ݒ� ���o�O��Ȃ炱�̕ς��H�H�H�H
            if (ChargeTime >= MaxFrame)
            {
                ChargeTime = (int)(MaxFrame + 1);
            }
            
            // ���Ԃɂ���ĕς��(臒l)
            if (0 <= ChargeTime && ChargeTime < OneChargeFrame) // 1�i�K��
            {
                Debug.Log("1�i�K�ڂ̃`���[�W");
            }
            else if (OneChargeFrame <= ChargeTime && ChargeTime < 2 * OneChargeFrame)// 2�i�K��
            {
                Debug.Log("2�i�K�ڂ̃`���[�W");
            }
            else if (2 * OneChargeFrame <= ChargeTime && ChargeTime < 3 * OneChargeFrame)// 3�i�K��
            {
                Debug.Log("3�i�K�ڂ̃`���[�W");
            }
            else if (3 * OneChargeFrame <= ChargeTime && ChargeTime < 4 * OneChargeFrame)// 4�i�K��
            {
                Debug.Log("4�i�K�ڂ̃`���[�W");
            }
            else if (4 * OneChargeFrame <= ChargeTime)// 5�i�K��
            {
                Debug.Log("5�i�K�ڂ̃`���[�W");
            }
        }

        if (Input.GetKeyUp(KeyCode.Space)) // Down�Ɠ����L�[�R�[�h�ɂ��Ă�
        {
            // �v���������Ԃ���e��l���v�Z����
            float use = 0;
            float BoxCastScale = 0;
            float Distance = 0;
            int BeamLevel = 0;
            // �`���[�W�������Ԃɂ���ăr�[���̑傫�����ς��T�C�Y�ύX�p�̕ϐ�

            // ���Ԃɂ���ĕς��(臒l)
            if (0 <= ChargeTime && ChargeTime < OneChargeFrame) // ���`���[�W
            {
                // 1.�T�C�Y������
                BoxCastScale = Lv0_Scale;
                // 2.�ő�򋗗�����������
                Distance = Lv0_Distance;
                // 3.����G�l���M�[�����߂�
                use = Lv0_Use;
                // �r�[���̎�ނ�������
                BeamLevel = 0;
            }
            else if(OneChargeFrame <= ChargeTime && ChargeTime < 2 * OneChargeFrame)// 1�K��
            {
                // 1.�T�C�Y������
                BoxCastScale = Lv1_Scale;
                // 2.�ő�򋗗�����������
                Distance = Lv1_Distance;
                // 3.����G�l���M�[�����߂�
                use = Lv1_Use;
                // �r�[���̎�ނ�������
                BeamLevel = 1;
            }
            else if (2 * OneChargeFrame <= ChargeTime && ChargeTime < 3 * OneChargeFrame)// 2�i�K��
            {
                // 1.�T�C�Y������
                BoxCastScale = Lv2_Scale;
                // 2.�ő�򋗗�����������
                Distance = Lv2_Distance;
                // 3.����G�l���M�[�����߂�
                use = Lv2_Use;
                // �r�[���̎�ނ�������
                BeamLevel = 2;
            }
            else if (3 * OneChargeFrame <= ChargeTime && ChargeTime < 4 * OneChargeFrame)// 3�i�K��
            {
                // 1.�T�C�Y������
                BoxCastScale = Lv3_Scale;
                // 2.�ő�򋗗�����������
                Distance = Lv3_Distance;
                // 3.����G�l���M�[�����߂�
                use = Lv3_Use;
                // �r�[���̎�ނ�������
                BeamLevel = 3;
            }
            else if (4 * OneChargeFrame <= ChargeTime )// 4�i�K��
            {
                // 1.�T�C�Y������
                BoxCastScale = Lv4_Scale;
                // 2.�ő�򋗗�����������
                Distance = Lv4_Distance;
                // 3.����G�l���M�[�����߂�
                use = Lv4_Use;
                // �r�[���̎�ނ�������
                BeamLevel = 4;
            }

            // ���炷
            // �r�[���c�ʎ擾
            float tempCharge = PlayerClassScript.GetAmount();

            // �c�ʂ������
            if ((tempCharge = tempCharge - use) > 0)
            {
                // �r�[���c�ʂ����炵��
                tempCharge = tempCharge - use;
                // �v���C���[�f�[�^�I�u�W�F�N�g�̃r�[���c��(Amount)���X�V����
                PlayerClassScript.SetAmount(tempCharge);

                // �r�[���}�l�[�W���[�̒���BoxCast���擾
                GameObject BoxCast = BeamParticleManagerPrefab.gameObject.transform.GetChild(1).gameObject;

                // �v���C���[�̊p�x��BeamParticle�ɑ������
                // BeamParticle�擾
                GameObject BeamParticleManager = BeamParticleManagerPrefab.gameObject.transform.GetChild(0).gameObject;

                // �v���C���[��Z�����Q�l�ɂ���
                float PlayerAngle = this.transform.localEulerAngles.z;

                // BeamEffectScript���L���b�V��***********************************************************************�v�����������
                BeamParticleScript script = BeamParticleManager.GetComponent<BeamParticleScript>();

                // BeamParticle��Effect�p�x���X�V����
                script.PlayerAngle = PlayerAngle;

                // BeamParticle�̊p�x��ύX����
                script.Angle = PlayerAngle - 90;

                // BeamParticle��BeamMax��ύX����
                script.BeamMax = Distance;

                // BeamParticle�̂�ύX����
                script.BeamMax = Distance;

                // BeamParticle�̃`���[�W�i�K��n��
                script.NowBeamLevel = BeamLevel;

                // �v���n�u���w��ʒu�ɐ���
                Instantiate(BeamParticleManagerPrefab, this.transform.position, gameObject.transform.localRotation);
                // �`���[�W���Ԃ�߂�
                ChargeTime = 0;
            }
        }

        // �r�[�����ˏ���(�����܂�)*****************************************************************

        // ����r�[�����ˏ���(��������)*************************************************************
        if (Input.GetKeyUp(KeyCode.K)) // Down�Ɠ����L�[�R�[�h�ɂ��Ă�
        {
            // �v���n�u���w��ʒu�ɐ���
            Instantiate(BigBeamPrefabs, this.transform.position, gameObject.transform.localRotation);
        }

    }
    //wall�g�p�t���O
    void SetWallFlag(int num, bool flag)
    {
        switch (num)
        {
            case 0: { Up = flag; break; }
            case 1: { Down = flag; break; }
            case 2: { Right = flag; break; }
            case 3: { Left = flag; break; }

        }

    }
}