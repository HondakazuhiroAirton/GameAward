using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerClass : MonoBehaviour
{
    [SerializeField] Text text;
    private int life = 0;
    private float amount = 0;
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

    }
    void Update()
    {
        // ビーム自然回復
        if (amount < 100)
        {
            amount += recovery * Time.time;
        }
        else
        {
            return;
        }

        // Game Over
        if (life == 0)
        {
            text.enabled = true;
        }
        else
        {
            text.enabled = false;
        }
    }
}

