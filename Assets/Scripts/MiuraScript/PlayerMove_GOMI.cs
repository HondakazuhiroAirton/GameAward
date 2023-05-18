using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Effekseer;

public class PlayerMove_GOMI : MonoBehaviour
{
    // public�]�[��**************************************************************
    public float speed; //�v���C���[�̃X�s�[�h 

    // �r�[���̏��B********************************
    // �r�[���̉�����1�b�Ԃɑ傫���Ȃ�
    public float BeamExpansion = 100.0f;
    // �r�[���̍ő�̒���
    public float BeamMax = 30.0f;
    // �r�[���̒�����1�b�Ԃɑ傫���Ȃ�
    public float BeamExpansionDistance = 1f;
    // �r�[���̒����̊
    public float BeamDistanceKijun;
    // �r�[���g�p�ʂ̊
    public float UseKijun = 10;

    //���[�v�t���O�p
    public bool Up;
    public bool Down;
    public bool Right;
    public bool Left;

    // private�]�[��*************************************************************
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
    public float ChargeTime = 0.0f;



    //********************************************************************************

    void Start()
    {


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
        ChargeTime = 0.0f;

        // ��l������
        BeamDistanceKijun = 10.0f;

        // �r�[����Resources����擾
        BeamParticleManagerPrefab = Resources.Load<GameObject>("BeamParticleManager");

        // ����r�[����Resources����擾
        //BigBeamPrefabs = Resources.Load<GameObject>("BigBeam");

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
        // �r�[�����ˏ���*************************************************************
        if (Input.GetKey(KeyCode.Space)) // �L�[�R�[�h�͕ύX���Ă�(*^^*)
        {
            // ���t���[�����Ԃ��v������
            ChargeTime = ChargeTime + Time.deltaTime /*�␳�l�|����??*/;

            // �ő�l�͑�������Ȋ����ł���
            if (ChargeTime >= 30.0f)
            {
                ChargeTime = 30.0f;
            }

            // �`���[�W���̊e��l�\��
            //Debug.Log("ChargeTime��"+ChargeTime);
            //Debug.Log("�T�C�Y��"+ ChargeTime * BeamExpansion);
            //Debug.Log("�򋗗���"+ ChargeTime * BeamExpansionDistance + BeamDistanceKijun);
            //Debug.Log("�r�[������ʂ�"+ChargeTime);
        }

        if (Input.GetKeyUp(KeyCode.Space)) // Down�Ɠ����L�[�R�[�h�ɂ��Ă�
        {
            // �v���������Ԃ���e��l���v�Z����

            // �`���[�W�������Ԃɂ���ăr�[���̑傫�����ς��T�C�Y�ύX�p�̕ϐ�
            // 1.�T�C�Y���v�Z����
            float BoxCastScale = ChargeTime * BeamExpansion;

            // 2.�ő�򋗗��������v�Z����
            BeamMax = ChargeTime * BeamExpansionDistance + BeamDistanceKijun;

            // �ő�l�␳
            if (BeamMax >= 50.0f)
            {
                BeamMax = 50.0f;
            }

            // 3.����G�l���M�[�̌v�Z
            // ����ʂ��v�Z
            float use = 3 /*�ŏ��g�p�ʂ�3*/ + ChargeTime * UseKijun;

            // �ő�ʂ����߂�
            if (use >= 10)
            {
                use = 10;
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

                // �擾����BoxCast��BoxCast�X�N���v�g��(Scale)�̑傫����ύX����
                BoxCast.transform.localScale = new Vector3(BoxCastScale, BoxCastScale, BoxCastScale);

                // �v���C���[�̊p�x��BeamParticle�ɑ������
                // BeamParticle�擾
                GameObject BeamParticleManager = BeamParticleManagerPrefab.gameObject.transform.GetChild(0).gameObject;

                // �v���C���[��Z�����Q�l�ɂ���
                float PlayerAngle = this.transform.localEulerAngles.z;

                // BeamEffectScript���L���b�V��************************************************
                BeamParticleScript script = BeamParticleManager.GetComponent<BeamParticleScript>();

                // BeamParticle��Effect�p�x���X�V����
                script.PlayerAngle = PlayerAngle;

                // BeamParticle�̊p�x��ύX����
                script.Angle = PlayerAngle - 90;

                // BeamParticle��BeamMax��ύX����
                script.BeamMax = BeamMax;

                // �v���n�u���w��ʒu�ɐ���
                Instantiate(BeamParticleManagerPrefab, this.transform.position, gameObject.transform.localRotation);
                // �`���[�W���Ԃ�߂�
                ChargeTime = 0.0f;
            }
        }

        // �r�[�����ˏ���(�����܂�)*************************************************************

        // ����r�[�����ˏ���(��������)*************************************************************
        if (Input.GetKeyUp(KeyCode.K)) // Down�Ɠ����L�[�R�[�h�ɂ��Ă�
        {
            // �v���n�u���w��ʒu�ɐ���
            //Instantiate(BigBeamPrefabs, this.transform.position, gameObject.transform.localRotation);
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