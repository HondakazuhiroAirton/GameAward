using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour
{
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;
    public GameObject Obj;
    int Life;

    //Animator animator;
    //GameObject LeftSolar;

    // Start is called before the first frame update
    void Start()
    {
        //// animator�R���|�[�l���g���擾
        //LeftSolar = GameObject.Find("LeftSolar");
        //Animator animator = LeftSolar.GetComponent<Animator>();
        ////animator.SetBool("LeftSolarflag", false);

        
        //animator = GetComponent<Animator>();
        

        life1 = GameObject.Find("life1");
        life2 = GameObject.Find("life2");
        life3 = GameObject.Find("life3");
        //Obj = GameObject.Find("GameObject");
        Life = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Life = Obj.GetComponent<beamlife>().GetLife();
        if(Life == 2)
        {
            life1.SetActive(false);
        }
        if (Life == 1)
        {
            life2.SetActive(false);
        }
        if (Life <= 0)
        {
            life3.SetActive(false);
            Obj.GetComponent<beamlife>().GameOver();
        }

    }
}
