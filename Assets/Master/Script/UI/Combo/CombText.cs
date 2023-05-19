using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CombText : MonoBehaviour
{
    TextMeshProUGUI meshPro;

    float CountTime;
    // Start is called before the first frame update
    void Start()
    {
        CountTime = 0;
    }

    private void Update()
    {
        CountTime += Time.deltaTime;

      

        if (CountTime > 2)
        {
            Destroy(this.gameObject);
        }
    }

    public void SetComboText(int val)
    {
        meshPro.text = val + "Combo!";
    }

    private void Awake()
    {
        meshPro = GetComponent<TextMeshProUGUI>();
    }
}
