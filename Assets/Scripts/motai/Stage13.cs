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
            TargetPosX = 0,
            TargetPosY = -1,
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
            NextStep2 = 5,
            Data2 = 7,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
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
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 7,
            NextStep3 = 4,
            Data3 = 5,
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
            TargetPosX = 0,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = -8.1f,
            EntryPosY = 2,
            sideNo = 4,
            AppearanceTime = 2,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 7,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
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
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 7,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
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
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 0,
            sideNo = 2,
            AppearanceTime = 4,
            model = "koa",
            category = EnemyCategory.type1,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 7,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy05

//***********************************************************
//  Phase2
//***********************************************************
        new EnemyData(){
            name = "enemy06",
            phase = Phase.phase2,
            StartPosX = 12,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 5,
            TargetPosY = 2,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 0,
            sideNo = 2,
            AppearanceTime = 2,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 7,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy06
        new EnemyData(){
            name = "enemy07",
            phase = Phase.phase2,
            StartPosX = 12,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 4,
            TargetPosY = 2,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 0,
            sideNo = 4,
            AppearanceTime = 1,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 7,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy07
        new EnemyData(){
            name = "enemy08",
            phase = Phase.phase2,
            StartPosX = 12,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 3,
            TargetPosY = 2,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 0,
            sideNo = 4,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 7,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy08
        new EnemyData(){
            name = "enemy09",
            phase = Phase.phase2,
            StartPosX = 12,
            StartPosY = -3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 5,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = -2,
            sideNo = 2,
            AppearanceTime = 2,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 7,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy09
        new EnemyData(){
            name = "enemy10",
            phase = Phase.phase2,
            StartPosX = 12,
            StartPosY = -3,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 4,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = -2,
            sideNo = 2,
            AppearanceTime = 1,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 7,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy10
        new EnemyData(){
            name = "enemy11",
            phase = Phase.phase2,
            StartPosX = 12,
            StartPosY = -3,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 3,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = -2,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 7,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy11
        new EnemyData(){
            name = "enemy12",
            phase = Phase.phase2,
            StartPosX = -12,
            StartPosY = -3,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -5,
            TargetPosY = -2,
            TargetPosZ = 0,
            EntryPosX = -8.1f,
            EntryPosY = -2,
            sideNo = 2,
            AppearanceTime = 2,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 7,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
        new EnemyData(){
            name = "enemy13",
            phase = Phase.phase2,
            StartPosX = -12,
            StartPosY = -3,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -4,
            TargetPosY = -2,
            TargetPosZ = 0,
            EntryPosX = -8.1f,
            EntryPosY = -2,
            sideNo = 2,
            AppearanceTime = 1,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 7,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy13
        new EnemyData(){
            name = "enemy14",
            phase = Phase.phase2,
            StartPosX = -12,
            StartPosY = -3,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -3,
            TargetPosY = -2,
            TargetPosZ = 0,
            EntryPosX = -8.1f,
            EntryPosY = -2,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 7,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy14
        new EnemyData(){
            name = "enemy15",
            phase = Phase.phase2,
            StartPosX = -12,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -5,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = -8.1f,
            EntryPosY = 0,
            sideNo = 2,
            AppearanceTime = 2,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 7,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy15
        new EnemyData(){
            name = "enemy16",
            phase = Phase.phase2,
            StartPosX = -12,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -4,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = -8.1f,
            EntryPosY = 0,
            sideNo = 2,
            AppearanceTime = 1,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 7,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy16
        new EnemyData(){
            name = "enemy17",
            phase = Phase.phase2,
            StartPosX = -12,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -3,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = -8.1f,
            EntryPosY = 0,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 7,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy17
        
//***********************************************************
//  Phase3
//***********************************************************
        new EnemyData(){
            name = "enemy18",
            phase = Phase.phase3,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -3,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 2,
            AppearanceTime = 6,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 8,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy18
        new EnemyData(){
            name = "enemy19",
            phase = Phase.phase3,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX =-2,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 4,
            AppearanceTime = 5,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 8,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy19
        new EnemyData(){
            name = "enemy20",
            phase = Phase.phase3,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -1,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 4,
            AppearanceTime = 4,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 8,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy20
        new EnemyData(){
            name = "enemy21",
            phase = Phase.phase3,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 2,
            AppearanceTime = 3,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 8,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy21
        new EnemyData(){
            name = "enemy22",
            phase = Phase.phase3,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 1,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 2,
            AppearanceTime = 2,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 8,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy22
        new EnemyData(){
            name = "enemy23",
            phase = Phase.phase3,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 2,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 2,
            AppearanceTime = 1,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 8,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy23
        new EnemyData(){
            name = "enemy24",
            phase = Phase.phase3,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 3,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 8,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy24
        new EnemyData(){
            name = "enemy25",
            phase = Phase.phase3,
            StartPosX = -12,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = -8.1f,
            EntryPosY = 0,
            sideNo = 2,
            AppearanceTime = 6,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 8,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy25
        new EnemyData(){
            name = "enemy26",
            phase = Phase.phase3,
            StartPosX = -12,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = -2,
            TargetPosZ = 0,
            EntryPosX = -8.1f,
            EntryPosY = 0,
            sideNo = 2,
            AppearanceTime = 4,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 8,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy26
        new EnemyData(){
            name = "enemy27",
            phase = Phase.phase3,
            StartPosX = -12,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = -8.1f,
            EntryPosY = 0,
            sideNo = 2,
            AppearanceTime = 2,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 8,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy27
        new EnemyData(){
            name = "enemy28",
            phase = Phase.phase3,
            StartPosX = -12,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = -8.1f,
            EntryPosY = 0,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 8,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy28

//***********************************************************
//  Phase4
//***********************************************************
        new EnemyData(){
            name = "enemy29",
            phase = Phase.phase4,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -3,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 2,
            AppearanceTime = 6,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 8,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy29
        new EnemyData(){
            name = "enemy30",
            phase = Phase.phase4,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX =-2,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 4,
            AppearanceTime = 5,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 8,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy30
        new EnemyData(){
            name = "enemy31",
            phase = Phase.phase4,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -1,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 4,
            AppearanceTime = 4,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 8,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy31
        new EnemyData(){
            name = "enemy32",
            phase = Phase.phase4,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 2,
            AppearanceTime = 3,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 8,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy32
        new EnemyData(){
            name = "enemy33",
            phase = Phase.phase4,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 1,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 2,
            AppearanceTime = 2,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 8,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy33
        new EnemyData(){
            name = "enemy34",
            phase = Phase.phase4,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 2,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 2,
            AppearanceTime = 1,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 8,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy34
        new EnemyData(){
            name = "enemy35",
            phase = Phase.phase4,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 3,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 8,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy35
        new EnemyData(){
            name = "enemy36",
            phase = Phase.phase4,
            StartPosX = -12,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = -8.1f,
            EntryPosY = 0,
            sideNo = 2,
            AppearanceTime = 6,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 8,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy36
        new EnemyData(){
            name = "enemy37",
            phase = Phase.phase4,
            StartPosX = -12,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = -2,
            TargetPosZ = 0,
            EntryPosX = -8.1f,
            EntryPosY = 0,
            sideNo = 2,
            AppearanceTime = 4,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 8,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy37
        new EnemyData(){
            name = "enemy38",
            phase = Phase.phase4,
            StartPosX = -12,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = -8.1f,
            EntryPosY = 0,
            sideNo = 2,
            AppearanceTime = 2,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 8,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy38
        new EnemyData(){
            name = "enemy39",
            phase = Phase.phase4,
            StartPosX = -12,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = -8.1f,
            EntryPosY = 0,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 8,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy39
        new EnemyData(){
            name = "enemy40",
            phase = Phase.phase4,
            StartPosX = -12,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 2,
            TargetPosZ = 0,
            EntryPosX = -8.1f,
            EntryPosY = 0,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 8,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy39
    };
}

