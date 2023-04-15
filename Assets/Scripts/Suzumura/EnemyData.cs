using UnityEngine;

// �G�\����
[System.Serializable]
public class EnemyData
{
    public string name;                 // ���O(No.)
    public EnemyCategory category;      // �J�e�S���[
    public int HP;                      // HP
    public int StartPosX;               // X���W
    public int StartPosY;               // Y���W
    public int StartPosZ;               // Z���W
    public int TargetPosX;              //
    public int TargetPosY;              //
    public int TargetPosZ;              //
    public Sprite sprite;               // �摜�ǂݍ���(�p�X)
    public float AppearanceTime;          // �o������
    public int State;                   // ���
}

// �G�J�e�S���[�񋓌^
public enum EnemyCategory
{
    type1 = 1,
    type2 = 2,
    type3 = 3
}

public class EnemyDataBase : ScriptableObject
{
    public EnemyData[] datas;
}