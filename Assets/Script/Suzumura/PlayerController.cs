using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    void Start()
    {
        // �����GameObject������Rigidbody�R���|�[�l���g���擾
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // ���͂�x�ɑ��
        float x = Input.GetAxis("Horizontal");


        //x���ɉ����͂��i�[
        Vector2 force = new Vector2(x * 10, 0);

        // Rigidbody2D�ɗ͂�������
        rb.AddForce(force);
    }
}
