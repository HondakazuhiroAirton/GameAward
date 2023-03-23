using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardCollision : MonoBehaviour
{
    public static BoardCollision instance;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void CollisionBoard()
    {
        Debug.Log("通っている");
        // transformを取得
        Transform BoardTransform = GameObject.FindGameObjectWithTag("board").transform;
        // ローカル座標基準で、現在の回転量へ加算する
        BoardTransform.Rotate(0.0f, 0.0f, 90.0f);
    }
}
