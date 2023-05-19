using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BigBeamGauge : MonoBehaviour
{
    GameObject PD;
    GameObject enemy;
    PlayerClass PlayerBB;
    private float BigBeam;

    public Slider slider;
    private bool Beamdec = false;

    public float BigBeamAmount = 2.0f;
    public float hit = 0.1f;
    private float HitAmount;
    //private float a = 0;


    // Start is called before the first frame update
    void Start()
    {
        //PlayerDate�����Ă���
        PD = GameObject.Find("PD");

        //Geter / Seter�g�p�p�X�N���v�g�ێ�
        PlayerBB = PD.GetComponent<PlayerClass>();

        
        slider.value = BigBeam;

        enemy = GameObject.Find("koa");
    }

    // Update is called once per frame
    void Update()
    {
        BigBeam = PlayerBB.GetBigAmount();

        //Debug.Log(Random.Range(1.0f, 50.0f));

        if (Input.GetKey(KeyCode.Return))
        {
            if (slider.value == 100)
            {
                Beamdec = true;
            }
        }

        if(Beamdec)
        {
            slider.value = slider.value - 1f;
            if(slider.value == 0)
            {
                Beamdec = false;
            }
        }

        //AddHit();
    }

    public void AddHit()// �G�̓����蔻��ɓ���ĉ�����
    {
        BigBeam = BigBeam + BigBeamAmount * (1 + HitAmount);

        slider.value = BigBeam;
        PlayerBB.SetBigAmount(BigBeam);

        HitAmount = HitAmount + hit;

        Debug.Log(HitAmount);
        Debug.Log(BigBeam);
    }
}
