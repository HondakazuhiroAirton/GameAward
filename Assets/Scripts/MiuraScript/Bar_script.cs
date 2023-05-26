using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar_script : MonoBehaviour
{
    private Material thisColor;
    private GameObject lailParent;
    private Material lailColor;
    private Color flash;
    private bool first;
    // Start is called before the first frame update
    void Start()
    {
        thisColor = this.gameObject.GetComponent<SpriteRenderer>().material;
        lailParent = this.transform.parent.gameObject;
        lailColor = lailParent.GetComponent<Renderer>().material;
        flash = new Color(0, 0, 0, 0.01f);
        first = true;
        thisColor.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        // チカチカさせる
        thisColor.color -= flash;

        if (thisColor.color.a <= 0.2f || thisColor.color.a >= 1.0f)
        {
            flash *= -1;
        }
    }

    public void SetBarColor()
    {
        if (first == false) return;
        thisColor.color = lailColor.color;
        first = false;
    }
}
