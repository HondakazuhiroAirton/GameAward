using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meter : MonoBehaviour
{
    public GameObject hari;
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
        //数値の補正    
        add = bm * 2 - 100;

        //add = bm;
        if (add <= 100 && add >= -100)
        {          
            hari.transform.eulerAngles = new Vector3(0, 0, -add);
        }

    }



}
