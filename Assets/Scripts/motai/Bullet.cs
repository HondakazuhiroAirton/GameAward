using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Effekseer;
public class Bullet : MonoBehaviour
{
    GameObject PD;
    //GameObject LeftSolar;
    //GameObject RightSolar;
    //GameObject Player;
    GameObject objects;
    beamlife PlayerClasslife;
    [SerializeField] GameObject player;
    public float ballSpeed = 10.0f;

    // �ʂ̈ړ�����
    public Vector3 moveVal;
    private float Wx;
    private float Wy;


    void Start()
    {
        //// �G�t�F�N�g���擾����B
        //EffekseerEffectAsset effect = Resources.Load<EffekseerEffectAsset>("Bullet");
        //// transform�̈ʒu�ŃG�t�F�N�g���Đ�����
        //EffekseerHandle handle = EffekseerSystem.PlayEffect(effect, transform.position);
        //// transform�̉�]��ݒ肷��B
        //handle.SetRotation(transform.rotation);

        // �r�[�����C�t�ւ̃A�N�Z�X
        //PlayerDate�����Ă���
        PD = GameObject.Find("PD");

        //Geter / Seter�g�p�p�X�N���v�g�ێ�
        PlayerClasslife = PD.GetComponent<beamlife>();

        player = GameObject.Find("Player");

        //Animator animator = player.GetComponent<Animator>();
        //animator.SetBool("LeftSolar_flag", false);
        //RightSolar = GameObject.Find("RightSolar");


        //LeftSolar = GameObject.Find("LeftSolar");

        if (player != null)
        {
            // �v���C���[�̏ꏊ�擾
            Vector3 PlayerPos = player.transform.position;

            // �x�N�g���v�Z
            moveVal = PlayerPos - this.transform.position;

            // ���K��
            moveVal = moveVal.normalized;

            // �␳�W����������
            moveVal.x *= ballSpeed;
            moveVal.y *= ballSpeed;
            moveVal.z *= ballSpeed;
        }
    }


    // Update is called once per frame
    void Update()
    {
        // �ʂ𖈃t���[���𓮂����Ă�
        transform.position += moveVal * Time.deltaTime;

        Wx = Camera.main.WorldToViewportPoint(transform.position).x;
        Wy = Camera.main.WorldToViewportPoint(transform.position).y;

        if (0 >= Wx || Wx >= 1 )
        {
            GameObject.Destroy(this.gameObject);
        }
        else if (0 >= Wy || Wy >= 1)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        int LifePoint = PlayerClasslife.GetLife();
        if (other.gameObject.tag == "Player")
        {
            Debug.Log(LifePoint);
            if (LifePoint > 0)
            {
                bool Muteki = player.GetComponent<PlayerMove_MIURA>().Hidan();

                if (Muteki == false)
                {

                    LifePoint = LifePoint - 1;

                    PlayerClasslife.SetLife(LifePoint);

                }

                Destroy(this.gameObject);
            }
        }
    }
}
