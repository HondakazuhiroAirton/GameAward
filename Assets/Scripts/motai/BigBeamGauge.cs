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
    private float HitAmount;
    private float a = 0;


    // Start is called before the first frame update
    void Start()
    {
        //PlayerDateもってくる
        PD = GameObject.Find("PD");

        //Geter / Seter使用用スクリプト保持
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

        //敵を倒すとビッグビームゲージが増える
        for (int i = 0; i > 10; i++)
        {
            if (enemy != null) return;

            BigBeam = BigBeam * (1 + HitAmount);

            slider.value = BigBeam;
            PlayerBB.SetBigAmount(BigBeam);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (enemy == null)
        {
            a++;
        }

        switch(a)
        {
            case 1:
                BigBeam = 2;
                HitAmount = 0.0f;
                break;
            case 2:
                HitAmount = 0.1f;
                break;
            case 3:
                HitAmount = 0.2f;
                break;
            case 4:
                HitAmount = 0.3f;
                break;
            case 5:
                HitAmount = 0.4f;
                break;
            case 6:
                HitAmount = 0.5f;
                break;
            case 7:
                HitAmount = 0.6f;
                break;
            case 8:
                HitAmount = 0.7f;
                break;
            case 9:
                HitAmount = 0.8f;
                break;
            case 10:
                HitAmount = 0.9f;
                break;
        }
    }
}
