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
        // ���[�J�����W��ŁA���݂̉�]�ʂ։��Z����
        GameObject.FindGameObjectWithTag("board").transform.Rotate(0.0f, 0.0f, rot);

    }
}
