using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    private Rigidbody rb;

    public GameObject WallUp;
    public GameObject WallLeft;
    public GameObject WallDown;
    public GameObject WallRight;

    public float speed; //�v���C���[�̃X�s�[�h 


    public Vector3 Upos;
    public Vector3 Lpos;
    public Vector3 Dpos;
    public Vector3 Rpos;

    public float URpos;
    public float ULpos;
    public float LRpos;
    public float LLpos;
    public float DRpos;
    public float DLpos;
    public float RRpos;
    public float RLpos;

    public float PRpos;
    public float PLpos;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        WallUp = GameObject.Find("WallUp");
        WallLeft = GameObject.Find("WallLeft");
        WallDown = GameObject.Find("WallDown");
        WallRight = GameObject.Find("WallRight");  
        

        //�v���C���[�X�s�[�h
        speed = 1f;

        //WallUp�̒[�擾
        Vector3 Upos = WallUp.gameObject.transform.position;
        Vector3 UScale = WallUp.gameObject.transform.localScale;
        URpos = Upos.x + UScale.x / 2;
        ULpos = Upos.x - UScale.x / 2;

        //WallLeft�̒[�擾
        Vector3 Lpos = WallLeft.gameObject.transform.position;
        Vector3 LScale = WallLeft.gameObject.transform.localScale;
        LRpos = Lpos.y + LScale.y / 2;
        LLpos = Lpos.y - LScale.y / 2;

        //WallDown�̒[�擾
        Vector3 Dpos = WallDown.gameObject.transform.position;
        Vector3 DScale = WallDown.gameObject.transform.localScale;
        DRpos = Dpos.x + DScale.x / 2;
        DLpos = Dpos.x - DScale.x / 2;

        //WallRight�̒[�擾
        Vector3 Rpos = WallRight.gameObject.transform.position;
        Vector3 RScale = WallRight.gameObject.transform.localScale;
        RRpos = Rpos.y + RScale.y / 2;  //unity�̒���pos�g���Ȃ����Ȃ����Ď����Ă�����
        RLpos = Rpos.y - RScale.y / 2;



    }

    // Update is called once per frame
    void Update()
    {
        //�v���C���[�̍��W�擾
        Vector3 pos = this.gameObject.transform.position;
        //�v���C���[�̃X�P�[���擾
        Vector3 Scale = this.gameObject.transform.localScale;     
        

        //<<<��̃��C���ړ�>>> 
        if (pos.y == Upos.y)
        {
            //���C���O�ɂ����Ȃ�����       
            if (pos.x >= URpos - Scale.x / 2)
            {
                pos.x = URpos - Scale.x / 2;
            }
            else if (pos.x <= ULpos + Scale.x / 2)
            {
                pos.x = ULpos + Scale.x / 2;
            }

            if (Input.GetKey("a"))
            {
                this.gameObject.transform.position = new Vector3(pos.x + speed, pos.y, pos.z);
            }
            //a���͂ō������ɓ���
            else if (Input.GetKey("d"))
            {
                this.gameObject.transform.position = new Vector3(pos.x - speed, pos.y, pos.z);
            }
            //�~�܂�
            else
            {
                rb.velocity = new Vector3(0, 0, 0);
            }
        }
        else if(pos.x == Rpos.x && pos.x == Lpos.x)  
        {
            if (Input.GetKey("w"))
            {
                this.gameObject.transform.position = new Vector3(pos.x, pos.y+speed, pos.z);
            }
            else if (Input.GetKey("s"))
            {
                this.gameObject.transform.position = new Vector3(pos.x, pos.y-speed, pos.z);
            }
            //�~�܂�
            else
            {
                rb.velocity = new Vector3(0, 0, 0);
            }
        }
        
           
//       if(Input.GetKey("1"))   //��̃o�[�֍s��
//       {
//           this.GameObject.transform.position = new Vector3(Upos.x,Upos.y,Upos.z);
//       }
//       else if(Input.GetKey("2"))  //���̃o�[�֍s��
//       {
//           this.GameObject.transform.position = new Vector3(Lpos.x, Lpos.y, Lpos.z);
//       }
//       else if(Input.GetKey("3"))  //���̃o�[�֍s��
//       {
//           this.GameObject.transform.position = new Vector3(Dpos.x, Dpos.y, Dpos.z);
//       }
//       else if(Input.GetKey("4"))  //�E�̃o�[�֍s��
//       {
//           this.GameObject.transform.position = new Vector3(Rpos.x, Rpos.y, Rpos.z);
//       }


 //       //�p�x���ς��
 //       if (Input.GetKey("c"))
 //       {
 //           this.gameObject.transform.rotation=new Vector3(0,0,5);
 //       }
 //       else if (Input.GetKey("v"))
 //       {
 //           this.gameObject.transform.rotation = new Vector3(0, 0, -5);
 //       }
    }
}

