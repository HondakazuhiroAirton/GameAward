using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RailNo
{
    UP = 0,
    RIGHT,
    DOWN,
    LEFT,
}

public class MoveRange
{
    public float xMax;
    public float xMin;
    public float yMax;
    public float yMin; 
}

public class RailData : MonoBehaviour
{
    [SerializeField]
    private GameObject[] wallsObj;

    // Start is called before the first frame update
    void Start()
    {
        wallsObj = GameObject.FindGameObjectsWithTag("Wall");
    }

    public void GetMoveRange(RailNo no,out MoveRange moveRange)
    {
        moveRange = new MoveRange();       

        switch ((int)no)
        {
            case (int)RailNo.UP:
                {
                    var uTransform = wallsObj[(int)RailNo.UP].gameObject.transform;

                    moveRange.xMax = uTransform.position.x + uTransform.localScale.x / 2;
                    moveRange.xMin = uTransform.position.x - uTransform.localScale.x / 2;
                    moveRange.yMax = uTransform.position.y;
                    moveRange.yMin = uTransform.position.y;
                    break;
                }
            case (int)RailNo.RIGHT:
                {
                    var uTransform = wallsObj[(int)RailNo.UP].gameObject.transform;

                    moveRange.xMax = uTransform.position.x + uTransform.localScale.x / 2;
                    moveRange.xMin = uTransform.position.x - uTransform.localScale.x / 2;
                    moveRange.yMax = uTransform.position.y;
                    moveRange.yMin = uTransform.position.y;
                    break;
                }
            case (int)RailNo.DOWN:
                {
                    var uTransform = wallsObj[(int)RailNo.UP].gameObject.transform;

                    moveRange.xMax = uTransform.position.x + uTransform.localScale.x / 2;
                    moveRange.xMin = uTransform.position.x - uTransform.localScale.x / 2;
                    moveRange.yMax = uTransform.position.y;
                    moveRange.yMin = uTransform.position.y;
                    break;
                }
            case (int)RailNo.LEFT:
                {
                    var uTransform = wallsObj[(int)RailNo.UP].gameObject.transform;

                    moveRange.xMax = uTransform.position.x + uTransform.localScale.x / 2;
                    moveRange.xMin = uTransform.position.x - uTransform.localScale.x / 2;
                    moveRange.yMax = uTransform.position.y;
                    moveRange.yMin = uTransform.position.y;
                    break;
                }
        }
    } 
}