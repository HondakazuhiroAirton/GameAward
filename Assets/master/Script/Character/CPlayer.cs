using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CPlayer : MonoBehaviour
{
    [SerializeField]
    private float speed; //プレイヤーのスピード

    private MoveRange moveRange;

    [SerializeField]
    private GameObject railObject;
    
    RailData railData;

    // Start is called before the first frame update
    void Start()
    {
        //moveRange = new MoveRange();
        railData = railObject.GetComponent<RailData>();
        SetRail(RailNo.UP);
    }

    // Update is called once per frame
    void Update()
    {
        int moveVec = 0;

        if (Input.GetKey(KeyCode.UpArrow)) { }

        if (Input.GetKey(KeyCode.DownArrow)) { }

        if (Input.GetKey(KeyCode.LeftArrow)) { moveVec = -1; }

        if (Input.GetKey(KeyCode.RightArrow)) { moveVec = 1; }

        if (Input.GetKey(KeyCode.DownArrow)) { }

        if (Input.GetKey("1")) { SetRail(RailNo.UP); }

        if (Input.GetKey("2")) { SetRail(0); }

        if (Input.GetKey("3")) { SetRail(0); }

        if (Input.GetKey("4")) { SetRail(0); }

        if (Input.GetKey(KeyCode.Space)) { }



        /// 移動処理 ///
        var moveVal = transform.right * speed * moveVec * Time.deltaTime;

        transform.position += moveVal;

        /// 移動制限 ///
        var Pos = transform.position;

        Pos.x = Mathf.Clamp(Pos.x, moveRange.xMin, moveRange.xMax);
        Pos.y = Mathf.Clamp(Pos.y, moveRange.yMin, moveRange.yMax);
        transform.position = new Vector3(Pos.x, Pos.y, Pos.z);
    }



    void SetRail(RailNo dir)
    {
        railData.GetMoveRange(dir, out moveRange);
    }


    void SetPosition()
    {

    }
}
