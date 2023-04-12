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

    void Start()
    {

    }

    public void CollisionBoard(float rot)
    {
        // ローカル座標基準で、現在の回転量へ加算する
        GameObject.FindGameObjectWithTag("board").transform.Rotate(0.0f, 0.0f, rot);

    }
}
