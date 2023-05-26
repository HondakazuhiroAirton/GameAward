using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage21 : MonoBehaviour
{
    public static EnemyData[] enemydatas = new EnemyData[] {
//***********************************************************
//  Phase1
//***********************************************************
        new EnemyData(){
            name = "enemy01",
            phase = Phase.phase1,
            StartPosX = -12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 7,
            TargetPosY = -2,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy02",
            phase = Phase.phase1,
            StartPosX = -12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 8,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 1,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
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
            TargetPosX = 1,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 2,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy03
        new EnemyData(){
            name = "enemy04",
            phase = Phase.phase1,
            StartPosX = -12,
            StartPosY = -3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 7,
            TargetPosY = 2,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy04
        new EnemyData(){
            name = "enemy05",
            phase = Phase.phase1,
            StartPosX = -12,
            StartPosY = -3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = -2,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 1,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy05
        new EnemyData(){
            name = "enemy06",
            phase = Phase.phase1,
            StartPosX = -12,
            StartPosY = -3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -8,
            TargetPosY = -5,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 2,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy06

//***********************************************************
//  Phase2
//***********************************************************
new EnemyData(){
            name = "enemy07",
            phase = Phase.phase2,
            StartPosX = -12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 9,
            TargetPosY = 5,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy07
new EnemyData(){
            name = "enemy08",
            phase = Phase.phase2,
            StartPosX = -12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 5,
            TargetPosY = 2,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy08
new EnemyData(){
            name = "enemy09",
            phase = Phase.phase2,
            StartPosX = -12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 5,
            TargetPosY = -2,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy09
new EnemyData(){
            name = "enemy10",
            phase = Phase.phase2,
            StartPosX = -12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 9,
            TargetPosY = -5,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy10
new EnemyData(){
            name = "enemy11",
            phase = Phase.phase2,
            StartPosX = -12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -9,
            TargetPosY = -5,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy11
new EnemyData(){
            name = "enemy12",
            phase = Phase.phase2,
            StartPosX = -12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -5,
            TargetPosY = -2,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
new EnemyData(){
            name = "enemy13",
            phase = Phase.phase2,
            StartPosX = -12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -5,
            TargetPosY = 2,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy13
new EnemyData(){
            name = "enemy14",
            phase = Phase.phase2,
            StartPosX = -12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -9,
            TargetPosY = 5,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy14
//***********************************************************
//  Phase3
//***********************************************************
new EnemyData(){
            name = "enemy15",
            phase = Phase.phase3,
            StartPosX = -12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 9,
            TargetPosY = 4,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy15
new EnemyData(){
            name = "enemy16",
            phase = Phase.phase3,
            StartPosX = -12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 5,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy16
new EnemyData(){
            name = "enemy17",
            phase = Phase.phase3,
            StartPosX = -12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 1,
            TargetPosY = -5,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy17
new EnemyData(){
            name = "enemy18",
            phase = Phase.phase3,
            StartPosX = -12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -1,
            TargetPosY = -5,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy18
new EnemyData(){
            name = "enemy19",
            phase = Phase.phase3,
            StartPosX = -12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -5,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy19
new EnemyData(){
            name = "enemy20",
            phase = Phase.phase3,
            StartPosX = -12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -9,
            TargetPosY = 4,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy20

    };
}