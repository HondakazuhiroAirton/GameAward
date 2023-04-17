using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MonsterData
{
    public string name;
    public int HP;
    public int ATK;
    public int DEF;

    public MonsterCategory category;
    public Sprite sprite;
    public string[] skill;
}

public enum MonsterCategory
{
    amorphous = 1,
    demihuman = 2,
    beast = 3
}