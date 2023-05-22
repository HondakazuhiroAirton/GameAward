using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class beamlife : MonoBehaviour
{
    public GameObject Gameover;
　　// BGM用にメインカメラを取得
    private GMC_BGMscript mainCameraBGMscript;
    private int life = 3;
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
    public void GameOver()
    {
        Gameover.SetActive(true);
    }
    void Start()
    {
        // BGM用にメインカメラを取得
        mainCameraBGMscript = GameObject.Find("MainCamera").GetComponent<GMC_BGMscript>();
        //Gameover = GameObject.Find("Gameover");
        SetLife(3);

    }
    void Update()
    {
        // ビーム自然回復
        if (amount < 100)
        {
            //amount += recovery * Time.deltaTime;
            amount = amount + recovery * Time.deltaTime;
        }
        // else
        // {
        //     //return;
        // }
        //デバック用
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
            mainCameraBGMscript.GameOverBGMStart();
            Gameover.SetActive(true);

        }
        else
        {
            Gameover.SetActive(false);
        }
    }
}

