using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerdete
{
    private int life;
    private float amount;
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
    public void SetAmount(int value)
    {
        amount = value;
    }
}
public class PlayerClass : MonoBehaviour
{

    void Start()
    {

    }
}
