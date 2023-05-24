using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using TMPro;
using Effekseer;

public class PlayerMove_MIURA : MonoBehaviour
{
    // public�]�[��**************************************************************
    public float speed; //�v���C���[�̃X�s�[�h 

    // �r�[���̍ő嗭�ߎ���*************************
    public float MaxChargeTime = 8;// ������2�ʂ܂œ��͂����Ɖ�����

    //���[�v�t���O�p
    public bool Up;
    public bool Down;
    public bool Right;
    public bool Left;

    // �r�[���̃C���^�[�o��
    public int Interbal = 60;

    // �_�Ŏ���
    public int stroboTime;

    // ���G����
    public int MutekiTime = 60;

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

    // �r�[���̏��B
    // Lv0
    private float Lv0_Scale;
    private float Lv0_Distance;
    private float Lv0_Use;
    // Lv1
    private float Lv1_Scale;
    private float Lv1_Distance;
    private float Lv1_Use;
    // Lv2
    private float Lv2_Scale;
    private float Lv2_Distance;
    private float Lv2_Use;
    // Lv3
    private float Lv3_Scale;
    private float Lv3_Distance;
    private float Lv3_Use;
    // Lv4
    private float Lv4_Scale;
    private float Lv4_Distance;
    private float Lv4_Use;

    // �r�[���̏��B********************************
    // �v���C���[�f�[�^�ۑ��p�I�u�W�F�N�g�擾
    private GameObject PlayerDate;
    // Geter/Seter�p�X�N���v�g�ۑ�
    private beamlife beamLifeScript;
    private PlayerClass PlayerClassScript;
    // Charge�p�L���L���p�[�e�B�N���V�X�e���I�u�W�F�N�g�擾
    private GameObject beamCharge;
    private charge beamChargeScript;

    // �r�[���}�l�[�W���[�̒���BoxCast���擾
    private GameObject BoxCast;

    // BeamParticle�擾
    GameObject BeamParticleManager;
    // BeamEffectScript
    BeamParticleScript script;
    // �v���n�u�i�[�p
    private GameObject BeamParticleManagerPrefab;

    // �`���[�W�������Ԃ��i�[����ϐ�(�K�v)
    private int ChargeTime = 0;

    // ����r�[���v���n�u�i�[
    private GameObject BigBeamPrefabs;

    // �r�[���̃C���^�[�o���̃}�b�N�X�l
    private int interbalMax;

    // ���̃I�u�W�F�N�g�̃A�j���[�^�[
    private Animator animator;

    // �_�łɊւ��ϐ�
    // �q�̃I�u�W�F�N�g���擾
    private MeshRenderer[] parsMesh;

    // 1��ɓ_�ł���܂ł̎���
    private int stroboOneTime;

    // �_�ŃG�t�F�N�g����bool�l
    private bool strobo;

    // �_�Ŏ��ɓ����蔻�������Ė��G�ɂ���
    private BoxCollider boxCollider;

    // ���G���Ԃ��ǂ���
    private bool muteki;

    // �_�Ŏ���
    private int stroboTimeMax;

    // ���G���Ԃ̍ő�l
    private int mutekiTimeMax;

    // ���j�G�t�F�N�g�]�[��
    // �Đ�����A�Z�b�g
    private EffekseerEffectAsset effect;
    private EffekseerEffectAsset effect2;
    // �n���h��
    private EffekseerHandle handle;
    // �G�t�F�N�g�̉�]�v�Z
    private Quaternion EffectRot;

    // ���E�\�[���[
    private GameObject rightSolar;
    private GameObject leftSolar;

    //********************************************************************************

    //�Q�[���p�b�h
    [SerializeField] PlayerInput input;
    private bool _isPressed;
    private bool _ismoveR;
    private bool _ismoveL;
    private bool _ismoveU;
    private bool _ismoveD;

    // �v���C���[�̌��̈ʒu�ۑ�
    private Vector3 beforePos ;
    // �O�̃A���O��
    private Quaternion beforeAngle;
    
    // ��**************************************************************
    private AudioSource beamChatgeAudio; // �r�[���̃`���[�W��

    // �I�[�f�B�I�N���b�v
    private AudioClip charge;
    private AudioClip explosion1;
    private AudioClip explosion2;

