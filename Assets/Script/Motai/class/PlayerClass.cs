using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass : MonoBehaviour
{
    private int life = 0;
    private float amount = 0;
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
}

