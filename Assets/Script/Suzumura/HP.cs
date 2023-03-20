using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public Slider slider0;
    public Slider slider1;
    private float charge;
    float clampMin = 4.0f;      // 下限
    float clampMax = 20.0f / 2;     // 上限

    // Start is called before the first frame update
    void Start()
    {
        slider1.value = 100;
        charge = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // テスト用
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            slider0.value -= 0.1f;
            slider1.value -= 0.1f;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            slider0.value += 0.2f;
            slider1.value += 0.2f;
        }


        if (Input.GetKey(KeyCode.A))
        {
            if (charge <= clampMax)
            {
                charge += 0.1f;
                slider1.value -= 0.1f;
            }
        }
        else if(Input.GetKeyUp(KeyCode.A))
        {
            slider0.value -= charge;
        }
        else
        {
            charge = 0;
        }

    }


}
