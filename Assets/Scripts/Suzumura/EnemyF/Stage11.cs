using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage11 : MonoBehaviour
{
    public EnemyData[] enemydatas;

    private void Awake()
    {
        enemydatas = new EnemyData[]{
        new EnemyData(){
            name = "enemy01",
            category = EnemyCategory.type1,
            phase = Phase.phase1,
            Size = 0.1f,
            StartPosX = 0,
            StartPosY = 0,
            StartPosZ = 0,
            EntryPosX = 0,
            EntryPosY = 0,
            EntryPosZ = 0,
            sideNo = 1,
            Target1PosX = 0,
            Target1PosY = 0,
            Target1PosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            model = "koa",
            AppearanceTime = 0.0f,
            State = 0,
            NextState1 = 1,
            NextState2 = 2,
            NextState3 = 3,
            NextState4 = 4,
            NextState5 = -1
        },
        new EnemyData(){
            name = "enemy02",
            category = EnemyCategory.type2,
            phase = Phase.phase1,
            Size = 0.1f,
            StartPosX = 0,
            StartPosY = 0,
            StartPosZ = 0,
            EntryPosX = 0,
            EntryPosY = 0,
            EntryPosZ = 0,
            sideNo = 1,
            Target1PosX = 0,
            Target1PosY = 0,
            Target1PosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            model = "koa",
            AppearanceTime = 0.2f,
            State = 0,
            NextState1 = 1,
            NextState2 = 2,
            NextState3 = 3,
            NextState4 = 4,
            NextState5 = -1
        },
    };
    }

}

