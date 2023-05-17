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

    GameObject player;
    //Animator animator;
    //GameObject LeftSolar;

    // Start is called before the first frame update
    void Start()
    {
        // animatorコンポーネントを取得
        player = GameObject.Find("Player");
        Animator animator = player.GetComponent<Animator>();
        animator.SetBool("LeftSolar_flag", false);


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
            Animator animator = player.GetComponent<Animator>();
            animator.SetBool("LeftSolar_flag", true);
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
