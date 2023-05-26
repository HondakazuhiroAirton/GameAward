using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//***********************************************************
//  委員長が考えた簡単ステージ１－２３４５候補
//***********************************************************

public class Stage15 : MonoBehaviour
{
    public static EnemyData[] enemydatas = new EnemyData[] {
//***********************************************************
//  Phase1
//***********************************************************
 //右から  ３体　まっすぐ
        new EnemyData(){
            name = "enemy01",
            phase = Phase.phase1,
            StartPosX = 12,
            StartPosY = 1,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -4,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 1,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 5,　　　　//state３速度
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy02",
            phase = Phase.phase1,
            StartPosX = 12,
            StartPosY = 1,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 1,
            sideNo = 2,
            AppearanceTime = 1,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 5,　　　　//state３速度
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy03",
            phase = Phase.phase1,
            StartPosX = 12,
            StartPosY = 1,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 1,
            sideNo = 2,
            AppearanceTime = 2,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
             NextStep1 = 3,
            Data1 = 5,　　　　//state３速度
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01

//左から３体まっすぐ
 new EnemyData(){
            name = "enemy04",
            phase = Phase.phase1,
            StartPosX = -12,
            StartPosY = -2,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 4,
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
            Data1 = 5,　　　　//state３速度
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy05",
            phase = Phase.phase1,
            StartPosX = -12,
            StartPosY = -2,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 2,
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
            Data1 = 5,　　　　//state３速度
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy06",
            phase = Phase.phase1,
            StartPosX = -12,
            StartPosY = -2,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
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
            Data1 = 5,　　　　//state３速度
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01

//***********************************************************
//  Phase2
//***********************************************************
    
//下から一気にでます！！
//少し上で横一列
        new EnemyData(){
            name = "enemy07",
            phase = Phase.phase2,
            StartPosX = 0,
            StartPosY = -8,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = -4,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 5,　　　　//state３速度
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01

          new EnemyData(){
            name = "enemy08",
            phase = Phase.phase2,
            StartPosX = -4,
            StartPosY = -8,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -4,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = -4f,
            EntryPosY = -4,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 5,　　　　//state３速度
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01

           new EnemyData(){
            name = "enemy09",
            phase = Phase.phase2,
            StartPosX = 4,
            StartPosY = -8,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 4,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 4f,
            EntryPosY = -4,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 5,　　　　//state３速度
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01

 //遅れてくるよ！
       new EnemyData(){
            name = "enemy10",
            phase = Phase.phase2,
            StartPosX = -2,
            StartPosY = -8,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = -2f,
            EntryPosY = -4,
            sideNo = 1,
            AppearanceTime = 2,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 8,　　　　//state３速度
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01

     new EnemyData(){
            name = "enemy11",
            phase = Phase.phase2,
            StartPosX = 2,
            StartPosY = -8,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 2,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 2f,
            EntryPosY = -4,
            sideNo = 1,
            AppearanceTime = 2,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 8,　　　　//state３速度
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01

//***********************************************************
//  Phase3
//***********************************************************
   //右から一気にでるよ！！
   //左のほうに縦一列
        new EnemyData(){
            name = "enemy12",
            phase = Phase.phase3,
            StartPosX = 12,
            StartPosY = 2,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -2,
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
            Data1 = 5,
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01

         new EnemyData(){
            name = "enemy13",
            phase = Phase.phase3,
            StartPosX = 12,
            StartPosY = 1,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 1,
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
            name = "enemy14",
            phase = Phase.phase3,
            StartPosX = 12,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 0,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 5,
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01

         new EnemyData(){
            name = "enemy15",
            phase = Phase.phase3,
            StartPosX = 12,
            StartPosY = -1,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = -1,
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
            name = "enemy16",
            phase = Phase.phase3,
            StartPosX = 12,
            StartPosY = -1,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = -2,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = -2,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 5,
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01

//***********************************************************
//  Phase4
//***********************************************************
         new EnemyData(){
            name = "enemy04",
            phase = Phase.phase4,
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
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01

//***********************************************************
//  Phase5
//***********************************************************
         new EnemyData(){
            name = "enemy05",
            phase = Phase.phase5,
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
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
    };
}