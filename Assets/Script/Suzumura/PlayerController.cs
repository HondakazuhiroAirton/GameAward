using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    float buoyancy;             // ����
    float clampMinX = -5.0f;    // ����
    float clampMaxX = 5.0f;     // ���
    float clampMinY = -200.0f;
    float clampMaxY = 200.0f;

    Vector2 PlayerPos;      // �v���C���[�̈ʒu
    Vector2 ViewportLB;     // ��ʂ̍������W
    Vector2 ViewportRT;     // �E��̉E����W

    bool isGround = false;  // �ڒn����
    bool dashflug = false;  // �_�b�V���t���O
    int dashcount = 0;      // �_�b�V���J�E���g
    int cooltime = 0;       // �N�[���^�C��

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
        float dash = 10.0f;
        // �_�b�V��
        // ����: B�{�^���@�N�[���^�C���Ȃ��@�󒆂ɂ���
        if ((Input.GetKeyDown("b")) && (cooltime == 0) && (!isGround))
        {
            dashflug = true;
            dash = 1000.0f;
            clampMinX = -60.0f;     // ���x�̏�����
            clampMaxX = 60.0f;      // ���x�̉������
            dashcount = 100;
            cooltime = 500;         // �N�[���^�C���ݒ�
        }

        dashcount--;
        cooltime--;

        // ���t���[����Ƀ_�b�V����ԉ���
        if (dashcount <= 0)
        {
            dashcount = 0;
            // ���ɖ߂�
            dashflug = false;
            dash = 10.0f;
            clampMinX = -5.0f;
            clampMaxX = 5.0f;
        }

        // �N�[���^�C����0�ȉ��ɂȂ�Ȃ��悤�ɂ���
        if (cooltime <= 0)
        {
            cooltime = 0;
        }

        // ���͂�x�ɑ��
        float x = Input.GetAxis("Horizontal");

        //x���ɉ����͂��i�[
        Vector2 force = new Vector2(x * dash, 0);

        // �W�����v����
        if (Input.GetKeyDown("space"))
        {
            force = new Vector2(x * dash, buoyancy);
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

        // Rigidbody2D�ɗ͂�������
        rb.AddForce(force);

        // �ړ����x�̐���
        rb.velocity = new Vector3(Mathf.Clamp(rb.velocity.x, clampMinX, clampMaxX), Mathf.Clamp(rb.velocity.y, clampMinY, clampMaxY), 0);

    }

    //�n�ʂɐG��Ă���Ƃ��ɌĂяo�����֐�
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGround = true;
        }
    }

    //�n�ʂ��痣�ꂽ�Ƃ��ɌĂяo�����֐�
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGround = false;
        }
    }
}
