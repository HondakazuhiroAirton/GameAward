using UnityEngine;

// 敵構造体
[System.Serializable]
public class EnemyData
{
    public string name;                 // 名前(No.)
    public EnemyCategory category;      // カテゴリー
    public int HP;                      // HP
    public int PosX;                    // X座標
    public int PosY;                    // Y座標
    public int PosZ;                    // Z座標
    public Sprite sprite;               // 画像読み込み(パス)
    public int AppearanceTime;          // 出現時間
    public bool Bool;
}

// 敵カテゴリー列挙型
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