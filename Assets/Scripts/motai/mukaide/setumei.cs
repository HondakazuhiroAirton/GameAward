using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class setumei : MonoBehaviour
{
    TextMeshProUGUI Text;

    int fase = 0;

    // Start is called before the first frame update
    void Start()
    {
        Text = this.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

        switch(fase)
        {
            case 0: { Text.text = "0A�{�^���Ńr�[������"; break; }
            case 1: { Text.text = "1�\���L�[�Ń��[�v"; break; }
            case 2: { Text.text = "2�X�e�B�b�N�ňړ�"; break; }
            case 3: { Text.text = "3"; break; }
            case 4: { Text.text = "4"; break; }
        }

        if(Input.GetKeyDown(KeyCode.O))
        {
            fase++;
        }
    }
}
