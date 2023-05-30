// 0527_三浦瞬作成中
// テーマはおふれのせきしつ

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage45 : MonoBehaviour
{
    public static EnemyData[] enemydatas = new EnemyData[] {
//***********************************************************
//  Phase1
//***********************************************************
 //a      
        new EnemyData(){
            name = "enemy01",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 2,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
   new EnemyData(){
            name = "enemy22",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 2,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
   new EnemyData(){
            name = "enemy23",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
      new EnemyData(){
            name = "enemy222",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 1,
            TargetPosY = 2,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
   new EnemyData(){
            name = "enemy233",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -1,
            TargetPosY = 2,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
  new EnemyData(){
            name = "enemy02",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 2,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
   new EnemyData(){
            name = "enemy03",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
    new EnemyData(){
            name = "enemy04",
            phase = Phase.phase1,
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
            sideNo = 3,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
   new EnemyData(){
            name = "enemy05",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
    new EnemyData(){
            name = "enemy44",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 2,
            TargetPosY = -2,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
   new EnemyData(){
            name = "enemy55",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = -2,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
    new EnemyData(){
            name = "enemy444",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 1,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
   new EnemyData(){
            name = "enemy555",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -1,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
    new EnemyData(){
            name = "enemy06",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
      new EnemyData(){
            name = "enemy77",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 3,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
     new EnemyData(){
            name = "enemy777",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 3,
            TargetPosY = 2,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
      new EnemyData(){
            name = "enemy07",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 4,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
//u
   new EnemyData(){
            name = "enemyu2",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 2,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 10,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
   new EnemyData(){
            name = "enemyu3",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 10,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
  new EnemyData(){
            name = "enemyuuu2",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 2,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 10,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
   new EnemyData(){
            name = "enemyuuu3",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 10,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
    new EnemyData(){
            name = "enemyu4",
            phase = Phase.phase1,
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
            sideNo = 3,
            AppearanceTime =10,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
   new EnemyData(){
            name = "enemyu5",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 10,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
    new EnemyData(){
            name = "enemyu44",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 2,
            TargetPosY = -2,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 10,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
   new EnemyData(){
            name = "enemyu55",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = -2,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 10,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
    new EnemyData(){
            name = "enemyu444",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 1,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 10,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
   new EnemyData(){
            name = "enemyu555",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -1,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 10,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
    new EnemyData(){
            name = "enemyu06",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 10,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
      new EnemyData(){
            name = "enemyu77",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 3,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 10,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
      new EnemyData(){
            name = "enemyu07",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 4,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 10,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
//r
     new EnemyData(){
            name = "enemyr01",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -1,
            TargetPosY = 2,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 20,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
       new EnemyData(){
            name = "enemyr02",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -1,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 20,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
          new EnemyData(){
            name = "enemyr03",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -1,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 20,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
      new EnemyData(){
            name = "enemyr04",
            phase = Phase.phase1,
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
            sideNo = 3,
            AppearanceTime = 20,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
         new EnemyData(){
            name = "enemyr05",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -1,
            TargetPosY = -2,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 20,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
         new EnemyData(){
            name = "enemyr06",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -1,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 20,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
      new EnemyData(){
            name = "enemyr77",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 20,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
       new EnemyData(){
            name = "enemyr777",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 2,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 20,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
      new EnemyData(){
            name = "enemyr07",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 1,
            TargetPosY = 2,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 20,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
//o
      new EnemyData(){
            name = "enemyo01",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 2,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 30,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
   new EnemyData(){
            name = "enemyo22",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 2,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 30,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
   new EnemyData(){
            name = "enemyo23",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 30,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
      new EnemyData(){
            name = "enemyo222",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 1,
            TargetPosY = 2,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 30,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
   new EnemyData(){
            name = "enemyo233",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -1,
            TargetPosY = 2,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 30,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
  new EnemyData(){
            name = "enemyo02",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 2,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 30,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
   new EnemyData(){
            name = "enemyo03",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 30,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
    new EnemyData(){
            name = "enemyo04",
            phase = Phase.phase1,
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
            sideNo = 3,
            AppearanceTime = 30,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
   new EnemyData(){
            name = "enemyo05",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 30,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
    new EnemyData(){
            name = "enemyo44",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 2,
            TargetPosY = -2,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 30,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
   new EnemyData(){
            name = "enemyo55",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = -2,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 30,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
    new EnemyData(){
            name = "enemyo444",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 1,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 30,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
   new EnemyData(){
            name = "enemyo555",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -1,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 30,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
    new EnemyData(){
            name = "enemyo06",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 30,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12

 //r
     new EnemyData(){
            name = "enemyrr01",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -1,
            TargetPosY = 2,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 40,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
       new EnemyData(){
            name = "enemyrr02",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -1,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 40,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
          new EnemyData(){
            name = "enemyrr03",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -1,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 40,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
      new EnemyData(){
            name = "enemyrr04",
            phase = Phase.phase1,
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
            sideNo = 3,
            AppearanceTime = 40,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
         new EnemyData(){
            name = "enemyrr05",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -1,
            TargetPosY = -2,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 40,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
         new EnemyData(){
            name = "enemyrr06",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -1,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 40,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
      new EnemyData(){
            name = "enemyrr77",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 40,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
       new EnemyData(){
            name = "enemyrr777",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 2,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 40,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
      new EnemyData(){
            name = "enemyrr07",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 1,
            TargetPosY = 2,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 40,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12

      //a      
        new EnemyData(){
            name = "enemya01",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 2,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 50,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
   new EnemyData(){
            name = "enemya22",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 2,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 50,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
   new EnemyData(){
            name = "enemya23",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 50,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
      new EnemyData(){
            name = "enemya222",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 1,
            TargetPosY = 2,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 50,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
   new EnemyData(){
            name = "enemya233",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -1,
            TargetPosY = 2,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 50,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
  new EnemyData(){
            name = "enemya02",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 2,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 50,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
   new EnemyData(){
            name = "enemya03",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 50,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
    new EnemyData(){
            name = "enemya04",
            phase = Phase.phase1,
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
            sideNo = 3,
            AppearanceTime = 50,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
   new EnemyData(){
            name = "enemya05",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 50,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
    new EnemyData(){
            name = "enemya44",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 2,
            TargetPosY = -2,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime =50,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
   new EnemyData(){
            name = "enemya55",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = -2,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 50,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
    new EnemyData(){
            name = "enemya444",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 1,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 50,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
   new EnemyData(){
            name = "enemya555",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = -1,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 50,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
    new EnemyData(){
            name = "enemya06",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 50,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
      new EnemyData(){
            name = "enemy7a7",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 3,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 50,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
     new EnemyData(){
            name = "enemya777",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 3,
            TargetPosY = 2,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 50,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
      new EnemyData(){
            name = "enemya07",
            phase = Phase.phase1,
            StartPosX = 0,
            StartPosY = 6,
            StartPosZ = 0,
            FirstPosX = 0,
            FirstPosY = 3,
            FirstPosZ = 0,
            TargetPosX = 4,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 3,
            AppearanceTime = 50,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,
            NextStep2 = 5,
            Data2 = 5,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy12
//<<Phase2
  new EnemyData(){ name = "enemy2_3",  phase = Phase.phase2,
// 出現位置
            StartPosX = -7,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_4",  phase = Phase.phase2,
// 出現位置
            StartPosX = -6,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_5",  phase = Phase.phase2,
// 出現位置
            StartPosX = -5,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_6",  phase = Phase.phase2,
// 出現位置
            StartPosX = -4,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_7",  phase = Phase.phase2,
// 出現位置
            StartPosX = -3,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_8",  phase = Phase.phase2,
// 出現位置
            StartPosX = -2,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_9",  phase = Phase.phase2,
// 出現位置
            StartPosX = -1,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_10",  phase = Phase.phase2,
// 出現位置
            StartPosX = 0,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_11",  phase = Phase.phase2,
// 出現位置
            StartPosX = 1,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_12",  phase = Phase.phase2,
// 出現位置
            StartPosX = 2,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_13",  phase = Phase.phase2,
// 出現位置
            StartPosX = 3,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_14",  phase = Phase.phase2,
// 出現位置
            StartPosX = 4,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_15",  phase = Phase.phase2,
// 出現位置
            StartPosX = 5,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_16",  phase = Phase.phase2,
// 出現位置
            StartPosX = 6,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_17",  phase = Phase.phase2,
// 出現位置
            StartPosX = 7,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_22",  phase = Phase.phase2,
// 出現位置
            StartPosX = -7,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_23",  phase = Phase.phase2,
// 出現位置
            StartPosX = -6,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_24",  phase = Phase.phase2,
// 出現位置
            StartPosX = -5,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_25",  phase = Phase.phase2,
// 出現位置
            StartPosX = -4,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_26",  phase = Phase.phase2,
// 出現位置
            StartPosX = -3,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_27",  phase = Phase.phase2,
// 出現位置
            StartPosX = -2,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_28",  phase = Phase.phase2,
// 出現位置
            StartPosX = -1,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_29",  phase = Phase.phase2,
// 出現位置
            StartPosX = 0,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_30",  phase = Phase.phase2,
// 出現位置
            StartPosX = 1,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_31",  phase = Phase.phase2,
// 出現位置
            StartPosX = 2,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_32",  phase = Phase.phase2,
// 出現位置
            StartPosX = 3,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_33",  phase = Phase.phase2,
// 出現位置
            StartPosX = 4,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_34",  phase = Phase.phase2,
// 出現位置
            StartPosX = 5,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_35",  phase = Phase.phase2,
// 出現位置
            StartPosX = 6,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_36",  phase = Phase.phase2,
// 出現位置
            StartPosX = 7,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_41",  phase = Phase.phase2,
// 出現位置
            StartPosX = -7,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_42",  phase = Phase.phase2,
// 出現位置
            StartPosX = -6,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_43",  phase = Phase.phase2,
// 出現位置
            StartPosX = -5,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_44",  phase = Phase.phase2,
// 出現位置
            StartPosX = -4,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_45",  phase = Phase.phase2,
// 出現位置
            StartPosX = -3,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位Z
            TargetPosX = -3,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_46",  phase = Phase.phase2,
// 出現位置
            StartPosX = -2,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_47",  phase = Phase.phase2,
// 出現位置
            StartPosX = -1,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_48",  phase = Phase.phase2,
// 出現位置
            StartPosX = 0,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_49",  phase = Phase.phase2,
// 出現位置
            StartPosX = 1,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_50",  phase = Phase.phase2,
// 出現位置
            StartPosX = 2,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_51",  phase = Phase.phase2,
// 出現位置
            StartPosX = 3,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_52",  phase = Phase.phase2,
// 出現位置
            StartPosX = 4,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_53",  phase = Phase.phase2,
// 出現位置
            StartPosX = 5,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_54",  phase = Phase.phase2,
// 出現位置
            StartPosX = 6,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_55",  phase = Phase.phase2,
// 出現位置
            StartPosX = 7,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_60",  phase = Phase.phase2,
// 出現位置
            StartPosX = -7,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_61",  phase = Phase.phase2,
// 出現位置
            StartPosX = -6,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_62",  phase = Phase.phase2,
// 出現位置
            StartPosX = -5,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_63",  phase = Phase.phase2,
// 出現位置
            StartPosX = -4,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_64",  phase = Phase.phase2,
// 出現位置
            StartPosX = -3,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_65",  phase = Phase.phase2,
// 出現位置
            StartPosX = -2,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_66",  phase = Phase.phase2,
// 出現位置
            StartPosX = -1,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_67",  phase = Phase.phase2,
// 出現位置
            StartPosX = 0,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_68",  phase = Phase.phase2,
// 出現位置
            StartPosX = 1,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_69",  phase = Phase.phase2,
// 出現位置
            StartPosX = 2,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy2_70",  phase = Phase.phase2,
// 出現位置
            StartPosX = 3,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_71",  phase = Phase.phase2,
// 出現位置
            StartPosX = 4,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_72",  phase = Phase.phase2,
// 出現位置
            StartPosX = 5,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_73",  phase = Phase.phase2,
// 出現位置
            StartPosX = 6,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_74",  phase = Phase.phase2,
// 出現位置
            StartPosX = 7,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy2_79",  phase = Phase.phase2,
// 出現位置
            StartPosX = -7,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_80",  phase = Phase.phase2,
// 出現位置
            StartPosX = -6,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_81",  phase = Phase.phase2,
// 出現位置
            StartPosX = -5,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy2_82",  phase = Phase.phase2,
// 出現位置
            StartPosX = -4,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_83",  phase = Phase.phase2,
// 出現位置
            StartPosX = -3,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_84",  phase = Phase.phase2,
// 出現位置
            StartPosX = -2,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_85",  phase = Phase.phase2,
// 出現位置
            StartPosX = -1,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_86",  phase = Phase.phase2,
// 出現位置
            StartPosX = 0,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_87",  phase = Phase.phase2,
// 出現位置
            StartPosX = 1,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_88",  phase = Phase.phase2,
// 出現位置
            StartPosX = 2,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy2_89",  phase = Phase.phase2,
// 出現位置
            StartPosX = 3,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_90",  phase = Phase.phase2,
// 出現位置
            StartPosX = 4,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_91",  phase = Phase.phase2,
// 出現位置
            StartPosX = 5,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_92",  phase = Phase.phase2,
// 出現位置
            StartPosX = 6,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_93",  phase = Phase.phase2,
// 出現位置
            StartPosX = 7,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_98",  phase = Phase.phase2,
// 出現位置
            StartPosX = -7,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_99",  phase = Phase.phase2,
// 出現位置
            StartPosX = -6,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_100",  phase = Phase.phase2,
// 出現位置
            StartPosX = -5,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy2_101",  phase = Phase.phase2,
// 出現位置
            StartPosX = -4,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_102",  phase = Phase.phase2,
// 出現位置
            StartPosX = -3,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_103",  phase = Phase.phase2,
// 出現位置
            StartPosX = -2,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "eneme104",  phase = Phase.phase2,
// 出現位置
            StartPosX = -1,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_105",  phase = Phase.phase2,
// 出現位置
            StartPosX = 0,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_106",  phase = Phase.phase2,
// 出現位置
            StartPosX = 1,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_107",  phase = Phase.phase2,
// 出現位置
            StartPosX = 2,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy2_108",  phase = Phase.phase2,
// 出現位置
            StartPosX = 3,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_109",  phase = Phase.phase2,
// 出現位置
            StartPosX = 4,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_110",  phase = Phase.phase2,
// 出現位置
            StartPosX = 5,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_111",  phase = Phase.phase2,
// 出現位置
            StartPosX = 6,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_112",  phase = Phase.phase2,
// 出現位置
            StartPosX = 7,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_117",  phase = Phase.phase2,
// 出現位置
            StartPosX = -7,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_118",  phase = Phase.phase2,
// 出現位置
            StartPosX = -6,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_119",  phase = Phase.phase2,
// 出現位置
            StartPosX = -5,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy2_120",  phase = Phase.phase2,
// 出現位置
            StartPosX = -4,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_121",  phase = Phase.phase2,
// 出現位置
            StartPosX = -3,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_122",  phase = Phase.phase2,
// 出現位置
            StartPosX = -2,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_123",  phase = Phase.phase2,
// 出現位置
            StartPosX = -1,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_124",  phase = Phase.phase2,
// 出現位置
            StartPosX = 0,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_125",  phase = Phase.phase2,
// 出現位置
            StartPosX = 1,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_126",  phase = Phase.phase2,
// 出現位置
            StartPosX = 2,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy2_127",  phase = Phase.phase2,
// 出現位置
            StartPosX = 3,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_128",  phase = Phase.phase2,
// 出現位置
            StartPosX = 4,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_129",  phase = Phase.phase2,
// 出現位置
            StartPosX = 5,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_130",  phase = Phase.phase2,
// 出現位置
            StartPosX = 6,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_131",  phase = Phase.phase2,
// 出現位置
            StartPosX = 7,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_136",  phase = Phase.phase2,
// 出現位置
            StartPosX = -7,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_137",  phase = Phase.phase2,
// 出現位置
            StartPosX = -6,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_138",  phase = Phase.phase2,
// 出現位置
            StartPosX = -5,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy2_139",  phase = Phase.phase2,
// 出現位置
            StartPosX = -4,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_140",  phase = Phase.phase2,
// 出現位置
            StartPosX = -3,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_141",  phase = Phase.phase2,
// 出現位置
            StartPosX = -2,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_142",  phase = Phase.phase2,
// 出現位置
            StartPosX = -1,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_143",  phase = Phase.phase2,
// 出現位置
            StartPosX = 0,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_144",  phase = Phase.phase2,
// 出現位置
            StartPosX = 1,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_145",  phase = Phase.phase2,
// 出現位置
            StartPosX = 2,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy2_146",  phase = Phase.phase2,
// 出現位置
            StartPosX = 3,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_147",  phase = Phase.phase2,
// 出現位置
            StartPosX = 4,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_148",  phase = Phase.phase2,
// 出現位置
            StartPosX = 5,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_149",  phase = Phase.phase2,
// 出現位置
            StartPosX = 6,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy2_150",  phase = Phase.phase2,
// 出現位置
            StartPosX = 7,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },
//<<Phase3
  new EnemyData(){ name = "enemy3_3",  phase = Phase.phase3,
// 出現位置
            StartPosX = -7,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_4",  phase = Phase.phase3,
// 出現位置
            StartPosX = -6,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_5",  phase = Phase.phase3,
// 出現位置
            StartPosX = -5,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_6",  phase = Phase.phase3,
// 出現位置
            StartPosX = -4,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_7",  phase = Phase.phase3,
// 出現位置
            StartPosX = -3,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_8",  phase = Phase.phase3,
// 出現位置
            StartPosX = -2,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_9",  phase = Phase.phase3,
// 出現位置
            StartPosX = -1,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_10",  phase = Phase.phase3,
// 出現位置
            StartPosX = 0,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_11",  phase = Phase.phase3,
// 出現位置
            StartPosX = 1,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_12",  phase = Phase.phase3,
// 出現位置
            StartPosX = 2,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_13",  phase = Phase.phase3,
// 出現位置
            StartPosX = 3,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_14",  phase = Phase.phase3,
// 出現位置
            StartPosX = 4,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_15",  phase = Phase.phase3,
// 出現位置
            StartPosX = 5,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_16",  phase = Phase.phase3,
// 出現位置
            StartPosX = 6,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_17",  phase = Phase.phase3,
// 出現位置
            StartPosX = 7,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_22",  phase = Phase.phase3,
// 出現位置
            StartPosX = -7,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_23",  phase = Phase.phase3,
// 出現位置
            StartPosX = -6,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_24",  phase = Phase.phase3,
// 出現位置
            StartPosX = -5,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_25",  phase = Phase.phase3,
// 出現位置
            StartPosX = -4,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_26",  phase = Phase.phase3,
// 出現位置
            StartPosX = -3,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_27",  phase = Phase.phase3,
// 出現位置
            StartPosX = -2,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_28",  phase = Phase.phase3,
// 出現位置
            StartPosX = -1,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_29",  phase = Phase.phase3,
// 出現位置
            StartPosX = 0,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_30",  phase = Phase.phase3,
// 出現位置
            StartPosX = 1,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_31",  phase = Phase.phase3,
// 出現位置
            StartPosX = 2,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_32",  phase = Phase.phase3,
// 出現位置
            StartPosX = 3,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_33",  phase = Phase.phase3,
// 出現位置
            StartPosX = 4,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_34",  phase = Phase.phase3,
// 出現位置
            StartPosX = 5,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_35",  phase = Phase.phase3,
// 出現位置
            StartPosX = 6,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_36",  phase = Phase.phase3,
// 出現位置
            StartPosX = 7,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_41",  phase = Phase.phase3,
// 出現位置
            StartPosX = -7,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_42",  phase = Phase.phase3,
// 出現位置
            StartPosX = -6,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_43",  phase = Phase.phase3,
// 出現位置
            StartPosX = -5,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_44",  phase = Phase.phase3,
// 出現位置
            StartPosX = -4,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_45",  phase = Phase.phase3,
// 出現位置
            StartPosX = -3,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位Z
            TargetPosX = -3,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_46",  phase = Phase.phase3,
// 出現位置
            StartPosX = -2,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_47",  phase = Phase.phase3,
// 出現位置
            StartPosX = -1,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_48",  phase = Phase.phase3,
// 出現位置
            StartPosX = 0,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_49",  phase = Phase.phase3,
// 出現位置
            StartPosX = 1,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_50",  phase = Phase.phase3,
// 出現位置
            StartPosX = 2,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_51",  phase = Phase.phase3,
// 出現位置
            StartPosX = 3,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_52",  phase = Phase.phase3,
// 出現位置
            StartPosX = 4,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_53",  phase = Phase.phase3,
// 出現位置
            StartPosX = 5,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_54",  phase = Phase.phase3,
// 出現位置
            StartPosX = 6,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_55",  phase = Phase.phase3,
// 出現位置
            StartPosX = 7,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_60",  phase = Phase.phase3,
// 出現位置
            StartPosX = -7,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_61",  phase = Phase.phase3,
// 出現位置
            StartPosX = -6,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_62",  phase = Phase.phase3,
// 出現位置
            StartPosX = -5,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_63",  phase = Phase.phase3,
// 出現位置
            StartPosX = -4,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_64",  phase = Phase.phase3,
// 出現位置
            StartPosX = -3,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_65",  phase = Phase.phase3,
// 出現位置
            StartPosX = -2,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_66",  phase = Phase.phase3,
// 出現位置
            StartPosX = -1,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_67",  phase = Phase.phase3,
// 出現位置
            StartPosX = 0,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_68",  phase = Phase.phase3,
// 出現位置
            StartPosX = 1,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_69",  phase = Phase.phase3,
// 出現位置
            StartPosX = 2,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy3_70",  phase = Phase.phase3,
// 出現位置
            StartPosX = 3,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_71",  phase = Phase.phase3,
// 出現位置
            StartPosX = 4,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_72",  phase = Phase.phase3,
// 出現位置
            StartPosX = 5,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_73",  phase = Phase.phase3,
// 出現位置
            StartPosX = 6,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_74",  phase = Phase.phase3,
// 出現位置
            StartPosX = 7,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy3_79",  phase = Phase.phase3,
// 出現位置
            StartPosX = -7,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_80",  phase = Phase.phase3,
// 出現位置
            StartPosX = -6,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_81",  phase = Phase.phase3,
// 出現位置
            StartPosX = -5,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy3_82",  phase = Phase.phase3,
// 出現位置
            StartPosX = -4,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_83",  phase = Phase.phase3,
// 出現位置
            StartPosX = -3,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_84",  phase = Phase.phase3,
// 出現位置
            StartPosX = -2,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_85",  phase = Phase.phase3,
// 出現位置
            StartPosX = -1,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_86",  phase = Phase.phase3,
// 出現位置
            StartPosX = 0,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_87",  phase = Phase.phase3,
// 出現位置
            StartPosX = 1,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_88",  phase = Phase.phase3,
// 出現位置
            StartPosX = 2,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy3_89",  phase = Phase.phase3,
// 出現位置
            StartPosX = 3,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_90",  phase = Phase.phase3,
// 出現位置
            StartPosX = 4,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_91",  phase = Phase.phase3,
// 出現位置
            StartPosX = 5,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_92",  phase = Phase.phase3,
// 出現位置
            StartPosX = 6,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_93",  phase = Phase.phase3,
// 出現位置
            StartPosX = 7,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_98",  phase = Phase.phase3,
// 出現位置
            StartPosX = -7,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_99",  phase = Phase.phase3,
// 出現位置
            StartPosX = -6,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_100",  phase = Phase.phase3,
// 出現位置
            StartPosX = -5,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy3_101",  phase = Phase.phase3,
// 出現位置
            StartPosX = -4,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_102",  phase = Phase.phase3,
// 出現位置
            StartPosX = -3,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_103",  phase = Phase.phase3,
// 出現位置
            StartPosX = -2,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "eneme104",  phase = Phase.phase3,
// 出現位置
            StartPosX = -1,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_105",  phase = Phase.phase3,
// 出現位置
            StartPosX = 0,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_106",  phase = Phase.phase3,
// 出現位置
            StartPosX = 1,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_107",  phase = Phase.phase3,
// 出現位置
            StartPosX = 2,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy3_108",  phase = Phase.phase3,
// 出現位置
            StartPosX = 3,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_109",  phase = Phase.phase3,
// 出現位置
            StartPosX = 4,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_110",  phase = Phase.phase3,
// 出現位置
            StartPosX = 5,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_111",  phase = Phase.phase3,
// 出現位置
            StartPosX = 6,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_112",  phase = Phase.phase3,
// 出現位置
            StartPosX = 7,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_117",  phase = Phase.phase3,
// 出現位置
            StartPosX = -7,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_118",  phase = Phase.phase3,
// 出現位置
            StartPosX = -6,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_119",  phase = Phase.phase3,
// 出現位置
            StartPosX = -5,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy3_120",  phase = Phase.phase3,
// 出現位置
            StartPosX = -4,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_121",  phase = Phase.phase3,
// 出現位置
            StartPosX = -3,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_122",  phase = Phase.phase3,
// 出現位置
            StartPosX = -2,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_123",  phase = Phase.phase3,
// 出現位置
            StartPosX = -1,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_124",  phase = Phase.phase3,
// 出現位置
            StartPosX = 0,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_125",  phase = Phase.phase3,
// 出現位置
            StartPosX = 1,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_126",  phase = Phase.phase3,
// 出現位置
            StartPosX = 2,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy3_127",  phase = Phase.phase3,
// 出現位置
            StartPosX = 3,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_128",  phase = Phase.phase3,
// 出現位置
            StartPosX = 4,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_129",  phase = Phase.phase3,
// 出現位置
            StartPosX = 5,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_130",  phase = Phase.phase3,
// 出現位置
            StartPosX = 6,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_131",  phase = Phase.phase3,
// 出現位置
            StartPosX = 7,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_136",  phase = Phase.phase3,
// 出現位置
            StartPosX = -7,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_137",  phase = Phase.phase3,
// 出現位置
            StartPosX = -6,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_138",  phase = Phase.phase3,
// 出現位置
            StartPosX = -5,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy3_139",  phase = Phase.phase3,
// 出現位置
            StartPosX = -4,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_140",  phase = Phase.phase3,
// 出現位置
            StartPosX = -3,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_141",  phase = Phase.phase3,
// 出現位置
            StartPosX = -2,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_142",  phase = Phase.phase3,
// 出現位置
            StartPosX = -1,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_143",  phase = Phase.phase3,
// 出現位置
            StartPosX = 0,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_144",  phase = Phase.phase3,
// 出現位置
            StartPosX = 1,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_145",  phase = Phase.phase3,
// 出現位置
            StartPosX = 2,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy3_146",  phase = Phase.phase3,
// 出現位置
            StartPosX = 3,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_147",  phase = Phase.phase3,
// 出現位置
            StartPosX = 4,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_148",  phase = Phase.phase3,
// 出現位置
            StartPosX = 5,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_149",  phase = Phase.phase3,
// 出現位置
            StartPosX = 6,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy3_150",  phase = Phase.phase3,
// 出現位置
            StartPosX = 7,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


//<<Phas4
     new EnemyData(){ name = "enemy4_3",  phase = Phase.phase4,
// 出現位置
            StartPosX = -7,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_4",  phase = Phase.phase4,
// 出現位置
            StartPosX = -6,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_5",  phase = Phase.phase4,
// 出現位置
            StartPosX = -5,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_6",  phase = Phase.phase4,
// 出現位置
            StartPosX = -4,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_7",  phase = Phase.phase4,
// 出現位置
            StartPosX = -3,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_8",  phase = Phase.phase4,
// 出現位置
            StartPosX = -2,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_9",  phase = Phase.phase4,
// 出現位置
            StartPosX = -1,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_10",  phase = Phase.phase4,
// 出現位置
            StartPosX = 0,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_11",  phase = Phase.phase4,
// 出現位置
            StartPosX = 1,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_12",  phase = Phase.phase4,
// 出現位置
            StartPosX = 2,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_13",  phase = Phase.phase4,
// 出現位置
            StartPosX = 3,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_14",  phase = Phase.phase4,
// 出現位置
            StartPosX = 4,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_15",  phase = Phase.phase4,
// 出現位置
            StartPosX = 5,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_16",  phase = Phase.phase4,
// 出現位置
            StartPosX = 6,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_17",  phase = Phase.phase4,
// 出現位置
            StartPosX = 7,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_22",  phase = Phase.phase4,
// 出現位置
            StartPosX = -7,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_23",  phase = Phase.phase4,
// 出現位置
            StartPosX = -6,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_24",  phase = Phase.phase4,
// 出現位置
            StartPosX = -5,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_25",  phase = Phase.phase4,
// 出現位置
            StartPosX = -4,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_26",  phase = Phase.phase4,
// 出現位置
            StartPosX = -3,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_27",  phase = Phase.phase4,
// 出現位置
            StartPosX = -2,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_28",  phase = Phase.phase4,
// 出現位置
            StartPosX = -1,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_29",  phase = Phase.phase4,
// 出現位置
            StartPosX = 0,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_30",  phase = Phase.phase4,
// 出現位置
            StartPosX = 1,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_31",  phase = Phase.phase4,
// 出現位置
            StartPosX = 2,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_32",  phase = Phase.phase4,
// 出現位置
            StartPosX = 3,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_33",  phase = Phase.phase4,
// 出現位置
            StartPosX = 4,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_34",  phase = Phase.phase4,
// 出現位置
            StartPosX = 5,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_35",  phase = Phase.phase4,
// 出現位置
            StartPosX = 6,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_36",  phase = Phase.phase4,
// 出現位置
            StartPosX = 7,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_41",  phase = Phase.phase4,
// 出現位置
            StartPosX = -7,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_42",  phase = Phase.phase4,
// 出現位置
            StartPosX = -6,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_43",  phase = Phase.phase4,
// 出現位置
            StartPosX = -5,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_44",  phase = Phase.phase4,
// 出現位置
            StartPosX = -4,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_45",  phase = Phase.phase4,
// 出現位置
            StartPosX = -3,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位Z
            TargetPosX = -3,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_46",  phase = Phase.phase4,
// 出現位置
            StartPosX = -2,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_47",  phase = Phase.phase4,
// 出現位置
            StartPosX = -1,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_48",  phase = Phase.phase4,
// 出現位置
            StartPosX = 0,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_49",  phase = Phase.phase4,
// 出現位置
            StartPosX = 1,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_50",  phase = Phase.phase4,
// 出現位置
            StartPosX = 2,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_51",  phase = Phase.phase4,
// 出現位置
            StartPosX = 3,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_52",  phase = Phase.phase4,
// 出現位置
            StartPosX = 4,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_53",  phase = Phase.phase4,
// 出現位置
            StartPosX = 5,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_54",  phase = Phase.phase4,
// 出現位置
            StartPosX = 6,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_55",  phase = Phase.phase4,
// 出現位置
            StartPosX = 7,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_60",  phase = Phase.phase4,
// 出現位置
            StartPosX = -7,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_61",  phase = Phase.phase4,
// 出現位置
            StartPosX = -6,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_62",  phase = Phase.phase4,
// 出現位置
            StartPosX = -5,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_63",  phase = Phase.phase4,
// 出現位置
            StartPosX = -4,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_64",  phase = Phase.phase4,
// 出現位置
            StartPosX = -3,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_65",  phase = Phase.phase4,
// 出現位置
            StartPosX = -2,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_66",  phase = Phase.phase4,
// 出現位置
            StartPosX = -1,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_67",  phase = Phase.phase4,
// 出現位置
            StartPosX = 0,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_68",  phase = Phase.phase4,
// 出現位置
            StartPosX = 1,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_69",  phase = Phase.phase4,
// 出現位置
            StartPosX = 2,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy4_70",  phase = Phase.phase4,
// 出現位置
            StartPosX = 3,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_71",  phase = Phase.phase4,
// 出現位置
            StartPosX = 4,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_72",  phase = Phase.phase4,
// 出現位置
            StartPosX = 5,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_73",  phase = Phase.phase4,
// 出現位置
            StartPosX = 6,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_74",  phase = Phase.phase4,
// 出現位置
            StartPosX = 7,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy4_79",  phase = Phase.phase4,
// 出現位置
            StartPosX = -7,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_80",  phase = Phase.phase4,
// 出現位置
            StartPosX = -6,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_81",  phase = Phase.phase4,
// 出現位置
            StartPosX = -5,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy4_82",  phase = Phase.phase4,
// 出現位置
            StartPosX = -4,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_83",  phase = Phase.phase4,
// 出現位置
            StartPosX = -3,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_84",  phase = Phase.phase4,
// 出現位置
            StartPosX = -2,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_85",  phase = Phase.phase4,
// 出現位置
            StartPosX = -1,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_86",  phase = Phase.phase4,
// 出現位置
            StartPosX = 0,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_87",  phase = Phase.phase4,
// 出現位置
            StartPosX = 1,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_88",  phase = Phase.phase4,
// 出現位置
            StartPosX = 2,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy4_89",  phase = Phase.phase4,
// 出現位置
            StartPosX = 3,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_90",  phase = Phase.phase4,
// 出現位置
            StartPosX = 4,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_91",  phase = Phase.phase4,
// 出現位置
            StartPosX = 5,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_92",  phase = Phase.phase4,
// 出現位置
            StartPosX = 6,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_93",  phase = Phase.phase4,
// 出現位置
            StartPosX = 7,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_98",  phase = Phase.phase4,
// 出現位置
            StartPosX = -7,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_99",  phase = Phase.phase4,
// 出現位置
            StartPosX = -6,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_100",  phase = Phase.phase4,
// 出現位置
            StartPosX = -5,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy4_101",  phase = Phase.phase4,
// 出現位置
            StartPosX = -4,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_102",  phase = Phase.phase4,
// 出現位置
            StartPosX = -3,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_103",  phase = Phase.phase4,
// 出現位置
            StartPosX = -2,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "eneme104",  phase = Phase.phase4,
// 出現位置
            StartPosX = -1,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_105",  phase = Phase.phase4,
// 出現位置
            StartPosX = 0,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_106",  phase = Phase.phase4,
// 出現位置
            StartPosX = 1,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_107",  phase = Phase.phase4,
// 出現位置
            StartPosX = 2,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy4_108",  phase = Phase.phase4,
// 出現位置
            StartPosX = 3,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_109",  phase = Phase.phase4,
// 出現位置
            StartPosX = 4,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_110",  phase = Phase.phase4,
// 出現位置
            StartPosX = 5,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_111",  phase = Phase.phase4,
// 出現位置
            StartPosX = 6,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_112",  phase = Phase.phase4,
// 出現位置
            StartPosX = 7,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_117",  phase = Phase.phase4,
// 出現位置
            StartPosX = -7,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_118",  phase = Phase.phase4,
// 出現位置
            StartPosX = -6,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_119",  phase = Phase.phase4,
// 出現位置
            StartPosX = -5,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy4_120",  phase = Phase.phase4,
// 出現位置
            StartPosX = -4,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_121",  phase = Phase.phase4,
// 出現位置
            StartPosX = -3,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_122",  phase = Phase.phase4,
// 出現位置
            StartPosX = -2,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_123",  phase = Phase.phase4,
// 出現位置
            StartPosX = -1,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_124",  phase = Phase.phase4,
// 出現位置
            StartPosX = 0,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_125",  phase = Phase.phase4,
// 出現位置
            StartPosX = 1,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_126",  phase = Phase.phase4,
// 出現位置
            StartPosX = 2,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy4_127",  phase = Phase.phase4,
// 出現位置
            StartPosX = 3,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_128",  phase = Phase.phase4,
// 出現位置
            StartPosX = 4,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_129",  phase = Phase.phase4,
// 出現位置
            StartPosX = 5,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_130",  phase = Phase.phase4,
// 出現位置
            StartPosX = 6,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_131",  phase = Phase.phase4,
// 出現位置
            StartPosX = 7,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_136",  phase = Phase.phase4,
// 出現位置
            StartPosX = -7,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_137",  phase = Phase.phase4,
// 出現位置
            StartPosX = -6,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_138",  phase = Phase.phase4,
// 出現位置
            StartPosX = -5,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy4_139",  phase = Phase.phase4,
// 出現位置
            StartPosX = -4,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_140",  phase = Phase.phase4,
// 出現位置
            StartPosX = -3,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_141",  phase = Phase.phase4,
// 出現位置
            StartPosX = -2,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_142",  phase = Phase.phase4,
// 出現位置
            StartPosX = -1,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_143",  phase = Phase.phase4,
// 出現位置
            StartPosX = 0,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_144",  phase = Phase.phase4,
// 出現位置
            StartPosX = 1,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_145",  phase = Phase.phase4,
// 出現位置
            StartPosX = 2,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy4_146",  phase = Phase.phase4,
// 出現位置
            StartPosX = 3,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_147",  phase = Phase.phase4,
// 出現位置
            StartPosX = 4,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_148",  phase = Phase.phase4,
// 出現位置
            StartPosX = 5,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_149",  phase = Phase.phase4,
// 出現位置
            StartPosX = 6,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy4_150",  phase = Phase.phase4,
// 出現位置
            StartPosX = 7,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

 //<<Phase5
     new EnemyData(){ name = "enemy5_3",  phase = Phase.phase5,
// 出現位置
            StartPosX = -7,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_4",  phase = Phase.phase5,
// 出現位置
            StartPosX = -6,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_5",  phase = Phase.phase5,
// 出現位置
            StartPosX = -5,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_6",  phase = Phase.phase5,
// 出現位置
            StartPosX = -4,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_7",  phase = Phase.phase5,
// 出現位置
            StartPosX = -3,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_8",  phase = Phase.phase5,
// 出現位置
            StartPosX = -2,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_9",  phase = Phase.phase5,
// 出現位置
            StartPosX = -1,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_10",  phase = Phase.phase5,
// 出現位置
            StartPosX = 0,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_11",  phase = Phase.phase5,
// 出現位置
            StartPosX = 1,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_12",  phase = Phase.phase5,
// 出現位置
            StartPosX = 2,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_13",  phase = Phase.phase5,
// 出現位置
            StartPosX = 3,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_14",  phase = Phase.phase5,
// 出現位置
            StartPosX = 4,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_15",  phase = Phase.phase5,
// 出現位置
            StartPosX = 5,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_16",  phase = Phase.phase5,
// 出現位置
            StartPosX = 6,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_17",  phase = Phase.phase5,
// 出現位置
            StartPosX = 7,     StartPosY = 3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = 3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = 3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_22",  phase = Phase.phase5,
// 出現位置
            StartPosX = -7,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_23",  phase = Phase.phase5,
// 出現位置
            StartPosX = -6,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_24",  phase = Phase.phase5,
// 出現位置
            StartPosX = -5,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_25",  phase = Phase.phase5,
// 出現位置
            StartPosX = -4,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_26",  phase = Phase.phase5,
// 出現位置
            StartPosX = -3,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_27",  phase = Phase.phase5,
// 出現位置
            StartPosX = -2,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_28",  phase = Phase.phase5,
// 出現位置
            StartPosX = -1,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_29",  phase = Phase.phase5,
// 出現位置
            StartPosX = 0,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_30",  phase = Phase.phase5,
// 出現位置
            StartPosX = 1,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_31",  phase = Phase.phase5,
// 出現位置
            StartPosX = 2,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_32",  phase = Phase.phase5,
// 出現位置
            StartPosX = 3,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_33",  phase = Phase.phase5,
// 出現位置
            StartPosX = 4,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_34",  phase = Phase.phase5,
// 出現位置
            StartPosX = 5,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_35",  phase = Phase.phase5,
// 出現位置
            StartPosX = 6,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_36",  phase = Phase.phase5,
// 出現位置
            StartPosX = 7,     StartPosY = 2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = 2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = 2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_41",  phase = Phase.phase5,
// 出現位置
            StartPosX = -7,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_42",  phase = Phase.phase5,
// 出現位置
            StartPosX = -6,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_43",  phase = Phase.phase5,
// 出現位置
            StartPosX = -5,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_44",  phase = Phase.phase5,
// 出現位置
            StartPosX = -4,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_45",  phase = Phase.phase5,
// 出現位置
            StartPosX = -3,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位Z
            TargetPosX = -3,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_46",  phase = Phase.phase5,
// 出現位置
            StartPosX = -2,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_47",  phase = Phase.phase5,
// 出現位置
            StartPosX = -1,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_48",  phase = Phase.phase5,
// 出現位置
            StartPosX = 0,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_49",  phase = Phase.phase5,
// 出現位置
            StartPosX = 1,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_50",  phase = Phase.phase5,
// 出現位置
            StartPosX = 2,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_51",  phase = Phase.phase5,
// 出現位置
            StartPosX = 3,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_52",  phase = Phase.phase5,
// 出現位置
            StartPosX = 4,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_53",  phase = Phase.phase5,
// 出現位置
            StartPosX = 5,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_54",  phase = Phase.phase5,
// 出現位置
            StartPosX = 6,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_55",  phase = Phase.phase5,
// 出現位置
            StartPosX = 7,     StartPosY = 1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = 1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = 1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_60",  phase = Phase.phase5,
// 出現位置
            StartPosX = -7,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_61",  phase = Phase.phase5,
// 出現位置
            StartPosX = -6,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_62",  phase = Phase.phase5,
// 出現位置
            StartPosX = -5,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_63",  phase = Phase.phase5,
// 出現位置
            StartPosX = -4,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_64",  phase = Phase.phase5,
// 出現位置
            StartPosX = -3,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_65",  phase = Phase.phase5,
// 出現位置
            StartPosX = -2,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_66",  phase = Phase.phase5,
// 出現位置
            StartPosX = -1,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_67",  phase = Phase.phase5,
// 出現位置
            StartPosX = 0,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_68",  phase = Phase.phase5,
// 出現位置
            StartPosX = 1,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_69",  phase = Phase.phase5,
// 出現位置
            StartPosX = 2,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy5_70",  phase = Phase.phase5,
// 出現位置
            StartPosX = 3,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_71",  phase = Phase.phase5,
// 出現位置
            StartPosX = 4,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_72",  phase = Phase.phase5,
// 出現位置
            StartPosX = 5,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_73",  phase = Phase.phase5,
// 出現位置
            StartPosX = 6,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_74",  phase = Phase.phase5,
// 出現位置
            StartPosX = 7,     StartPosY = 0,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = 0,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = 0,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy5_79",  phase = Phase.phase5,
// 出現位置
            StartPosX = -7,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_80",  phase = Phase.phase5,
// 出現位置
            StartPosX = -6,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_81",  phase = Phase.phase5,
// 出現位置
            StartPosX = -5,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy5_82",  phase = Phase.phase5,
// 出現位置
            StartPosX = -4,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_83",  phase = Phase.phase5,
// 出現位置
            StartPosX = -3,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_84",  phase = Phase.phase5,
// 出現位置
            StartPosX = -2,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_85",  phase = Phase.phase5,
// 出現位置
            StartPosX = -1,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_86",  phase = Phase.phase5,
// 出現位置
            StartPosX = 0,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_87",  phase = Phase.phase5,
// 出現位置
            StartPosX = 1,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_88",  phase = Phase.phase5,
// 出現位置
            StartPosX = 2,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy5_89",  phase = Phase.phase5,
// 出現位置
            StartPosX = 3,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_90",  phase = Phase.phase5,
// 出現位置
            StartPosX = 4,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_91",  phase = Phase.phase5,
// 出現位置
            StartPosX = 5,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_92",  phase = Phase.phase5,
// 出現位置
            StartPosX = 6,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_93",  phase = Phase.phase5,
// 出現位置
            StartPosX = 7,     StartPosY = -1,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = -1,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = -1,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_98",  phase = Phase.phase5,
// 出現位置
            StartPosX = -7,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_99",  phase = Phase.phase5,
// 出現位置
            StartPosX = -6,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_100",  phase = Phase.phase5,
// 出現位置
            StartPosX = -5,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy5_101",  phase = Phase.phase5,
// 出現位置
            StartPosX = -4,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_102",  phase = Phase.phase5,
// 出現位置
            StartPosX = -3,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_103",  phase = Phase.phase5,
// 出現位置
            StartPosX = -2,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "eneme104",  phase = Phase.phase5,
// 出現位置
            StartPosX = -1,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_105",  phase = Phase.phase5,
// 出現位置
            StartPosX = 0,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_106",  phase = Phase.phase5,
// 出現位置
            StartPosX = 1,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_107",  phase = Phase.phase5,
// 出現位置
            StartPosX = 2,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy5_108",  phase = Phase.phase5,
// 出現位置
            StartPosX = 3,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_109",  phase = Phase.phase5,
// 出現位置
            StartPosX = 4,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_110",  phase = Phase.phase5,
// 出現位置
            StartPosX = 5,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_111",  phase = Phase.phase5,
// 出現位置
            StartPosX = 6,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_112",  phase = Phase.phase5,
// 出現位置
            StartPosX = 7,     StartPosY = -2,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = -2,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = -2,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_117",  phase = Phase.phase5,
// 出現位置
            StartPosX = -7,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_118",  phase = Phase.phase5,
// 出現位置
            StartPosX = -6,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_119",  phase = Phase.phase5,
// 出現位置
            StartPosX = -5,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy5_120",  phase = Phase.phase5,
// 出現位置
            StartPosX = -4,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_121",  phase = Phase.phase5,
// 出現位置
            StartPosX = -3,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_122",  phase = Phase.phase5,
// 出現位置
            StartPosX = -2,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_123",  phase = Phase.phase5,
// 出現位置
            StartPosX = -1,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_124",  phase = Phase.phase5,
// 出現位置
            StartPosX = 0,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_125",  phase = Phase.phase5,
// 出現位置
            StartPosX = 1,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_126",  phase = Phase.phase5,
// 出現位置
            StartPosX = 2,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy5_127",  phase = Phase.phase5,
// 出現位置
            StartPosX = 3,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_128",  phase = Phase.phase5,
// 出現位置
            StartPosX = 4,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_129",  phase = Phase.phase5,
// 出現位置
            StartPosX = 5,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_130",  phase = Phase.phase5,
// 出現位置
            StartPosX = 6,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_131",  phase = Phase.phase5,
// 出現位置
            StartPosX = 7,     StartPosY = -3,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = -3,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = -3,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_136",  phase = Phase.phase5,
// 出現位置
            StartPosX = -7,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -7,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -7,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_137",  phase = Phase.phase5,
// 出現位置
            StartPosX = -6,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -6,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -6,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_138",  phase = Phase.phase5,
// 出現位置
            StartPosX = -5,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -5,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -5,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy5_139",  phase = Phase.phase5,
// 出現位置
            StartPosX = -4,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -4,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -4,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_140",  phase = Phase.phase5,
// 出現位置
            StartPosX = -3,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -3,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -3,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_141",  phase = Phase.phase5,
// 出現位置
            StartPosX = -2,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -2,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -2,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_142",  phase = Phase.phase5,
// 出現位置
            StartPosX = -1,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = -1,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = -1,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_143",  phase = Phase.phase5,
// 出現位置
            StartPosX = 0,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 0,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 0,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_144",  phase = Phase.phase5,
// 出現位置
            StartPosX = 1,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 1,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 1,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_145",  phase = Phase.phase5,
// 出現位置
            StartPosX = 2,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 2,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 2,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },


new EnemyData(){ name = "enemy5_146",  phase = Phase.phase5,
// 出現位置
            StartPosX = 3,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 3,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 3,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_147",  phase = Phase.phase5,
// 出現位置
            StartPosX = 4,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 4,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 4,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_148",  phase = Phase.phase5,
// 出現位置
            StartPosX = 5,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 5,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 5,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_149",  phase = Phase.phase5,
// 出現位置
            StartPosX = 6,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 6,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 6,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },

new EnemyData(){ name = "enemy5_150",  phase = Phase.phase5,
// 出現位置
            StartPosX = 7,     StartPosY = -4,     StartPosZ = 0,
// 目標地点1
            FirstPosX = 7,     FirstPosY = -4,     FirstPosZ = 0,
// 目標位置
            TargetPosX = 7,    TargetPosY = -4,    TargetPosZ = 0,
// !
            EntryPosX = 8.1f,   EntryPosY = 2,
// 角度(0:未出現 1:)
            sideNo = 2,
// 出現時間
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
        },
    };
}