using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    float buoyancy;

    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody�R���|�[�l���g���擾
        rb = GetComponent<Rigidbody2D>();

        buoyancy = 200;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // ���͂�x�ɑ��
        float x = Input.GetAxis("Horizontal");

        //x���ɉ����͂��i�[
        Vector2 force = new Vector2(x * 10, 0);

        // �W�����v����
        if (Input.GetKeyDown("space"))
        {
            force = new Vector2(x * 10, buoyancy);
        }

        // Rigidbody2D�ɗ͂�������
        rb.AddForce(force);

        // ��ʊO����
    }
}
