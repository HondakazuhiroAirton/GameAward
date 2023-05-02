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

    void Start()
    {
        sliderImage.color =new Color(1.0f, 1.0f, 1.0f, 1.0f);
        StartCoroutine("Flashing");
    }

    void Update()
    {
        if (slider.value > 100)
        {
            Flashing();

            slider.value --;
        }
    }

    IEnumerator Flashing()
    {
         while (true)
         {
             for (int i = 0; i < 20; i++)
             {
                 sliderImage.color = sliderImage.color - new Color32(0, 0, 0, 10);
                 yield return new WaitForSeconds(0.01f);
             }

             for (int k = 0; k < 20; k++)
             {
                 sliderImage.color = sliderImage.color + new Color32(0, 0, 0, 10);
                 yield return new WaitForSeconds(0.01f);
             }
         }
    }
}
