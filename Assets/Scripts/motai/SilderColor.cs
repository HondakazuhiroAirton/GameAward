using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class SilderColor : MonoBehaviour
{
    [SerializeField] Image sliderImage;
    public Slider slider;
    GameObject PD;
    PlayerClass PlayerBB;
    private float BigBeam;
    int PM = -1;

    void Start()
    {
        sliderImage.color =new Color(1.0f, 1.0f, 1.0f, 1.0f);
        //StartCoroutine("Flashing");

        //PlayerDate�����Ă���
        PD = GameObject.Find("PD");

        //Geter / Seter�g�p�p�X�N���v�g�ێ�
        PlayerBB = PD.GetComponent<PlayerClass>();

        BigBeam = PlayerBB.GetBigAmount();

        slider.value = BigBeam;

    }

    void Update()
    {
        if (slider.value == 100) Flashing();
        else sliderImage.color = new Color32(255, 255, 255, 255);
    }

    void Flashing()
    {
        if (sliderImage.color == new Color32(255, 255, 255, 255))
        {
            PM = -1;

        }
        else if (sliderImage.color == new Color32(255, 255, 255, 0))
        {
            PM = 1;

        }

        if(PM == -1)
        {
            sliderImage.color = sliderImage.color - new Color32(0, 0, 0, 1);
        }
        else if (PM == 1)
        {
            sliderImage.color = sliderImage.color + new Color32(0, 0, 0, 1);
        }
    }
}
