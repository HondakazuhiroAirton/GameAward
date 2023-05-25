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
    public float Data1;                 // Step1で使うデータ1
    public int NextState2;              // 次の状態2
    public float Data2;                 // Step2で使うデータ2
    public int NextState3;              // 次の状態3
    public float Data3;                 // Step3で使うデータ3
    public int NextState4;              // 次の状態4
    public float Data4;                 // Step4で使うデータ4
    public int NextState5;              // 次の状態5
    public float Data5;                 // Step5で使うデータ5

    //*************************************************************
    // データ対応一覧
    // Stete1：移動速度
    // Stete2：回転幅の大きさ
    // Stete3：移動速度
    // Stete4：移動速度
    // Stete5：その場所での待機時間
    //*************************************************************

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

// 敵カテゴリー列挙型
public enum EnemyCategory
{
    typeNone = 0,
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