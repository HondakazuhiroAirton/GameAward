using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CombText : MonoBehaviour
{
    TextMeshProUGUI meshPro;

    // Start is called before the first frame update
    void Start()
    {
        meshPro = GetComponent<TextMeshProUGUI>();
        SetComboText(5);
    }

    public void SetComboText(int val)
    {
        meshPro.text = val + "Combo!";
    }
}
