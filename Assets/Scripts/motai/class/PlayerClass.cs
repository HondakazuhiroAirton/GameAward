using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerClass : MonoBehaviour
{
    [SerializeField] Text text;
    public GameObject ButtonS;
    public GameObject ButtonR;
    private int life = 0;
    private float amount = 100;
    public float recovery = 0.1f;
    
    // �c�@
    public int GetLife()
    {
        return life;
    }
    public void SetLife(int value)
    {
        life = value;
    }
    // �c��
    public float GetAmount()
    {
        return amount;
    }
    public void SetAmount(float value)
    {
        amount = value;
    }
    void Start()
    {

    }
    void Update()
    {
        // �r�[�����R��
        if (amount < 100)
        {
            amount += recovery * Time.time;
        }
        else
        {
            return;
        }

//<<<<<<< HEAD
//        Debug.Log(amount);

//        // Game Over
//        if (life == 0)
//        {
//            //text.enabled = true;
//            //ButtonR.SetActive(true);
//            //ButtonS.SetActive(true);
//        }
//        else
//        {
//            //text.enabled = false;
//            //ButtonR.SetActive(false);
//            //ButtonS.SetActive(false);
//        }
//=======
//        //// Game Over
//        //if (life == 0)
//        //{
//        //    text.enabled = true;
//        //    ButtonR.SetActive(true);
//        //    ButtonS.SetActive(true);
//        //}
//        //else
//        //{
//        //    text.enabled = false;
//        //    ButtonR.SetActive(false);
//        //    ButtonS.SetActive(false);
//        //}
//>>>>>>> develop
    }
}

