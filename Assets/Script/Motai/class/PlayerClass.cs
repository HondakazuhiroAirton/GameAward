using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass : MonoBehaviour
{
    
    private int life = 0;
    private float amount = 0;
    public float BeamReamount = 1f;
    // Žc‹@
    public int GetLife()
    {
        return life;
    }
    public void SetLife(int value)
    {
        life = value;
    }
    // Žc—Ê
    public float GetAmount()
    {
        return amount;
    }
    public void SetAmount(float value)
    {
        amount = value;
    }

    void Update()
    {
        if (amount <= 100)
        {
            amount += BeamReamount;
        }

        if (amount >= 100)
        {
            amount = 100;
        }
    }
}

