using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class beamlife : MonoBehaviour
{
    public GameObject Gameover;
    private int life = 1;
    private float amount = 100;
    public float recovery = 0.1f;
    
    // 残機
    public int GetLife()
    {
        return life;
    }
    public void SetLife(int value)
    {
        life = value;
    }
    // 残量
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
        Gameover = GameObject.Find("Gameover");
    }
    void Update()
    {
        // ビーム自然回復
        if (amount < 100)
        {
            amount += recovery * Time.deltaTime;
        }
       // else
       // {
       //     //return;
       // }
        if (Input.GetKey(KeyCode.B))
        {
            amount--;
        }

        // Game Over
        if (life == 0)
        {
            Gameover.SetActive(true);
        }
        else
        {
            Gameover.SetActive(false);
        }
    }
}

