// 4_4着手 三浦瞬20230528


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage44 : MonoBehaviour
{
    public static EnemyData[] enemydatas = new EnemyData[] {
//***********************************************************
//  Phase1
//***********************************************************
         new EnemyData(){
            name = "phase1_enemy01",
            phase = Phase.phase1,
            StartPosX = 12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// Run_enemy01
         
        new EnemyData(){
            name = "phase1_enemy02",
            phase = Phase.phase1,
            StartPosX = 12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// Run_enemy01
        
        new EnemyData(){
            name = "phase1_enemy03",
            phase = Phase.phase1,
            StartPosX = 12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// Run_enemy01
        
        new EnemyData(){
            name = "phase1_enemy04",
            phase = Phase.phase1,
            StartPosX = 12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// Run_enemy01
        
        new EnemyData(){
            name = "phase1_enemy05",
            phase = Phase.phase1,
            StartPosX = 12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// Run_enemy01

    new EnemyData(){
            name = "Run_enemy05",
            phase = Phase.phase1,
            StartPosX = 12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// Run_enemy01



//<<Phase2
         new EnemyData(){
            name = "phase2_enemy01",
            phase = Phase.phase2,
            StartPosX = 0,
            StartPosY = -6,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = -4,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// phase2_enemy01
         
        new EnemyData(){
            name = "phase2_enemy02",
            phase = Phase.phase2,
            StartPosX = 0,
            StartPosY = -6,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = -4,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// phase2_enemy01
                  
        new EnemyData(){
            name = "phase2_enemy03",
            phase = Phase.phase2,
            StartPosX = 0,
            StartPosY = -6,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = -4,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// phase2_enemy01
                           
        new EnemyData(){
            name = "phase2_enemy04",
            phase = Phase.phase2,
            StartPosX = 0,
            StartPosY = -6,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = -4,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// phase2_enemy01
                                    
        new EnemyData(){
            name = "phase2_enemy05",
            phase = Phase.phase2,
            StartPosX = 0,
            StartPosY = -6,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = -4,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// phase2_enemy01
                                             
        new EnemyData(){
            name = "phase2_enemy06",
            phase = Phase.phase2,
            StartPosX = 0,
            StartPosY = -6,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = -4,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// phase2_enemy01
                                                                                                            
        new EnemyData(){
            name = "phase2_enemy07",
            phase = Phase.phase2,
            StartPosX = 0,
            StartPosY = -6,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = -4,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// phase2_enemy01
                                                               
        new EnemyData(){
            name = "phase2_enemy08",
            phase = Phase.phase2,
            StartPosX = 0,
            StartPosY = -6,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = -4,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// phase2_enemy01

        new EnemyData(){
            name = "phase2_enemy09",
            phase = Phase.phase2,
            StartPosX = 0,
            StartPosY = -6,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = -4,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// phase2_enemy01
        
        new EnemyData(){
            name = "phase2_enemy10",
            phase = Phase.phase2,
            StartPosX = 0,
            StartPosY = -6,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = -4,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// phase2_enemy01

//<<Phase3

// 左下から出現
        new EnemyData(){
            name = "phase3_enemy01",
            phase = Phase.phase3,
            StartPosX = -12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = -8.1f,
            EntryPosY = -2,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// phase2_enemy01
        
        new EnemyData(){
            name = "phase3_enemy02",
            phase = Phase.phase3,
            StartPosX = -12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = -8.1f,
            EntryPosY = -2,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// phase2_enemy01
                
        new EnemyData(){
            name = "phase3_enemy03",
            phase = Phase.phase3,
            StartPosX = -12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = -8.1f,
            EntryPosY = -2,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// phase2_enemy01
                        
        new EnemyData(){
            name = "phase3_enemy04",
            phase = Phase.phase3,
            StartPosX = -12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = -8.1f,
            EntryPosY = -2,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// phase2_enemy01

        new EnemyData(){
            name = "phase3_enemy8",
            phase = Phase.phase3,
            StartPosX = 0,
            StartPosY = 9,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// phase2_enemy01

        new EnemyData(){
            name = "phase3_enemy8",
            phase = Phase.phase3,
            StartPosX = 0,
            StartPosY = 9,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// phase2_enemy01
        
        new EnemyData(){
            name = "phase3_enemy9",
            phase = Phase.phase3,
            StartPosX = 0,
            StartPosY = 9,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// phase2_enemy01      

        new EnemyData(){
            name = "phase3_enemy10",
            phase = Phase.phase3,
            StartPosX = 0,
            StartPosY = 9,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = 4,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// phase2_enemy01


//<<Phas4

// 下
        new EnemyData(){
            name = "phase4_enemy01",
            phase = Phase.phase4,
            StartPosX = 0,
            StartPosY = -6,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = -4,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// phase2_enemy01

        new EnemyData(){
            name = "phase4_enemy02",
            phase = Phase.phase4,
            StartPosX = 0,
            StartPosY = -6,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = -4,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// phase2_enemy01

        new EnemyData(){
            name = "phase4_enemy03",
            phase = Phase.phase4,
            StartPosX = 0,
            StartPosY = -6,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = -4,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// phase2_enemy01
        
        new EnemyData(){
            name = "phase4_enemy04",
            phase = Phase.phase4,
            StartPosX = 0,
            StartPosY = -6,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = -4,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// phase2_enemy01
        
        new EnemyData(){
            name = "phase4_enemy05",
            phase = Phase.phase4,
            StartPosX = 0,
            StartPosY = -6,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = -4,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// phase2_enemy01
        
        new EnemyData(){
            name = "phase4_enemy06",
            phase = Phase.phase4,
            StartPosX = 0,
            StartPosY = -6,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = -4,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// phase2_enemy01
        
        new EnemyData(){
            name = "phase4_enemy07",
            phase = Phase.phase4,
            StartPosX = 0,
            StartPosY = -6,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = 0f,
            EntryPosY = -4,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// phase2_enemy01


 // 右上
         new EnemyData(){
            name = "phase4_enemy08",
            phase = Phase.phase3,
            StartPosX = -12,
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = Random.Range(6, -6),
            FirstPosY = Random.Range(2, -3),
            FirstPosZ = 0,
            TargetPosX = Random.Range(6, -6),
            TargetPosY = Random.Range(2, -3),
            TargetPosZ = 0,
            EntryPosX = -8.1f,
            EntryPosY = -2,
            sideNo = 1,
            AppearanceTime = 0,
            model = "koa",
            category = EnemyCategory.typeNone,
            Size = 5.0f,
            NextStep1 = 1,
            Data1 = Random.Range(1, 10),
            NextStep2 = 3,
            Data2 = Random.Range(1, 10),
            NextStep3 = 1,
            Data3 = Random.Range(1, 10),
            NextStep4 = 3,
            Data4 = Random.Range(1, 10),
            NextStep5 = 4,
            Data5 = Random.Range(1, 10),
        },// phase2_enemy01


 //<<Phase5
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