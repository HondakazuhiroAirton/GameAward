using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�X�e�[�W�̖��O���L���C�ɂ���񋓌^
public enum StageNo
{
    Stage1_1 = 0,
    Stage1_2,
    Stage1_3,


    Stage_MAX // �S�X�e�[�W+1
}

public class StageChangerScript : MonoBehaviour
{
    // �X�e�[�W�f�[�^������**************************************************
    public GameObject[] StageData;


    // ���̃X�e�[�WNo
    public StageNo NowStage;

    // ���̃X�e�[�WNo
    public StageNo NextStage;

    [SerializeField]
    // Stage��؂�ւ��邩�ǂ����t���O
    private bool changeStage = false;

    void Start()
    {
       
    }

    void Update()
    {
        // ������B��������X�e�[�W�ύX�������J�n����
        if (changeStage == true)
        {
            // �X�e�[�W�ύX�������J�n����
            StageChange(StageNo.Stage1_1);
        }
    }


    // �X�e�[�W�ύX����
    void StageChange(StageNo no) // <--- �ύX���No.
    {
        // �Ή������X�e�[�W�f�[�^�̃v���n�u��ǂݍ���
        Instantiate( StageData[(int)no] );

        // �X�e�[�W�ύX�t���O��false�ɂ���
        changeStage = false;
    }
}
