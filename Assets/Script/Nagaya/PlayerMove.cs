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

    public float speed; //プレイヤーのスピード 
    public Vector3 pos;
    public Vector3 Scale;

    public Vector3 Upos;        //上の位置
    public Vector3 UScale;      //上のスケール
    public Vector3 Dpos;        //下の位置
    public Vector3 DScale;      //下のスケール
    public Vector3 Rpos;        //右の位置
    public Vector3 RScale;      //右のスケール
    public Vector3 Lpos;        //左の位置
    public Vector3 LScale;      //左のスケール

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

        //プレイヤースピード
        speed = 0.1f;

        //WallUpの端取得
        Upos = WallUp.gameObject.transform.position;
        UScale = WallUp.gameObject.transform.localScale;
        URpos = Upos.x + UScale.x / 2;
        ULpos = Upos.x - UScale.x / 2;

        //WallDownの端取得
        Dpos = WallDown.gameObject.transform.position;
        DScale = WallDown.gameObject.transform.localScale;
        DRpos = Dpos.x + DScale.x / 2;
        DLpos = Dpos.x - DScale.x / 2;

        //WallRightの端取得
        Rpos = WallRight.gameObject.transform.position;
        RScale = WallRight.gameObject.transform.localScale;
        RRpos = Rpos.y + RScale.y / 2;
        RLpos = Rpos.y - RScale.y / 2;

        //WallLeftの端取得
        Lpos = WallLeft.gameObject.transform.position;
        LScale = WallLeft.gameObject.transform.localScale;
        LRpos = Lpos.y + LScale.y / 2;
        LLpos = Lpos.y - LScale.y / 2;

        this.gameObject.transform.position = new Vector3(Upos.x, Upos.y, Upos.z - 1);

    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーの座標取得
        pos = this.gameObject.transform.position;
        //プレイヤーのスケール取得
        Scale = this.gameObject.transform.localScale;

        //<<<上のライン移動>>>
        if (pos.y == Upos.y)
        {

            pos.y = Upos.y;

            //ライン外にいかない処理
            if (pos.x >= URpos - Scale.x / 2)
            {
                pos.x = URpos - Scale.x / 2;
            }
            else if (pos.x <= ULpos + Scale.x / 2)
            {
                pos.x = ULpos + Scale.x / 2;
            }

            //d入力で右向きに動く
            if (Input.GetKey("d"))
            {
                this.gameObject.transform.position = new Vector3(pos.x + speed, pos.y, pos.z);
            }
            //a入力で左向きに動く
            else if (Input.GetKey("a"))
            {
                this.gameObject.transform.position = new Vector3(pos.x - speed, pos.y, pos.z);
            }

        }
        //<<<下のライン移動>>>
        if (pos.y == Dpos.y)
        {

            pos.y = Dpos.y;

            //ライン外にいかない処理
            if (pos.x >= DRpos - Scale.x / 2)
            {
                pos.x = DRpos - Scale.x / 2;
            }
            else if (pos.x <= DLpos + Scale.x / 2)
            {
                pos.x = DLpos + Scale.x / 2;
            }

            //d入力で右向きに動く
            if (Input.GetKey("d"))
            {
                this.gameObject.transform.position = new Vector3(pos.x + speed, pos.y, pos.z);
            }
            //a入力で左向きに動く
            else if (Input.GetKey("a"))
            {
                this.gameObject.transform.position = new Vector3(pos.x - speed, pos.y, pos.z);
            }

        }
        //<<<右のライン移動>>>
        if (pos.x == Rpos.x)
        {

            pos.x = Rpos.x;

            //ライン外にいかない処理
            if (pos.y >= RRpos - Scale.y / 2)
            {
                pos.y = RRpos - Scale.y / 2;
            }
            else if (pos.y <= RLpos + Scale.y / 2)
            {
                pos.y = RLpos + Scale.y / 2;
            }

            //w入力で上向きに動く
            if (Input.GetKey("w"))
            {
                this.gameObject.transform.position = new Vector3(pos.x, pos.y + speed, pos.z);
            }
            //s入力で下向きに動く
            else if (Input.GetKey("s"))
            {
                this.gameObject.transform.position = new Vector3(pos.x, pos.y - speed, pos.z);
            }

        }
        //<<<左のライン移動>>>
        if (pos.x == Lpos.x)
        {

            pos.x = Lpos.x;

            //ライン外にいかない処理
            if (pos.y >= LRpos - Scale.y / 2)
            {
                pos.y = LRpos - Scale.y / 2;
            }
            else if (pos.y <= LLpos + Scale.y / 2)
            {
                pos.y = LLpos + Scale.y / 2;
            }

            //w入力で上向きに動く
            if (Input.GetKey("w"))
            {
                this.gameObject.transform.position = new Vector3(pos.x, pos.y + speed, pos.z);
            }
            //s入力で下向きに動く
            else if (Input.GetKey("s"))
            {
                this.gameObject.transform.position = new Vector3(pos.x, pos.y - speed, pos.z);
            }

        }


        //ワープ
        if (Input.GetKey("1"))//上
        {
            this.gameObject.transform.position = new Vector3(Upos.x, Upos.y, Upos.z - 1);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey("2"))//下
        {
            this.gameObject.transform.position = new Vector3(Dpos.x, Dpos.y, Dpos.z - 1);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        if (Input.GetKey("3"))//右
        {
            this.gameObject.transform.position = new Vector3(Rpos.x, Rpos.y, Rpos.z - 1);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        if (Input.GetKey("4"))//左
        {
            this.gameObject.transform.position = new Vector3(Lpos.x, Lpos.y, Lpos.z - 1);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, -90);
        }

    }
}
