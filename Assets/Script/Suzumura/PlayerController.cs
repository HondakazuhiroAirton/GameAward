using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    float buoyancy;

    readonly float clampMinX = -1.0f;
    readonly float clampMaxX = 1.0f;
    readonly float clampMinY = -200.0f;
    readonly float clampMaxY = 200.0f;

    Vector2 PlayerPos;
    Vector2 ViewportLB;     // ����
    Vector2 ViewportRT;     // �E��

    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody�R���|�[�l���g���擾
        rb = GetComponent<Rigidbody2D>();

        buoyancy = 200;

        // �r���[�|�[�g�擾
        ViewportLB = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        ViewportRT = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

    }

    // Update is called once per frame
    void Update()
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

        // ��ʊO����
        PlayerPos = this.transform.position;
        // ���[
        if (PlayerPos.x <= ViewportLB.x)
        {
            transform.position = new Vector2(ViewportRT.x, PlayerPos.y);       // �E���Ɉړ�
        }
        // �E�[
        else if (PlayerPos.x >= ViewportRT.x)
        {
            transform.position = new Vector2(ViewportLB.x, PlayerPos.y);       // �E���Ɉړ�
        }

        // ��[
        if (PlayerPos.y >= ViewportRT.y)
        {
            transform.position = new Vector2(PlayerPos.x, ViewportRT.y);
            force.y = -30;
        }

        // �ړ����x�̐���
        force.x = Mathf.Clamp(force.x, clampMinX, clampMaxX);
        force.y = Mathf.Clamp(force.y, clampMinY, clampMaxY);

        // Rigidbody2D�ɗ͂�������
        rb.AddForce(force);
    }
}