    void Start()
    {
        // ���[�v�O�ʒu�ۑ�
        beforePos = new Vector3(0.0f, 0.0f, 0.0f);

        // ���E�\�[���[�L���b�V��
        rightSolar = GameObject.Find("RightSolar");
        leftSolar = GameObject.Find("LeftSolar");

        // ���j�G�t�F�N�g�L���b�V��
        effect = Resources.Load<EffekseerEffectAsset>("Explosion");
        effect2 = Resources.Load<EffekseerEffectAsset>("Warp");

        // �q�I�u�W�F�N�g�̃��b�V����S���擾
        parsMesh = GetComponentsInChildren<MeshRenderer>();

        // �X�g���{������
        strobo = false;

        // �X�g���{�ő厞�Ԃ��o���Ă���
        stroboTimeMax = stroboTime;

        // ���G���[�h������
        muteki = false;

        // ���G���ԍő�l
        mutekiTimeMax = MutekiTime;

        // �������Ƃ��鎞�Ԃ�������
        stroboOneTime = 5;

        // �����蔻����擾
        boxCollider = this.gameObject.GetComponent<BoxCollider>();

        // �A�j���[�^�[���擾
        animator = this.GetComponent<Animator>();

        // �r�[���`���[�W�p�[�e�B�N���V�X�e���擾
        beamCharge = GameObject.Find("beamcharge");
        // �����̃X�N���v�g�擾
        beamChargeScript = beamCharge.GetComponent<charge>();


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

        this.gameObject.transform.position = new Vector3(Upos.x, Upos.y, Upos.z);

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

        // �r�[���}�l�[�W���[�̒���BoxCast���擾
        BoxCast = BeamParticleManagerPrefab.gameObject.transform.GetChild(1).gameObject;

        // BeamParticle�擾
        BeamParticleManager = BeamParticleManagerPrefab.gameObject.transform.GetChild(0).gameObject;
        // BeamEffectScript���L���b�V��
        script = BeamParticleManager.GetComponent<BeamParticleScript>();

        // �r�[���c�ʂւ̃A�N�Z�X
        //PlayerDate�����Ă���
        PlayerDate = GameObject.Find("PD");

        //Geter / Seter�g�p�p�X�N���v�g�ێ�
        beamLifeScript = PlayerDate.GetComponent<beamlife>();
        PlayerClassScript = PlayerDate.GetComponent<PlayerClass>();
    
        //�r�[���c�ʂ�100 % �ɐݒ�
        beamLifeScript.SetAmount(100);



        // �r�[��������
        Lv0_Scale = 0.4f;
        Lv0_Distance = 1.8f;
        Lv0_Use = 3.0f;

        Lv1_Scale = 0.5f;
        Lv1_Distance = 2.0f;
        Lv1_Use = 5.0f;

        Lv2_Scale = 0.8f;
        Lv2_Distance = 3.0f;
        Lv2_Use = 8.0f;

        Lv3_Scale = 1.2f;
        Lv3_Distance = 4.0f;
        Lv3_Use = 15.0f;

        Lv4_Scale = 1.5f;
        Lv4_Distance = 5.0f;
        Lv4_Use = 30.0f;

        // �r�[���̃C���^�[�o���̃}�b�N�X�l��ۑ�
        interbalMax = Interbal;

        //�Q�[���p�b�h
        input = this.GetComponent<PlayerInput>();


        _isPressed = false;
        //�ړ��t���O
        _ismoveR = false;
        _ismoveL = false;
        _ismoveU = false;
        _ismoveD = false;

        // ���R���|�[�l���g�擾
        beamChatgeAudio = this.gameObject.GetComponent<AudioSource>();

        // ���擾
        charge = Resources.Load<AudioClip>("ChargeBeamSE");
        explosion1 = Resources.Load<AudioClip>("PlayerExplosiom1");
        explosion2 = Resources.Load<AudioClip>("Explosion");
    }


