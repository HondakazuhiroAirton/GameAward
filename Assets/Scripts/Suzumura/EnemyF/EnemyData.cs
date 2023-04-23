using UnityEngine;

// 敵構造体
[System.Serializable]
public class EnemyData
{
    public string name;                 // 名前(No.)
    public EnemyCategory category;      // カテゴリー
    public int HP;                      // HP
    public int Size;                    // 大きさ
    public int StartPosX;               // X座標
    public int StartPosY;               // Y座標
    public int StartPosZ;               // Z座標
    public int Target1PosX;             //
    public int Target1PosY;             //
    public int Target1PosZ;             //
    public int TargetPosX;              //
    public int TargetPosY;              //
    public int TargetPosZ;              //
    public Sprite sprite;               // 画像読み込み(パス)
    public float AppearanceTime;          // 出現時間
    public int State;                   // 状態

    public Vector3 prevPosition;
    public float distance_two;         //二点間の距離を入れる
    public float State1time;
    public float PresentLocation;
    public Vector3 target1;
    public float State2time;

}

// 敵カテゴリー列挙型
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