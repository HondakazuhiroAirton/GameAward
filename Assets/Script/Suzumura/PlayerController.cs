using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    float buoyancy;             // ����
    float dash;                 // ���x
    float clampMinX = -5.0f;    // ����
    float clampMaxX = 5.0f;     // ���
    float clampMinY = -200.0f;
    float clampMaxY = 200.0f;

    Vector2 PlayerPos;      // �v���C���[�̈ʒu
    Vector2 EnemyPos;       // �G�̈ʒu
    Vector2 ViewportLB;     // ��ʂ̍������W
    Vector2 ViewportRT;     // �E��̉E����W

    bool isGround = false;  // �ڒn����
    bool dashflug = false;  // �_�b�V���t���O
    int dashcount = 0;      // �_�b�V���J�E���g
    int cooltime = 0;       // �N�[���^�C��

    float PlayerandEnemyradius;
    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody�R���|�[�l���g���擾
        rb = GetComponent<Rigidbody2D>();

        // �r���[�|�[�g�擾
        ViewportLB = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        ViewportRT = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

    }

    // Update is called once per frame
    void Update()
    {
        buoyancy = 0.0f;
        dash = 10.0f;
        // �_�b�V��
        // ����: B�{�^���@�N�[���^�C���Ȃ��@�󒆂ɂ���
        if ((Input.GetKeyDown("b")) && (cooltime == 0) && (!isGround))
        {
            dashflug = true;
            dash = 1000.0f;
            clampMinX = -60.0f;     // ���x�̏�����
            clampMaxX = 60.0f;      // ���x�̉������
            dashcount = 100;        // �_�b�V�����Ԑݒ�
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

        // �W�����v����
        if (Input.GetKeyDown("space"))
        {
            buoyancy = 200;     // ���͐ݒ�
        }

        //x���ɉ����͂��i�[
        Vector2 force = new Vector2(x * dash, buoyancy);

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
            transform.position = new Vector2(ViewportLB.x, PlayerPos.y);       // �����Ɉړ�
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
        rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, clampMinX, clampMaxX), Mathf.Clamp(rb.velocity.y, clampMinY, clampMaxY));

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            PlayerandEnemyradius = collision.gameObject.transform.localScale.x / 2 + gameObject.transform.localScale.x / 2;
            Debug.Log("�ړG");
            PlayerPos = this.transform.position;
            EnemyPos = collision.transform.position;
            Vector2 Compare = new Vector2(PlayerPos.x - EnemyPos.x, PlayerPos.y - EnemyPos.y);
            float slash = Compare.x * Compare.x + Compare.y * Compare.y;
            float sqrt = Mathf.Sqrt(slash);
            float diameter = PlayerandEnemyradius - sqrt;
            //Rigidbody2D enemyrb = collision.gameObject.GetComponent<Rigidbody2D>();
            //enemyrb.velocity = Vector3.zero;
            //Rigidbody2D playerrb = gameObject.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;

            if (Compare.x > 0)
            {
                rb.AddForce(new Vector2(1000f * diameter, 0f));
            }
            else if (Compare.x <= 0)
            {
                rb.AddForce(new Vector2(-1000f * diameter, 0f));
            }
        }



    }
    



}
