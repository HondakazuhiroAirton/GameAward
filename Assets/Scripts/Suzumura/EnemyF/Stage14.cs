using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage14 : MonoBehaviour
{
    public static EnemyData[] enemydatas = new EnemyData[] {
//***********************************************************
//  Phase1
//***********************************************************
        new EnemyData(){
            name = "enemy01",
            phase = Phase.phase1,
            StartPosX = 12,//はじめ
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//ビックリマーク
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,//出現時間
            model = "koa",
            category = EnemyCategory.typeNone,//球の速度
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,　　　　//state３速度
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
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
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
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy02
         new EnemyData(){
            name = "enemy03",
            phase = Phase.phase1,
            StartPosX = 12,//はじめ
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//ビックリマーク
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 4,//出現時間
            model = "koa",
            category = EnemyCategory.typeNone,//球の速度
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,　　　　//state３速度
             NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
          new EnemyData(){
            name = "enemy04",
            phase = Phase.phase1,
            StartPosX = 12,//はじめ
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = -2,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//ビックリマーク
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 6,//出現時間
            model = "koa",
            category = EnemyCategory.typeNone,//球の速度
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,　　　　//state３速度
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
            StartPosX = 12,//はじめ
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//ビックリマーク
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 8,//出現時間
            model = "koa",
            category = EnemyCategory.typeNone,//球の速度
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,　　　　//state３速度
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
          




 //＜＜＜フェーズ２ 
        new EnemyData(){
            name = "enemy06",
            phase = Phase.phase2,
            StartPosX = 12,//はじめ
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//ビックリマーク
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,//出現時間
            model = "koa",
            category = EnemyCategory.typeNone,//球の速度
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,　　　　//state３速度
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy07",
            phase = Phase.phase2,
            StartPosX = 12,//はじめ
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//ビックリマーク
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,//出現時間
            model = "koa",
            category = EnemyCategory.typeNone,//球の速度
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,　　　　//state３速度
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy08",
            phase = Phase.phase2,
            StartPosX = 12,//はじめ
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//ビックリマーク
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,//出現時間
            model = "koa",
            category = EnemyCategory.typeNone,//球の速度
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,　　　　//state３速度
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy09",
            phase = Phase.phase2,
            StartPosX = 12,//はじめ
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//ビックリマーク
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,//出現時間
            model = "koa",
            category = EnemyCategory.typeNone,//球の速度
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,　　　　//state３速度
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy10",
            phase = Phase.phase2,
            StartPosX = 12,//はじめ
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//ビックリマーク
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,//出現時間
            model = "koa",
            category = EnemyCategory.typeNone,//球の速度
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,　　　　//state３速度
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy11",
            phase = Phase.phase2,
            StartPosX = 12,//はじめ
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//ビックリマーク
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,//出現時間
            model = "koa",
            category = EnemyCategory.typeNone,//球の速度
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,　　　　//state３速度
            NextStep2 = 4,
            Data2 = 5,
            NextStep3 = -1,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
    };
}