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

    // Start is called before the first frame update
    void Start()
    {
        //PlayerDate�����Ă���
        PD = GameObject.Find("PD");

        //Geter / Seter�g�p�p�X�N���v�g�ێ�
        PlayerBB = PD.GetComponent<PlayerClass>();
    }

    // Update is called once per frame
    void Update()
    {
        BigBeam = PlayerBB.GetBigAmount();

        slider.value = BigBeam;
    }
}
