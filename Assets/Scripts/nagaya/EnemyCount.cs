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

    private float _countdown=5.0f;    //�J��Ԃ��Ԋu
    private float _timeElapsed;   //�o�ߎ���



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

        _countdown = 5;    //���s�Ԋu���T�ɐݒ�
        


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
            //beingMeasured = !beingMeasured;
            // �Փ˂�������I�u�W�F�N�g���폜����
            Destroy(Enemy);

            count++;
            enemycount.text = "Combo:" + count;

            //���Ԃ��J�E���g�_�E������
            _timeElapsed -= Time.deltaTime;


            //countdown��0�ȉ��ɂȂ����Ƃ�
            if (_timeElapsed <= 0)
            {
                Debug.Log("TimeOut"); // ���O��\������
                _timeElapsed = 0;   //�o�ߎ��Ԃ����Z�b�g����
                enemycount.enabled = false;
            }
            else if(collision.gameObject.name == "PlayerBeam")
            {
                Destroy(Enemy);

                count++;
                enemycount.text = "Combo:" + count;
                
            }


            
           
         
            
            
            

        }
    }
    
}
