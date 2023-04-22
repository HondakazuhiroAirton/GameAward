using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StageClearDate
{
    public string stage; // ステージの名前
    public int StageNo; // ステージ番号
    public StageClearState State; // クリア状況

}

// ステージの扱い
public enum StageClearState
{
    NONE = 0, // ステージが未出現
    CHALLENGE = 1, // ステージ挑戦中
    CLEAR = 2   // ステージクリア
}