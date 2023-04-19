using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�X�e�[�W�̖��O���L���C�ɂ���񋓌^
public enum StageNo
{
    Stage1_1 = 0,
    Stage1_2,
    Stage1_3,
    Stage2_1,
    Stage2_2,
    Stage2_3,
    Stage3_1,
    Stage3_2,
    Stage3_3,


    Stage_MAX // �S�X�e�[�W+1
}

public class StageChangerScript : MonoBehaviour
{
    // �X�e�[�W�f�[�^������**************************************************
    public GameObject StageData;


    // ���̃X�e�[�WNo
    //public StageNo NowStage;

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
            StageChange(NextStage);
        }
    }


    // �X�e�[�W�ύX����
    void StageChange(StageNo no) // <--- �ύX���No.
    {
        // �O�̃G�l�~�[��S���f���[�g����
        Destroy(this.transform.GetChild(0).gameObject);

        // �Ή������X�e�[�W�f�[�^�̃v���n�u�����
        Instantiate( StageData ,
            new Vector3(0.0f, 0.0f, 0.0f),
            Quaternion.identity,
            this.transform);//  <-- StageChanger�̎q�Ƃ��č쐬

        // �X�e�[�W�ύX�t���O��false�ɂ���
        changeStage = false;
    }
}
