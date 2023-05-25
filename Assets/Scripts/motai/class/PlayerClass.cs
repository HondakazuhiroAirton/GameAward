using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerClass : MonoBehaviour
{
    [SerializeField] Text text;
    public GameObject ButtonS;
    public GameObject ButtonR;
    private int life;
    private float amount = 100;
    private float bigamount;
    public float recovery = 0.1f;

    // 倒した敵の総数
    [SerializeField] private int destroyTotal;

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

    // ビッグビーム残量
    public float GetBigAmount()
    {
        return bigamount;
    }
    public void SetBigAmount(float value)
    {
        bigamount = value;
    }


    public int GetDestroyTotal()
    {
        return destroyTotal;
    }

    public void SetDestroyTotal(int value)
    {
        destroyTotal = value;
    }


    void Start()
    {
        SetLife(3);
        destroyTotal = 0;
        SetBigAmount(0);
    }
    void Update()
    {
        if (amount < 100)
        {
            amount = 100;
        }

        // ビーム自然回復
        if (amount < 100)
        {
            amount += recovery * Time.time;
        }
        else
        {
            return;
        }


    }
}

