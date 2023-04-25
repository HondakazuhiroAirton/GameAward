using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursol2 : MonoBehaviour
{
    // �Q�[���I�u�W�F�N�g�z��ŊǗ�
    public GameObject[] iti;

    // ���̈ʒu�����Ă����ϐ�
    [SerializeField] private int NowPosition;

    GameObject stageSelector;
    GameObject Cursol;

    WorldSelector script;

    public GameObject Stage1_1;
    public GameObject Stage1_2;
    public GameObject Stage1_3;
    public GameObject Stage1_4;
    public GameObject Stage1_5;

    public GameObject Cancel;
    
    void Start()
    {
        
        // �ŏ��̓X�e�[�W1
        NowPosition = 1;
        this.transform.position = iti[NowPosition].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            NowPosition += 1;
            if (NowPosition > 4/*<-�}�W�b�N�i���o�[ ���[���h�̍��v�̐�-1����ꂽ��*/) NowPosition = 0;
            this.transform.position = iti[NowPosition].transform.position;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            NowPosition -= 1;
            if (NowPosition < 0) NowPosition = 4;/*<-�}�W�b�N�i���o�[ ���[���h�̍��v�̐�-1����ꂽ��*/
            this.transform.position = iti[NowPosition].transform.position;
        }
        

    }
}
