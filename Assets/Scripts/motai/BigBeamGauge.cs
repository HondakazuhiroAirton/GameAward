using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BigBeamGauge : MonoBehaviour
{
    GameObject PD;
    PlayerClass PlayerBB;
    private float BigBeam;
    public Slider slider;
    private bool Beamdec = false;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerDateもってくる
        PD = GameObject.Find("PD");

        //Geter / Seter使用用スクリプト保持
        PlayerBB = PD.GetComponent<PlayerClass>();

        BigBeam = PlayerBB.GetBigAmount();

        slider.value = BigBeam;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (slider.value == 100)
            {
                Beamdec = true;
            }
        }

        if(Beamdec)
        {
            slider.value = slider.value - 0.1f;
            if(slider.value == 0)
            {
                Beamdec = false;
            }
        }
        
    }
}
