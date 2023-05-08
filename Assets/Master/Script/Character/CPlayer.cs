using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayer : MonoBehaviour
{
    [SerializeField]
    private float speed; //プレイヤーのスピード
   
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        var input = GameInput.actions.Character;

        int moveVec = 0;

        if (Input.GetKey(KeyCode.UpArrow)) { UpKeyEvent(); }

        if (Input.GetKey(KeyCode.DownArrow)) { DownKeyEvent(); }

        if (Input.GetKey(KeyCode.LeftArrow)) { LeftKeyEvent(); }

        if (Input.GetKey(KeyCode.RightArrow)) { RightKeyEvent(); }

        if (Input.GetKey("1")) { }

        if (Input.GetKey("2")) { }

        if (Input.GetKey("3")) { }

        if (Input.GetKey("4")) { }

        if (Input.GetKey(KeyCode.Space)) { }

        ///// 移動処理 ///
        //var moveVal = transform.right * speed * moveVec * Time.deltaTime;

        //transform.position += moveVal;

        ///// 移動制限 ///
        //var Pos = transform.position;

        //Pos.x = Mathf.Clamp(Pos.x, moveRange.xMin, moveRange.xMax);
        //Pos.y = Mathf.Clamp(Pos.y, moveRange.yMin, moveRange.yMax);
        //transform.position = new Vector3(Pos.x, Pos.y, Pos.z);
    }



    void LeftKeyEvent()
    {

    }

    void RightKeyEvent()
    {

    }

    void DownKeyEvent()
    {

    }

    void UpKeyEvent()
    {

    }
}
