// �Ƃ肠����������p�^�[���P
// �v���C���[�̂��Ƃ��l�����A���R�ɓ����G

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // �O���[�o���ϐ��݂����Ƀt�B�[���h���g���܂�
    public int State = 1; // �G�l�~�[�̏�Ԃ�����ϐ��B�����l�͓G�Ƃ��ďP���������Ă�����
    //public float MoveTime = 10f;  // �s�����ς�鎞��
    //float time = 0f;
    //float movex = 1.0f;   // �ړ���
    //float movey = 5.0f;   // �ړ��� ��ɂ��������p�^�b�Ƃ����Ƃ��ɓ�����
    //int StartCount; // �ŏ��Ƀp�^�p�^�����
    //float StartPataPataTime = 1.0f; // �ŏ��Ƀp�^�p�^���鎞�ԊԊu
    //Vector3 MoveValue;


    static GameObject Player;
    Vector2 PlayerPos;
    Vector2 EnemyPos;
    Vector2 Screen;
    Rigidbody2D rb;
    float valuex;
    float valuey;
    float clampMin;
    float clampMax;
    float PlayerandEnemyradius;
    float fTime;
    int CoolTime = 0;
    float Intarval = 6;
    Vector3 ViewportLeftBottom;
    Vector3 ViewportRightTop;
    Vector2 NowPos;
    // �v���C���[�̃I�u�W�F�N�g���擾

    public GameObject ScoreObj;

    void Start()
    {
        //time = 0f;
        //StartCount = 0;
        State = 1;
 
        Player = GameObject.Find("Player");
        PlayerPos = Player.transform.position ;
        rb = this.GetComponent<Rigidbody2D>();  // rigidbody���擾
        clampMin = -50;
        clampMax = 50;
        CoolTime = 0;
    }

    void Update()
    {
        CoolTime--; // �N�[���^�C���𖈃t���[������
        // ���t���[��enemy�̃|�W�V�������擾
        EnemyPos = this.transform.position;
        fTime += Time.deltaTime; // ���Ԍv����ϐ��Ɏ擾
        if (State == 1) // 1:�ЂƂ�Ŏ��R�ɓ����Ă�
        {
            rb.AddForce(new Vector2(-0.1f, 0.0f));

            //Debug.Log(rb.velocity);

            if (EnemyPos.y < 0.0)
            {
                rb.AddForce(new Vector2(0.0f, 0.1f), ForceMode2D.Impulse);
            }

            rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, clampMin, clampMax),
                          Mathf.Clamp(rb.velocity.y, clampMin, clampMax));
           // Debug.Log(Mathf.Clamp(rb.velocity.x, clampMin, clampMax));
        }
        else if (State == 2)// 2:�v���C���[�𔭌����Ēǂ���������
        {
            // �G�Ǝ����̈ʒu���r
           
            PlayerPos = Player.transform.position;
            Vector2 Compare = new Vector2(EnemyPos.x - PlayerPos.x, EnemyPos.y - PlayerPos.y);


            if (Compare.x >= 0.5)
            {
                rb.AddForce(new Vector2(-0.1f,0f));
            }
            else if (Compare.x <= -0.05)
            {
                rb.AddForce(new Vector2(0.1f,0f));
            }

            if (Compare.y >= 0.2)
            {
                //rb.AddForce(new Vector2(0,-30));
            }
            else if (Compare.y <= -0.2)
            {
                rb.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
            }

            rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, clampMin, clampMax),
                                      Mathf.Clamp(rb.velocity.y, clampMin, clampMax));


        }
        else if (State == 3)// 3:�G�^�b�N���ҋ@
        {
            if (CoolTime > 0)
            {
                State = 1;
            }

            this.transform.position = NowPos;

            if (fTime > Intarval) // ��莞�Ԍo�ߌ��
            {
                State = 4;
                fTime = 0;
            }

            rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, clampMin, clampMax),
                                      Mathf.Clamp(rb.velocity.y, clampMin, clampMax));

        }
        else if (State == 4)// 3:�G�^�b�N���ҋ@
        {
            if (fTime < 3)
            {
                // �^�b�N������
                PlayerPos = Player.transform.position;
                Vector2 Compare = new Vector2(PlayerPos.x - EnemyPos.x, PlayerPos.y - EnemyPos.y); // �x�N�g�������߂�
                Compare.x = Compare.x / 10000;
                Compare.y = Compare.y / 10000;
                this.gameObject.transform.Translate(Compare);
            }
            else if (fTime > 3)
            {
                State = 1;
                fTime = 0.0f;
                CoolTime = 180;
            }
        }



        // ��ʊO����

        // �r���[�|�[�g�擾�i�J�����̒[���������[���h���W�ɕϊ����Ă�j
        ViewportLeftBottom =  Camera.main.ViewportToWorldPoint(new Vector3(0, 0));
        ViewportRightTop =  Camera.main.ViewportToWorldPoint(new Vector3(1, 1));

        // ���[��������
        if (ViewportLeftBottom.x > EnemyPos.x)
        { // �E�[�ɖ߂�
            transform.position = new Vector2 (ViewportRightTop.x,EnemyPos.y);
        }
        // �E�[��������
        else if (ViewportRightTop.x < EnemyPos.x)
        { // ���[�ɖ߂�
            transform.position = new Vector2(ViewportLeftBottom.x, EnemyPos.y);
        }

        // ��[��������
        if (ViewportRightTop.y <= EnemyPos.y)
        { // �����Ɠ��Ԃ���
            transform.position = new Vector2(EnemyPos.x, ViewportRightTop.y);
        }
        

    }

    public void SetEnemyState(int StateID)
    {
        State = StateID;
        NowPos = this.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerandEnemyradius = collision.gameObject.transform.localScale.x / 2 + gameObject.transform.localScale.x / 2;
            Debug.Log("�v���C���[�Ƃ���������");
            EnemyPos = this.transform.position;
            PlayerPos = Player.transform.position;
            Vector2 Compare = new Vector2(EnemyPos.x - PlayerPos.x, EnemyPos.y - PlayerPos.y);
            float slash = Compare.x * Compare.x + Compare.y * Compare.y;
            float sqrt = Mathf.Sqrt(slash);
            float diameter = PlayerandEnemyradius - sqrt;
            //Rigidbody2D playerrb = collision.gameObject.GetComponent<Rigidbody2D>();
            //playerrb.velocity = Vector3.zero;
            //Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;

            if (Compare.x > 0)
            {
                rb.AddForce(new Vector2(1000f * diameter, 0f));
            }
            else if (Compare.x <= 0)
            {
                rb.AddForce(new Vector2(-1000f * diameter, 0f));
            }

           // ScoreObj.GetComponent<ScoreScript>().AddScore();
        }

    }
}
