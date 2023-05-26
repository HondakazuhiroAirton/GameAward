using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CombText : MonoBehaviour
{
    TextMeshProUGUI meshPro;

    int Frame;
    float CountTime;
    // Start is called before the first frame update
    void Start()
    {
        Frame = 0;
        CountTime = 0;
    }

    private void Update()
    {
        Frame++;
        CountTime += Time.deltaTime;

        if (Frame / 8 == 1)
        {
            if (meshPro.color.a == 0)
            {
                meshPro.color = new Color(255, 255, 0, 1);
            }
            else if (meshPro.color.a >= 1)
            {
                meshPro.color = new Color(255, 255, 0, 0);
            }

            Frame = 0;
        }
        
     
        if (CountTime > 2)
        {
            Destroy(this.gameObject);
        }
    }

    public void SetComboText(int val)
    {
        meshPro.text = val + "Chain";
    }

    private void Awake()
    {
        meshPro = GetComponent<TextMeshProUGUI>();
    }
}
