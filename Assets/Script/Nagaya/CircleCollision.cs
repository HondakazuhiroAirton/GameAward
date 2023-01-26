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
            //Cage(��)�ɂԂ�������Circle�i�v���C���[�j������
            this.gameObject.SetActive(false);
            Invoke("GoToGameOver", 1.0f);
        }

        if(other.gameObject.CompareTag("Triangle"))
        {//
            addText = addText + 1;
            if (addText == 5)
            {
                SceneManager.LoadScene("SecondStage");   //�T�񓖂�������N���A
            }

        }




    }

    void GoToGameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }






}
