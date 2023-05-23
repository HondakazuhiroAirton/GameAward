using UnityEngine;

// 敵構造体
[System.Serializable]
public class EnemyData
{
    public string name;                 // 名前(No.)
    public Phase phase;                 // 出現フェーズ
    public int StartPosX;               // 出現位置
    public int StartPosY;               // 
    public int StartPosZ;               // 
    public int FirstPosX;               // 目標地点1
    public int FirstPosY;               //
    public int FirstPosZ;               //
    public int TargetPosX;              // 目標地点
    public int TargetPosY;              //
    public int TargetPosZ;              //
    public float EntryPosX;             // 画面内に入る位置
    public float EntryPosY;             //
    public int sideNo;                  // 辺
    public float AppearanceTime;        // 出現時間
    public string model;                // モデル読み込み(パス)
    public EnemyCategory category;      // カテゴリー
    public float Size;                  // 大きさ
    public int NextState1;              // 次の状態1
    public int NextState2;              // 次の状態2
    public int NextState3;              // 次の状態3
    public int NextState4;              // 次の状態4
    public int NextState5;              // 次の状態5

    public int State;                   // 状態
    public Vector3 prevPosition;
    public float distance_two;          //二点間の距離を入れる
    public float Duration;
    public float PresentLocation;
    public Vector3 Entry;
    public Vector3 First;
    public Vector3 target;
    public int Step;
}

//[System.Serializable]
//public class EnemyDatas
//{
//    public Vector3 prevPosition;
//    public float distance_two;         //二点間の距離を入れる
//    public float Duration;
//    public float PresentLocation;
//    public Vector3 Entry;
//    public Vector3 target1;
//    public Vector3 target;
//    public int Step;
//}

// 敵カテゴリー列挙型
public enum EnemyCategory
{
    type1 = 1,
    type2 = 2,
    type3 = 3
}

// 出現フェーズ列挙型
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