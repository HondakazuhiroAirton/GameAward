using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class meter : MonoBehaviour
{
    public GameObject hari;
    public Slider slider;
    public Image sliderimage;
    public float add = 0;
    beamlife beamlife;
    float bm = 0;

    public GameObject Obj;

    // Start is called before the first frame update
    void Start()
    {
        //hari = GameObject.Find("Hari");
        //Obj = GameObject.Find("GameObject");
        beamlife = Obj.GetComponent<beamlife>();
    }

    // Update is called once per frame
    void Update()
    {

        //ビーム残量持ってくるならここ

        bm = beamlife.GetAmount();
        slider.value = beamlife.GetAmount();
        //数値の補正    
        add = (bm-10) * 2 - 90;



        //add = bm;
        if (add <= 100 && add >= -100)
        {          
            hari.transform.eulerAngles = new Vector3(0, 0, -add);
        }

        if(slider.value < 30)// 赤
        {
            sliderimage.color = new Color32(255, 0, 0, 255);
        }
        if (slider.value >= 30)// 緑
        {
            sliderimage.color = new Color32(50, 255, 0, 255);
        }

    }



}
