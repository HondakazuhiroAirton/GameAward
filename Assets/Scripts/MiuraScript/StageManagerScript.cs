using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManagerScript : MonoBehaviour
{
    // �S�X�e
    public int[][] AllStage;  

    void Start()
    {
        // CSV�����������f�[�^�Ƃ���ׂāA0�܂���NULL�Ȃ�0

        int StageIndex = 0;

        for (int i = 0; i < 4; i++)// World (World���S����4������4)
        {
            for (int j = 0; j < 5; j++)// Stage (1World��5�X�e�[�W������5)
            {

                //switch () // �N���A���Ă邩�ǂ����Ŕ��f
                //{


                //}

                // �ʂ��ԍ���1�i�߂�
                StageIndex++;
            }

        }
    }

    void Update()
    {
        
    }
}
