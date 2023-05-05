using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class beamlife : MonoBehaviour
{
    public GameObject Gameover;
    private int life = 3;
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
    public void GameOver()
    {
        Gameover.SetActive(true);
    }
    void Start()
    {
        //Gameover = GameObject.Find("Gameover");
        SetAmount(100);
        SetLife(3);
    }
    void Update()
    {
        // �r�[�����R��
        if (amount < 100)
        {
            amount += recovery * Time.deltaTime;
        }
        // else
        // {
        //     //return;
        // }
        //�f�o�b�N�p
        if (Input.GetKey(KeyCode.B))
        {
            amount--;

        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            life--;
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

