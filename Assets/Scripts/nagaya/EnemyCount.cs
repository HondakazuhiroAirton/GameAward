using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyCount : MonoBehaviour
{
    private int count;
    public TextMeshProUGUI enemycount;
    public GameObject Enemy;
    public GameObject playerbeam;
    public GameObject Enemycount;

    float seconds;

    int enemyCount;

//   private bool beingMeasured; // �v�����ł��邱�Ƃ�\���ϐ�
//   private float limit;

    // Start is called before the first frame update
    void Start()
    {
//      beingMeasured = false;
//      limit = 5.0f;

        Enemy = GameObject.Find("Enemy");
        playerbeam = GameObject.Find("PlayerBeam");
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        enemycount.text = enemycount.ToString();

        GameObject Enemycount = GameObject.Find("EnemyCount");
    //    TextMeshProUGUI.enemycount = Enemycount.GetComponent<TextMeshProUGUI>();
        enemycount.enabled=false;

    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
    

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit"); // ���O��\������


        // �����Փ˂�������I�u�W�F�N�g�̖��O��"�v���C���[�r�[��"�Ȃ��
        if (collision.gameObject.name == "PlayerBeam")
       {
            enemycount.enabled = true;
//            beingMeasured = !beingMeasured;
           // �Փ˂�������I�u�W�F�N�g���폜����
           Destroy(Enemy);

            count++;
            enemycount.text = "Combo:" + count;

//            if(seconds>=3.0f)
//            {
//                enemycount.enabled = false;
//                count=0;
//            }
        }
    }
    
}
