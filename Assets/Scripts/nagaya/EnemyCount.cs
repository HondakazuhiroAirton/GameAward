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
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }



    void onButtonCount()
    {
        
        count++;
        enemycount.text = "Enemy:" + count;
    }

    

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit"); // ���O��\������
        // �����Փ˂�������I�u�W�F�N�g�̖��O��"�v���C���[�r�[��"�Ȃ��
       if (collision.gameObject.name == "PlayerBeam")
       {
//            beingMeasured = !beingMeasured;
           // �Փ˂�������I�u�W�F�N�g���폜����
           Destroy(Enemy);
           onButtonCount();
            

       }
    }
    
}