    void Update()
    {     
        if (Time.deltaTime <= 0 || beamLifeScript.GetLife() <= 0)
        {
            // �`���[�W�G�t�F�N�g�X�g�b�v
            beamChatgeAudio.Stop();
            beamChargeScript.Stop();
            return;
        }

        if (strobo) // �X�g���{�t���O��True�̎��_�ł�����
        {
            Strobo();
        }

        // ���G���Ԃ̍X�V*****************
        if (muteki == true)
        {
            MutekiTime--;
            if (MutekiTime < 0)
            {
                muteki = false;
            }
        }

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
            if (Input.GetKey("d") || _ismoveR == true)
            {
                this.gameObject.transform.position = new Vector3(pos.x + speed * DownSpeed * Time.deltaTime, pos.y, pos.z);
            }
            //a���͂ō������ɓ���
            else if (Input.GetKey("a") || _ismoveL == true)
            {
                this.gameObject.transform.position = new Vector3(pos.x - speed * DownSpeed * Time.deltaTime, pos.y, pos.z);
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
            if (Input.GetKey("d") || _ismoveR == true)
            {
                this.gameObject.transform.position = new Vector3(pos.x + speed * DownSpeed * Time.deltaTime, pos.y, pos.z);
            }
            //a���͂ō������ɓ���
            else if (Input.GetKey("a") || _ismoveL == true)
            {
                this.gameObject.transform.position = new Vector3(pos.x - speed * DownSpeed * Time.deltaTime, pos.y, pos.z);
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
            if (Input.GetKey("w") || _ismoveU == true)
            {
                this.gameObject.transform.position = new Vector3(pos.x, pos.y + speed * DownSpeed * Time.deltaTime, pos.z);
            }
            //s���͂ŉ������ɓ���
            else if (Input.GetKey("s") || _ismoveD == true)
            {
                this.gameObject.transform.position = new Vector3(pos.x, pos.y - speed * DownSpeed * Time.deltaTime, pos.z);
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
            if (Input.GetKey("w") || _ismoveU == true)
            {
                this.gameObject.transform.position = new Vector3(pos.x, pos.y + speed * DownSpeed * Time.deltaTime, pos.z);
            }
            //s���͂ŉ������ɓ���
            else if (Input.GetKey("s") || _ismoveD == true)
            {
                this.gameObject.transform.position = new Vector3(pos.x, pos.y - speed * DownSpeed * Time.deltaTime, pos.z);
            }

        }


        if (Time.deltaTime > 0)
        {

            //���[�v
            if (Up == true)
            {
                //�F�ύX
                wallUp.GetComponent<Renderer>().material.color = Color.green;
                if (Input.GetKey("1"))//��
                {
                    this.gameObject.transform.position = new Vector3(Upos.x, Upos.y, Upos.z);
                    this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
            }
            if (Down == true)
            {
                //�F�ύX
                wallDown.GetComponent<Renderer>().material.color = Color.green;
                if (Input.GetKey("2"))//��
                {
                    this.gameObject.transform.position = new Vector3(Dpos.x, Dpos.y, Dpos.z);
                    this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
                }
            }
            if (Right == true)
            {
                //�F�ύX
                wallRight.GetComponent<Renderer>().material.color = Color.green;
                if (Input.GetKey("3"))//�E
                {
                    this.gameObject.transform.position = new Vector3(Rpos.x, Rpos.y, Rpos.z);
                    this.gameObject.transform.rotation = Quaternion.Euler(0, 0, -90);
                }
            }
            if (Left == true)
            {
                //�F�ύX
                wallLeft.GetComponent<Renderer>().material.color = Color.green;
                if (Input.GetKey("4"))//��
                {
                    this.gameObject.transform.position = new Vector3(Lpos.x, Lpos.y, Lpos.z);
                    this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
            }

        }
        //0329_�O�Y�u�ǋL****************************************************************


        // �A�j���[�^�[�ʏ��Ԃ�False
        animator.SetBool("fCharge", false);

        // �C���^�[�o���̎��Ԃ����炷
        Interbal--;
        if (Interbal < 0)// �C���^�[�o����0�ȉ��ɂȂ�����␳����
        {
            Interbal = 0;
        }

        // �r�[�����ˏ���*************************************************************
        if (Input.GetKey(KeyCode.Space)  || _isPressed == true ) // �L�[�R�[�h�͕ύX���Ă�(*^^*)
        {
 

            if (Input.GetKeyDown(KeyCode.Space))
            {
                // �`���[�W�G�t�F�N�g�J�n
                beamChargeScript.Play();
                //  �`���[�W���J�n
                beamChatgeAudio.Play();
            }

            // �A�j���[�^�[���邮���Ԃ�True
            animator.SetBool("fCharge",true);

            // �r�[���c�ʎ擾
            float tempCharge = beamLifeScript.GetAmount();

            // �Œ�r�[���ʂ��Ȃ���΃`���[�W���Ȃ�
            if (tempCharge >= Lv0_Use)
            {
                // ���t���[��1�������Ƃɂ���Ď��Ԃ�}��
                ChargeTime = ChargeTime + 1;
                // �ő�l�ݒ� ���o�O��Ȃ炱�̕ς��H�H�H�H
                if (ChargeTime >= MaxFrame)
                {
                    ChargeTime = (int)(MaxFrame + 1);
                }
            }

        }

        if (Input.GetKeyUp(KeyCode.Space) || (Input.GetKeyUp(KeyCode.Q))) 
        {
            // �`���[�W�G�t�F�N�g�X�g�b�v
            beamChargeScript.Stop();

            // �`���[�W���X�g�b�v
            beamChatgeAudio.Stop();

            if ( (Interbal <= 0) && (ChargeTime > 0))  // Down�Ɠ����L�[�R�[�h�ɂ��Ă�
            {
                // �C���^�[�o����ݒ肷��
                Interbal = interbalMax;

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
                else if (OneChargeFrame <= ChargeTime && ChargeTime < 2 * OneChargeFrame)// 1�K��
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
                else if (4 * OneChargeFrame <= ChargeTime)// 4�i�K��
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
                float tempCharge = beamLifeScript.GetAmount();

                float tmp = tempCharge - use;

                // �c�ʂ������
                if (tmp > 0)
                {
                    // �r�[���c�ʂ����炵��
                    tempCharge = tempCharge - use;

                    // �v���C���[�f�[�^�I�u�W�F�N�g�̃r�[���c��(Amount)���X�V����
                    beamLifeScript.SetAmount(tempCharge);

                    // �v���C���[�̊p�x��BeamParticle�ɑ������
                    // �v���C���[��Z�����Q�l�ɂ���
                    float PlayerAngle = this.transform.localEulerAngles.z;

                    // BeamParticle��Effect�p�x���X�V����
                    script.PlayerAngle = PlayerAngle;

                    // BeamParticle�̊p�x��ύX����
                    script.Angle = PlayerAngle - 90;

                    // BoxCast�̕���ύX����
                    BoxCast.transform.localScale = new Vector3(BoxCastScale, BoxCastScale, BoxCastScale);

                    // BeamParticle��BeamMax(�򋗗�)��ύX����
                    script.BeamMax = Distance;

                    // BeamParticle�̃`���[�W�i�K��n��
                    script.NowBeamLevel = BeamLevel;

                    // �v���n�u���w��ʒu�ɐ���
                    Instantiate(BeamParticleManagerPrefab, this.transform.position, gameObject.transform.localRotation);



                }
            }

            // �`���[�W���Ԃ�߂�
            ChargeTime = 0;
        }
        // �r�[�����ˏ���(�����܂�)*****************************************************************

    
        float amount = PlayerClassScript.GetBigAmount();

        // ����r�[�����ˏ���(��������)*************************************************************
        if (Input.GetKeyUp(KeyCode.K) && (amount >= 100) ) // Down�Ɠ����L�[�R�[�h�ɂ��Ă�
        {
            // BigBeam���o��
            GoBigBeam();
            // �g�p������Amount��0�ɂ���
            PlayerClassScript.SetBigAmount(0);
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


    public void OnAttck(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Canceled)
        {
            if (beamLifeScript.GetLife() <= 0) return;


            // �`���[�W�G�t�F�N�g�X�g�b�v
            beamChargeScript.Stop();

            // �`���[�W���X�g�b�v
            beamChatgeAudio.Stop();

            if ((Interbal <= 0) && (ChargeTime > 0))
            {
                // �C���^�[�o����ݒ肷��
                Interbal = interbalMax;

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
                else if (OneChargeFrame <= ChargeTime && ChargeTime < 2 * OneChargeFrame)// 1�K��
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
                else if (4 * OneChargeFrame <= ChargeTime)// 4�i�K��
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
                float tempCharge = beamLifeScript.GetAmount();

                float tmp = tempCharge - use;

                // �c�ʂ������
                if (tmp > 0)
                {
                    // �r�[���c�ʂ����炵��
                    tempCharge = tempCharge - use;
                    //Debug.Log("�g�p��" + use);
                    //Debug.Log("�r�[���c��" + tempCharge);

                    // �v���C���[�f�[�^�I�u�W�F�N�g�̃r�[���c��(Amount)���X�V����
                    beamLifeScript.SetAmount(tempCharge);

                    //Debug.Log("���[�^�[�̒��g" + beamLifeScript.GetAmount());

                    // �v���C���[�̊p�x��BeamParticle�ɑ������
                    // �v���C���[��Z�����Q�l�ɂ���
                    float PlayerAngle = this.transform.localEulerAngles.z;

                    // BeamParticle��Effect�p�x���X�V����
                    script.PlayerAngle = PlayerAngle;

                    // BeamParticle�̊p�x��ύX����
                    script.Angle = PlayerAngle - 90;

                    // BoxCast�̕���ύX����
                    BoxCast.transform.localScale = new Vector3(BoxCastScale, BoxCastScale, BoxCastScale);

                    // BeamParticle��BeamMax(�򋗗�)��ύX����
                    script.BeamMax = Distance;

                    // BeamParticle�̃`���[�W�i�K��n��
                    script.NowBeamLevel = BeamLevel;

                    // �v���n�u���w��ʒu�ɐ���
                    Instantiate(BeamParticleManagerPrefab, this.transform.position, gameObject.transform.localRotation);

                }
                // Debug.Log("�r�[���������I�I");
            }

            // �`���[�W���Ԃ�߂�
            ChargeTime = 0;
        }
    }

    public void OnAccumulate(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                // �{�^���������ꂽ���̏���
                _isPressed = true;
                break;

            case InputActionPhase.Canceled:
                // �{�^���������ꂽ���̏���
                _isPressed = false;
                break;
        }
        if (context.phase == InputActionPhase.Performed)
        {
            // �`���[�W���J�n
            beamChatgeAudio.Play();
            // �`���[�W�G�t�F�N�g�J�n
            beamChargeScript.Play();
        }
    }

    public void OnWarpUP(InputAction.CallbackContext context)
    {
        // ��O����
        if (Time.deltaTime <= 0) return;

        //���[�v
        if (Up == true)
        {
            //�F�ύX
            wallUp.GetComponent<Renderer>().material.color = Color.green;


            this.gameObject.transform.position = new Vector3(Upos.x, Upos.y, Upos.z);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);

        }

    }
    public void OnWarpDown(InputAction.CallbackContext context)
    {
        // ��O����
        if (Time.deltaTime <= 0) return;
        

        if (Down == true)
        {
            //�F�ύX
            wallDown.GetComponent<Renderer>().material.color = Color.green;

            this.gameObject.transform.position = new Vector3(Dpos.x, Dpos.y, Dpos.z);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);

        }

    }
    public void OnWarpRight(InputAction.CallbackContext context)
    {
        // ��O����
        if (Time.deltaTime <= 0) return;

        if (Right == true)
        {
            //�F�ύX
            wallRight.GetComponent<Renderer>().material.color = Color.green;

            this.gameObject.transform.position = new Vector3(Rpos.x, Rpos.y, Rpos.z);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, -90);

        }
    }
    public void OnWarpLeft(InputAction.CallbackContext context)
    {
        // ��O����
        if (Time.deltaTime <= 0) return;

        if (Left == true)
        {
            //�F�ύX
            wallLeft.GetComponent<Renderer>().material.color = Color.green;

            this.gameObject.transform.position = new Vector3(Lpos.x, Lpos.y, Lpos.z);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);

        }
    }

