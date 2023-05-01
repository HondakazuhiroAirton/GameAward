using UnityEngine;

// �G�\����
[System.Serializable]
public class EnemyData
{
    public string name;                 // ���O(No.)
    public EnemyCategory category;      // �J�e�S���[
    public int HP;                      // HP
    public int Size;                    // �傫��
    public int StartPosX;               // �o���ʒu
    public int StartPosY;               // 
    public int StartPosZ;               // 
    public int EntryPosX;               // ��ʓ��ɓ���ʒu
    public int EntryPosY;               //
    public int EntryPosZ;               //
    public int sideNo;                  // ��
    public int Target1PosX;             // �ڕW�n�_1
    public int Target1PosY;             //
    public int Target1PosZ;             //
    public int TargetPosX;              // �ڕW�n�_
    public int TargetPosY;              //
    public int TargetPosZ;              //
    public Sprite sprite;               // �摜�ǂݍ���(�p�X)
    public float AppearanceTime;        // �o������
    public int State;                   // ���

    public Vector3 prevPosition;
    public float distance_two;         //��_�Ԃ̋���������
    public float State1time;
    public float PresentLocation;
    public Vector3 Entry;
    public Vector3 target1;
    public float State2time;

}

// �G�J�e�S���[�񋓌^
public enum EnemyCategory
{
    type1 = 1,
    type2 = 2,
    type3 = 3
}

//public class EnemyDataBase : ScriptableObject
//{
//    public EnemyData[] datas;
//}