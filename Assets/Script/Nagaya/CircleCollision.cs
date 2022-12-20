using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CircleCollision : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int addText = 1;
    

    // Start is called before the first frame update
    void Start()
    {

        addText = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //�ϐ�addText�𕶎���ɕϊ����Atext.text�ɑ�����\�����镶�͂�ύX
        text.text = addText.ToString();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Cage"))
        {
         
        //�ϐ�addText��1���Z
        addText = addText + 1;


         //�J�S�ɂԂ������������
         //          Destroy(this.gameObject);


             if (addText == 5)
             {
                 SceneManager.LoadScene("EndScene");   //�T�񓖂�������N���A
             }
        }

       
    }
    


   

}
