using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class beamlife : MonoBehaviour
{
    public GameObject Gameover;
�@�@// BGM�p�Ƀ��C���J�������擾
    private GMC_BGMscript mainCameraBGMscript;
    public GameObject enemyManager;
    private EnemyManager gameoverflug;
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
        // BGM�p�Ƀ��C���J�������擾
        mainCameraBGMscript = GameObject.Find("MainCamera").GetComponent<GMC_BGMscript>();
        // EnemyManager�̊֐��擾
        gameoverflug = GameObject.Find("EnemyGroup(Clone)").GetComponent<EnemyManager>();
        //Gameover = GameObject.Find("Gameover");
        SetLife(3);

    }
    void Update()
    {
        // �r�[�����R��
        if (amount < 100)
        {
            //amount += recovery * Time.deltaTime;
            amount = amount + recovery * Time.deltaTime;
        }


        // Game Over
        if (life == 0)
        {
            mainCameraBGMscript.GameOverBGMStart();
            Gameover.SetActive(true);
            gameoverflug.EnemyMoveStop();
        }
        else
        {
            Gameover.SetActive(false);
        }
    }
}
