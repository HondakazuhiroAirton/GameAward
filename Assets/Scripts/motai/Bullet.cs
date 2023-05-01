using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Effekseer;
public class Bullet : MonoBehaviour
{
    GameObject PD;
    GameObject objects;
    PlayerClass PlayerClasslife;
    public float ballSpeed = 10.0f;
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

        // �r�[���c�ʂւ̃A�N�Z�X
        //PlayerDate�����Ă���
        PD = GameObject.Find("PD");

        //Geter / Seter�g�p�p�X�N���v�g�ێ�
        PlayerClasslife = PD.GetComponent<PlayerClass>();
    }


    // Update is called once per frame
    void Update()
    {

        var moveVal = transform.forward * ballSpeed * Time.deltaTime;
        transform.position += moveVal;

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
                LifePoint = LifePoint - 1;

                PlayerClasslife.SetLife(LifePoint);

            }
            else
            {
                Destroy(other.gameObject);
            }

            GameObject.Destroy(this.gameObject);
        }
    }
}