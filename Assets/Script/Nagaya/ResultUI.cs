using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultUI : MonoBehaviour
{
    //�N���A���ɕ\������UI
    [SerializeField]
    private GameObject resultUI;

    public GameObject Image;

    // Start is called before the first frame update
    void Start()
    {
        //Fade�̎擾
        Image = GameObject.Find("Image");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("k"))
        {

            // �p�l��UI�̃A�N�e�B�u��A�N�e�B�u��؂�ւ�
            Active();



        }
        }

    public void Active()
    {
        //�p�l��UI�̃A�N�e�B�u�A��A�N�e�B�u��؂�ւ�
        resultUI.SetActive(!resultUI.activeSelf);
    }
}
