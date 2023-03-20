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

    public float speed; //プレイヤーのスピード 


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
        

        //プレイヤースピード
        speed = 1f;

        //WallUpの端取得
        Vector3 Upos = WallUp.gameObject.transform.position;
        Vector3 UScale = WallUp.gameObject.transform.localScale;
        URpos = Upos.x + UScale.x / 2;
        ULpos = Upos.x - UScale.x / 2;

        //WallLeftの端取得
        Vector3 Lpos = WallLeft.gameObject.transform.position;
        Vector3 LScale = WallLeft.gameObject.transform.localScale;
        LRpos = Lpos.y + LScale.y / 2;
        LLpos = Lpos.y - LScale.y / 2;

        //WallDownの端取得
        Vector3 Dpos = WallDown.gameObject.transform.position;
        Vector3 DScale = WallDown.gameObject.transform.localScale;
        DRpos = Dpos.x + DScale.x / 2;
        DLpos = Dpos.x - DScale.x / 2;

        //WallRightの端取得
        Vector3 Rpos = WallRight.gameObject.transform.position;
        Vector3 RScale = WallRight.gameObject.transform.localScale;
        RRpos = Rpos.y + RScale.y / 2;  //unityの中のpos使えないかなあって示してただけ
        RLpos = Rpos.y - RScale.y / 2;



    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーの座標取得
        Vector3 pos = this.gameObject.transform.position;
        //プレイヤーのスケール取得
        Vector3 Scale = this.gameObject.transform.localScale;     
        

        //<<<上のライン移動>>> 
        if (pos.y == Upos.y)
        {
            //ライン外にいかない処理       
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
            //a入力で左向きに動く
            else if (Input.GetKey("d"))
            {
                this.gameObject.transform.position = new Vector3(pos.x - speed, pos.y, pos.z);
            }
            //止まる
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
            //止まる
            else
            {
                rb.velocity = new Vector3(0, 0, 0);
            }
        }
        
           
//       if(Input.GetKey("1"))   //上のバーへ行く
//       {
//           this.GameObject.transform.position = new Vector3(Upos.x,Upos.y,Upos.z);
//       }
//       else if(Input.GetKey("2"))  //左のバーへ行く
//       {
//           this.GameObject.transform.position = new Vector3(Lpos.x, Lpos.y, Lpos.z);
//       }
//       else if(Input.GetKey("3"))  //下のバーへ行く
//       {
//           this.GameObject.transform.position = new Vector3(Dpos.x, Dpos.y, Dpos.z);
//       }
//       else if(Input.GetKey("4"))  //右のバーへ行く
//       {
//           this.GameObject.transform.position = new Vector3(Rpos.x, Rpos.y, Rpos.z);
//       }


 //       //角度が変わる
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

