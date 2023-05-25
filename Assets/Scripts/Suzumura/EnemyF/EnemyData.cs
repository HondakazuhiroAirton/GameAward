using UnityEngine;

// �G�\����
[System.Serializable]
public class EnemyData
{
    public string name;                 // ���O(No.)
    public Phase phase;                 // �o���t�F�[�Y
    public int StartPosX;               // �o���ʒu
    public int StartPosY;               // 
    public int StartPosZ;               // 
    public int FirstPosX;               // �ڕW�n�_1
    public int FirstPosY;               //
    public int FirstPosZ;               //
    public int TargetPosX;              // �ڕW�n�_
    public int TargetPosY;              //
    public int TargetPosZ;              //
    public float EntryPosX;             // ��ʓ��ɓ���ʒu
    public float EntryPosY;             //
    public int sideNo;                  // ��
    public float AppearanceTime;        // �o������
    public string model;                // ���f���ǂݍ���(�p�X)
    public EnemyCategory category;      // �J�e�S���[
    public float Size;                  // �傫��
    public int NextState1;              // ���̏��1
    public float Data1;                 // Step1�Ŏg���f�[�^1
    public int NextState2;              // ���̏��2
    public float Data2;                 // Step2�Ŏg���f�[�^2
    public int NextState3;              // ���̏��3
    public float Data3;                 // Step3�Ŏg���f�[�^3
    public int NextState4;              // ���̏��4
    public float Data4;                 // Step4�Ŏg���f�[�^4
    public int NextState5;              // ���̏��5
    public float Data5;                 // Step5�Ŏg���f�[�^5

    //*************************************************************
    // �f�[�^�Ή��ꗗ
    // Stete1�F�ړ����x
    // Stete2�F��]���̑傫��
    // Stete3�F�ړ����x
    // Stete4�F�ړ����x
    // Stete5�F���̏ꏊ�ł̑ҋ@����
    //*************************************************************

    public int State;                   // ���
    public Vector3 prevPosition;
    public float distance_two;          //��_�Ԃ̋���������
    public float Duration;
    public float PresentLocation;
    public Vector3 Entry;
    public Vector3 First;
    public Vector3 target;
    public int Step;
}

// �G�J�e�S���[�񋓌^
public enum EnemyCategory
{
    typeNone = 0,
    type1 = 1,
    type2 = 2,
    type3 = 3
}

// �o���t�F�[�Y�񋓌^
public enum Phase
{
    phase1 = 1,
    phase2 = 2,
    phase3 = 3,
    phase4 = 4,
    phase5 = 5,

    phase_max
}

//public class EnemyDataBase : ScriptableObject
//{
//    public EnemyData[] datas;
//}