using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    void FixedUpdate()
    {
        // ���͂�x�ɑ��
        float x = Input.GetAxis("Horizontal");

        // �����GameObject������Rigidbody�R���|�[�l���g���擾
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        // rigidbody��x���ɗ͂�������
        rigidbody.AddForce(x, 0, 0);
    }
}
