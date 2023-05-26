using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage13 : MonoBehaviour
{
    public static EnemyData[] enemydatas = new EnemyData[]
    {
//***********************************************************
//  Phase1
//***********************************************************
        new EnemyData(){
            name = "enemy01",
            phase = Phase.phase1,
            StartPosX = 12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextState1 = 3,
            Data1 = 3,
            NextState2 = 4,
            Data2 = 5,
            NextState3 = -1,
            NextState4 = -1,
            NextState5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy02",
            phase = Phase.phase1,
            StartPosX = -12,
            StartPosY = -3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -1,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = -8.1f,
            EntryPosY = -2,
            sideNo = 4,
            AppearanceTime = 1,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextState1 = 3,
            Data1 = 3,
            NextState2 = 4,
            Data2 = 5,
            NextState3 = -1,
            NextState4 = -1,
            NextState5 = -1
        },  // enemy02
        new EnemyData(){
            name = "enemy03",
            phase = Phase.phase1,
            StartPosX = -12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = -8.1f,
            EntryPosY = 2,
            sideNo = 4,
            AppearanceTime = 2,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextState1 = 3,
            Data1 = 3,
            NextState2 = 4,
            Data2 = 5,
            NextState3 = -1,
            NextState4 = -1,
            NextState5 = -1
        },  // enemy03
        new EnemyData(){
            name = "enemy04",
            phase = Phase.phase1,
            StartPosX = 12,
            StartPosY = -3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 1,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = -2,
            sideNo = 2,
            AppearanceTime = 3,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextState1 = 3,
            Data1 = 3,
            NextState2 = 4,
            Data2 = 5,
            NextState3 = -1,
            NextState4 = -1,
            NextState5 = -1
        },  // enemy04
        new EnemyData(){
            name = "enemy05",
            phase = Phase.phase1,
            StartPosX = 12,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = -2,
            FirstPosY = 1,
            FirstPosZ = 0,
            TargetPosX = 2,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 0,
            sideNo = 2,
            AppearanceTime = 4,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextState1 = 3,
            Data1 = 3,
            NextState2 = 4,
            Data2 = 5,
            NextState3 = -1,
            NextState4 = -1,
            NextState5 = -1
        },  // enemy05

    };
}

