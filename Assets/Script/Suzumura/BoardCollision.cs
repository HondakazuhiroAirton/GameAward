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
        Debug.Log("�ʂ��Ă���");
        // transform���擾
        Transform BoardTransform = GameObject.FindGameObjectWithTag("board").transform;
        // ���[�J�����W��ŁA���݂̉�]�ʂ։��Z����
        BoardTransform.Rotate(0.0f, 0.0f, 90.0f);
    }
}
