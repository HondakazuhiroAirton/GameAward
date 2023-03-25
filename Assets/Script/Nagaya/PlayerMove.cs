using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody rb;

    public GameObject WallUp;
    public GameObject WallDown;
    public GameObject WallLeft;
    public GameObject WallRight;

    public float speed; //�v���C���[�̃X�s�[�h 
    public Vector3 pos;
    public Vector3 Scale;

    public Vector3 Upos;        //��̈ʒu
    public Vector3 UScale;      //��̃X�P�[��
    public Vector3 Dpos;        //���̈ʒu
    public Vector3 DScale;      //���̃X�P�[��
    public Vector3 Rpos;        //�E�̈ʒu
    public Vector3 RScale;      //�E�̃X�P�[��
    public Vector3 Lpos;        //���̈ʒu
    public Vector3 LScale;      //���̃X�P�[��

    public float URpos;
    public float ULpos;
    public float DRpos;
    public float DLpos;
    public float RRpos;
    public float RLpos;
    public float LRpos;
    public float LLpos;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //�v���C���[�X�s�[�h
        speed = 0.1f;

        //WallUp�̒[�擾
        Upos = WallUp.gameObject.transform.position;
        UScale = WallUp.gameObject.transform.localScale;
        URpos = Upos.x + UScale.x / 2;
        ULpos = Upos.x - UScale.x / 2;

        //WallDown�̒[�擾
        Dpos = WallDown.gameObject.transform.position;
        DScale = WallDown.gameObject.transform.localScale;
        DRpos = Dpos.x + DScale.x / 2;
        DLpos = Dpos.x - DScale.x / 2;

        //WallRight�̒[�擾
        Rpos = WallRight.gameObject.transform.position;
        RScale = WallRight.gameObject.transform.localScale;
        RRpos = Rpos.y + RScale.y / 2;
        RLpos = Rpos.y - RScale.y / 2;

        //WallLeft�̒[�擾
        Lpos = WallLeft.gameObject.transform.position;
        LScale = WallLeft.gameObject.transform.localScale;
        LRpos = Lpos.y + LScale.y / 2;
        LLpos = Lpos.y - LScale.y / 2;

        this.gameObject.transform.position = new Vector3(Upos.x, Upos.y, Upos.z - 1);

    }

    // Update is called once per frame
    void Update()
    {
        //�v���C���[�̍��W�擾
        pos = this.gameObject.transform.position;
        //�v���C���[�̃X�P�[���擾
        Scale = this.gameObject.transform.localScale;

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
                this.gameObject.transform.position = new Vector3(pos.x + speed, pos.y, pos.z);
            }
            //a���͂ō������ɓ���
            else if (Input.GetKey("a"))
            {
                this.gameObject.transform.position = new Vector3(pos.x - speed, pos.y, pos.z);
            }

        }
        //<<<���̃��C���ړ�>>>
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
                this.gameObject.transform.position = new Vector3(pos.x + speed, pos.y, pos.z);
            }
            //a���͂ō������ɓ���
            else if (Input.GetKey("a"))
            {
                this.gameObject.transform.position = new Vector3(pos.x - speed, pos.y, pos.z);
            }

        }
        //<<<�E�̃��C���ړ�>>>
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
                this.gameObject.transform.position = new Vector3(pos.x, pos.y + speed, pos.z);
            }
            //s���͂ŉ������ɓ���
            else if (Input.GetKey("s"))
            {
                this.gameObject.transform.position = new Vector3(pos.x, pos.y - speed, pos.z);
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
                this.gameObject.transform.position = new Vector3(pos.x, pos.y + speed, pos.z);
            }
            //s���͂ŉ������ɓ���
            else if (Input.GetKey("s"))
            {
                this.gameObject.transform.position = new Vector3(pos.x, pos.y - speed, pos.z);
            }

        }


        //���[�v
        if (Input.GetKey("1"))//��
        {
            this.gameObject.transform.position = new Vector3(Upos.x, Upos.y, Upos.z - 1);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey("2"))//��
        {
            this.gameObject.transform.position = new Vector3(Dpos.x, Dpos.y, Dpos.z - 1);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        if (Input.GetKey("3"))//�E
        {
            this.gameObject.transform.position = new Vector3(Rpos.x, Rpos.y, Rpos.z - 1);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        if (Input.GetKey("4"))//��
        {
            this.gameObject.transform.position = new Vector3(Lpos.x, Lpos.y, Lpos.z - 1);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, -90);
        }

    }
}