    public void OnLmove(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                // �{�^���������ꂽ���̏���
                _ismoveL = true;
                break;

            case InputActionPhase.Canceled:
                // �{�^���������ꂽ���̏���
                _ismoveL = false;
                break;
        }
        Debug.Log("���ɓ����I");
    }
    public void OnRmove(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                // �{�^���������ꂽ���̏���
                _ismoveR = true;
                break;

            case InputActionPhase.Canceled:
                // �{�^���������ꂽ���̏���
                _ismoveR = false;
                break;
        }
        Debug.Log("�E�ɓ����I");
    }
    public void OnUmove(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                // �{�^���������ꂽ���̏���
                _ismoveU = true;
                break;

            case InputActionPhase.Canceled:
                // �{�^���������ꂽ���̏���
                _ismoveU = false;
                break;
        }
        Debug.Log("��ɓ����I");
    }
    public void OnDmove(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                // �{�^���������ꂽ���̏���
                _ismoveD = true;
                break;

            case InputActionPhase.Canceled:
                // �{�^���������ꂽ���̏���
                _ismoveD = false;
                break;
        }
        Debug.Log("���ɓ����I");
    }

    //�r�b�N�r�[��
    public void OnBigbeam(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            //�����r�b�N�r�[���̏�������Ă��������I�I�I
            //���肪�Ƃ��I�I����܂����I�I�I
            float amount = PlayerClassScript.GetBigAmount();
            if (amount >= 100)
            {
                // BigBeam���o��
                GoBigBeam();
                // �g�p������Amount��0�ɂ���
                PlayerClassScript.SetBigAmount(0);
            }
        }
    }


    // �e���󂯂����ɌĂ΂�鏈��
    public void Hidan()
    {
        // ���G���͔�e�����X���[
        if (muteki == true) return ; 

        muteki = true;

        MutekiTime = mutekiTimeMax;

        // �c�胉�C�t���Q�Ƃ��Ĕ��j
        int life = beamLifeScript.GetLife();
        //Pos���l����
        Vector3 pos = transform.position;
        // �_�Ŏ��Ԃ��Z�b�g����
        stroboTime = stroboTimeMax;

        // HP�����炷
        life = life - 1;
        beamLifeScript.SetLife(life);

        // ���̕ӂɃv���C���[�̏���������
        if (life == 2)
        {
            // �_�ŏ�Ԃɂ���
            strobo = true;
            // �E�\�[���[���j
            pos = rightSolar.transform.position;
            // �������Đ�
            beamChatgeAudio.PlayOneShot(explosion1);
            // ���j�G�t�F�N�g�\��
            handle = EffekseerSystem.PlayEffect(effect, pos);
            // ��\����
            rightSolar.SetActive(false);
        }
        else if(life == 1)
        {
            // �_�ŏ�Ԃɂ���
            strobo = true;
            // ���\�[���[���j
            pos = leftSolar.transform.position;
            // �������Đ�
            beamChatgeAudio.PlayOneShot(explosion1);
            // ���j�G�t�F�N�g�\��
            handle = EffekseerSystem.PlayEffect(effect, pos);
            // ��\����
            leftSolar.SetActive(false);
        }
        else if(life <= 0)
        {
            foreach (var tmp in parsMesh)
            {
                tmp.enabled = false;
            }
            // �����唚��
            // �������Đ�
            beamChatgeAudio.PlayOneShot(explosion2);
            // ���j�G�t�F�N�g�\��
            handle = EffekseerSystem.PlayEffect(effect, transform.position);
        }

        return;
    }

    void Strobo()
    {
        // �_�ŏ���
        stroboOneTime--;
        if (stroboOneTime < 0)
        {
            // �\�������ւ���
            foreach (var tmp in parsMesh)
            {
                tmp.enabled = !tmp.enabled;
            }

            // ���Ԃ��ő�ɂ���
            stroboOneTime = 5; // 5�t���[���œ_�ł��J��Ԃ��ƌ��߂�
        }

        stroboTime--;
        if (stroboTime < 0)
        {
            // �S���\����Ԃɂ���
            foreach (var tmp in parsMesh)
            {
                tmp.enabled = true;
            }
            strobo = false;

        }

    }

    // ����r�[�����ˏ���
    public void GoBigBeam()
    {
        BigBeamScript script = BigBeamPrefabs.GetComponent<BigBeamScript>();

        // �i�s������n��
        script.boxCastVecor = -this.transform.up;

        // �G�t�F�N�g��]������n��
        script.PlayerAngle = this.transform.localEulerAngles.z - 180;

        // �v���n�u���w��ʒu�ɐ���
        Instantiate(BigBeamPrefabs, this.transform.position, gameObject.transform.localRotation);
    }

    
}