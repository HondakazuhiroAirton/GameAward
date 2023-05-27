using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage12 : MonoBehaviour
{
    public static EnemyData[] enemydatas = new EnemyData[]{
//***********************************************************
        new EnemyData(){
            name = "enemy01",
            phase = Phase.phase1,
            StartPosX = -13,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = -3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = -8.1f,
            EntryPosY = 0,
            sideNo = 4,
            AppearanceTime = 0.0f,
            model = "koa",
            category = EnemyCategory.type1,
            Size = 6.0f,
            NextStep1 = 1,
            Data1 = 5,
            NextStep2 = 2,
            Data2 = 0,
            NextStep3 = 2,
            Data3 = 0,
            NextStep4 = 2,
            Data4 = 0,
            NextStep5 = 4,
            Data5 = 5,
            RotateSpeed = 100,
        },  // enemy01
        new EnemyData(){
            name = "enemy02",
            phase = Phase.phase1,
            StartPosX = -12,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = -2,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            AppearanceTime = 0.0f,
            model = "koa",
            category = EnemyCategory.type1,
            Size = 6.0f,
            NextStep1 = 1,
            Data1 = 5,
            NextStep2 = 2,
            Data2 = -1,
            NextStep3 = 2,
            Data3 = -1,
            NextStep4 = 2,
            Data4 = -1,
            NextStep5 = 4,
            Data5 = 5,
            RotateSpeed = 100
        },  // enemy02
        new EnemyData(){
            name = "enemy03",
            phase = Phase.phase1,
            StartPosX = -11,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = -1,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            AppearanceTime = 0.0f,
            model = "koa",
            category = EnemyCategory.type1,
            Size = 6.0f,
            NextStep1 = 1,
            Data1 = 5,
            NextStep2 = 2,
            Data2 = -2,
            NextStep3 = 2,
            Data3 = -2,
            NextStep4 = 2,
            Data4 = -2,
            NextStep5 = 4,
            Data5 = 5,
            RotateSpeed = 100,
        },  // enemy03
        new EnemyData(){
            name = "enemy04",
            phase = Phase.phase1,
            StartPosX = -14,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = -4,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            AppearanceTime = 0.0f,
            model = "koa",
            category = EnemyCategory.type1,
            Size = 6.0f,
            NextStep1 = 1,
            Data1 = 5,
            NextStep2 = 2,
            Data2 = 1,
            NextStep3 = 2,
            Data3 = 1,
            NextStep4 = 2,
            Data4 = 1,
            NextStep5 = 4,
            Data5 = 5,
            RotateSpeed = 100,
        },  // enemy04
        new EnemyData(){
            name = "enemy05",
            phase = Phase.phase1,
            StartPosX = -15,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = -5,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            AppearanceTime = 0.0f,
            model = "koa",
            category = EnemyCategory.type1,
            Size = 6.0f,
            NextStep1 = 1,
            Data1 = 5,
            NextStep2 = 2,
            Data2 = 2,
            NextStep3 = 2,
            Data3 = 2,
            NextStep4 = 2,
            Data4 = 2,
            NextStep5 = 4,
            Data5 = 5,
            RotateSpeed = 100,
        },  // enemy05
        new EnemyData(){
            name = "enemy06",
            phase = Phase.phase1,
            StartPosX = -13,
            StartPosY = 1,
            StartPosZ = 0,
            FirstPosX = -3,
            FirstPosY = 1,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            AppearanceTime = 0.0f,
            model = "koa",
            category = EnemyCategory.type1,
            Size = 6.0f,
            NextStep1 = 1,
            Data1 = 5,
            NextStep2 = 2,
            Data2 = 0,
            NextStep3 = 2,
            Data3 = 0,
            NextStep4 = 2,
            Data4 = 0,
            NextStep5 = 4,
            Data5 = 5,
            RotateSpeed = 100,
            RotateYData = -1
        },  // enemy06
        new EnemyData(){
            name = "enemy07",
            phase = Phase.phase1,
            StartPosX = -13,
            StartPosY = 2,
            StartPosZ = 0,
            FirstPosX = -3,
            FirstPosY = 2,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            AppearanceTime = 0.0f,
            model = "koa",
            category = EnemyCategory.type1,
            Size = 6.0f,
            NextStep1 = 1,
            Data1 = 5,
            NextStep2 = 2,
            Data2 = 0,
            NextStep3 = 2,
            Data3 = 0,
            NextStep4 = 2,
            Data4 = 0,
            NextStep5 = 4,
            Data5 = 5,
            RotateSpeed = 100,
            RotateYData = -2
        },  // enemy07
        new EnemyData(){
            name = "enemy08",
            phase = Phase.phase1,
            StartPosX = -13,
            StartPosY = -1,
            StartPosZ = 0,
            FirstPosX = -3,
            FirstPosY = -1,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            AppearanceTime = 0.0f,
            model = "koa",
            category = EnemyCategory.type1,
            Size = 6.0f,
            NextStep1 = 1,
            Data1 = 5,
            NextStep2 = 2,
            Data2 = 0,
            NextStep3 = 2,
            Data3 = 0,
            NextStep4 = 2,
            Data4 = 0,
            NextStep5 = 4,
            Data5 = 5,
            RotateSpeed = 100,
            RotateYData = 1
        },  // enemy08
        new EnemyData(){
            name = "enemy09",
            phase = Phase.phase1,
            StartPosX = -13,
            StartPosY = -2,
            StartPosZ = 0,
            FirstPosX = -3,
            FirstPosY = -2,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            AppearanceTime = 0.0f,
            model = "koa",
            category = EnemyCategory.type1,
            Size = 6.0f,
            NextStep1 = 1,
            Data1 = 5,
            NextStep2 = 2,
            Data2 = 0,
            NextStep3 = 2,
            Data3 = 0,
            NextStep4 = 2,
            Data4 = 0,
            NextStep5 = 4,
            Data5 = 5,
            RotateSpeed = 100,
            RotateYData = 2
        },  // enemy09

//***********************************************************
        new EnemyData(){
            name = "enemy10",
            phase = Phase.phase1,
            StartPosX = 13,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,
            EntryPosY = 0,
            sideNo = 2,
            AppearanceTime = 0.0f,
            model = "koa",
            category = EnemyCategory.type1,
            Size = 6.0f,
            NextStep1 = 1,
            Data1 = 5,
            NextStep2 = 2,
            Data2 = 0,
            NextStep3 = 2,
            Data3 = 0,
            NextStep4 = 2,
            Data4 = 0,
            NextStep5 = 4,
            Data5 = 5,
            RotateSpeed = -100
        },  // enemy10
        new EnemyData(){
            name = "enemy11",
            phase = Phase.phase1,
            StartPosX = 12,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = 2,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            AppearanceTime = 0.0f,
            model = "koa",
            category = EnemyCategory.type1,
            Size = 6.0f,
            NextStep1 = 1,
            Data1 = 5,
            NextStep2 = 2,
            Data2 = 1,
            NextStep3 = 2,
            Data3 = 1,
            NextStep4 = 2,
            Data4 = 1,
            NextStep5 = 4,
            Data5 = 5,
            RotateSpeed = -100
        },  // enemy11
        new EnemyData(){
            name = "enemy12",
            phase = Phase.phase1,
            StartPosX = 11,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = 1,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            AppearanceTime = 0.0f,
            model = "koa",
            category = EnemyCategory.type1,
            Size = 6.0f,
            NextStep1 = 1,
            Data1 = 5,
            NextStep2 = 2,
            Data2 = 2,
            NextStep3 = 2,
            Data3 = 2,
            NextStep4 = 2,
            Data4 = 2,
            NextStep5 = 4,
            Data5 = 5,
            RotateSpeed = -100
        },  // enemy12
        new EnemyData(){
            name = "enemy13",
            phase = Phase.phase1,
            StartPosX = 14,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = 4,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            AppearanceTime = 0.0f,
            model = "koa",
            category = EnemyCategory.type1,
            Size = 6.0f,
            NextStep1 = 1,
            Data1 = 5,
            NextStep2 = 2,
            Data2 = -1,
            NextStep3 = 2,
            Data3 = -1,
            NextStep4 = 2,
            Data4 = -1,
            NextStep5 = 4,
            Data5 = 5,
            RotateSpeed = -100
        },  // enemy13
        new EnemyData(){
            name = "enemy14",
            phase = Phase.phase1,
            StartPosX = 15,
            StartPosY = 0,
            StartPosZ = 0,
            FirstPosX = 5,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            AppearanceTime = 0.0f,
            model = "koa",
            category = EnemyCategory.type1,
            Size = 6.0f,
            NextStep1 = 1,
            Data1 = 5,
            NextStep2 = 2,
            Data2 = -2,
            NextStep3 = 2,
            Data3 = -2,
            NextStep4 = 2,
            Data4 = -2,
            NextStep5 = 4,
            Data5 = 5,
            RotateSpeed = -100
        },  // enemy14
        new EnemyData(){
            name = "enemy15",
            phase = Phase.phase1,
            StartPosX = 13,
            StartPosY = 1,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 1,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            AppearanceTime = 0.0f,
            model = "koa",
            category = EnemyCategory.type1,
            Size = 6.0f,
            NextStep1 = 1,
            Data1 = 5,
            NextStep2 = 2,
            Data2 = 0,
            NextStep3 = 2,
            Data3 = 0,
            NextStep4 = 2,
            Data4 = 0,
            NextStep5 = 4,
            Data5 = 5,
            RotateSpeed = -100,
            RotateYData = -1
        },  // enemy15
        new EnemyData(){
            name = "enemy16",
            phase = Phase.phase1,
            StartPosX = 13,
            StartPosY = 2,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 2,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            AppearanceTime = 0.0f,
            model = "koa",
            category = EnemyCategory.type1,
            Size = 6.0f,
            NextStep1 = 1,
            Data1 = 5,
            NextStep2 = 2,
            Data2 = 0,
            NextStep3 = 2,
            Data3 = 0,
            NextStep4 = 2,
            Data4 = 0,
            NextStep5 = 4,
            Data5 = 5,
            RotateSpeed = -100,
            RotateYData = -2
        },  // enemy16
        new EnemyData(){
            name = "enemy17",
            phase = Phase.phase1,
            StartPosX = 13,
            StartPosY = -1,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = -1,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            AppearanceTime = 0.0f,
            model = "koa",
            category = EnemyCategory.type1,
            Size = 6.0f,
            NextStep1 = 1,
            Data1 = 5,
            NextStep2 = 2,
            Data2 = 0,
            NextStep3 = 2,
            Data3 = 0,
            NextStep4 = 2,
            Data4 = 0,
            NextStep5 = 4,
            Data5 = 5,
            RotateSpeed = -100,
            RotateYData = 1
        },  // enemy17
        new EnemyData(){
            name = "enemy18",
            phase = Phase.phase1,
            StartPosX = 13,
            StartPosY = -2,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = -2,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            AppearanceTime = 0.0f,
            model = "koa",
            category = EnemyCategory.type1,
            Size = 6.0f,
            NextStep1 = 1,
            Data1 = 5,
            NextStep2 = 2,
            Data2 = 0,
            NextStep3 = 2,
            Data3 = 0,
            NextStep4 = 2,
            Data4 = 0,
            NextStep5 = 4,
            Data5 = 5,
            RotateSpeed = -100,
            RotateYData = 2
        },  // enemy18


//        new EnemyData(){
//            name = "enemy21",
//            phase = Phase.phase4,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = 5,
//            FirstPosY = 2,
//            FirstPosZ = 0,
//            TargetPosX = -1,
//            TargetPosY = -3,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 0.3f,
//            model = "koa",
//            category = EnemyCategory.type1,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy21
//        new EnemyData()
//{
//    name = "enemy22",
//            phase = Phase.phase4,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = 5,
//            FirstPosY = 2,
//            FirstPosZ = 0,
//            TargetPosX = 0,
//            TargetPosY = -3,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 0.6f,
//            model = "koa",
//            category = EnemyCategory.type1,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy22
//        new EnemyData()
//{
//    name = "enemy23",
//            phase = Phase.phase4,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = 0,
//            FirstPosY = 0,
//            FirstPosZ = 0,
//            TargetPosX = 0,
//            TargetPosY = 2,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 0.9f,
//            model = "koa",
//            category = EnemyCategory.type1,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy23
//        new EnemyData()
//{
//    name = "enemy24",
//            phase = Phase.phase4,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = 0,
//            FirstPosY = 0,
//            FirstPosZ = 0,
//            TargetPosX = 1,
//            TargetPosY = 2,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 1.2f,
//            model = "koa",
//            category = EnemyCategory.type1,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy24
//        new EnemyData()
//{
//    name = "enemy25",
//            phase = Phase.phase4,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = 0,
//            FirstPosY = 0,
//            FirstPosZ = 0,
//            TargetPosX = 2,
//            TargetPosY = 2,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 1.5f,
//            model = "koa",
//            category = EnemyCategory.type1,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy25
//        new EnemyData()
//{
//    name = "enemy26",
//            phase = Phase.phase4,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = 0,
//            FirstPosY = 0,
//            FirstPosZ = 0,
//            TargetPosX = 3,
//            TargetPosY = 2,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 1.8f,
//            model = "koa",
//            category = EnemyCategory.type1,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy26
//        new EnemyData()
//{
//    name = "enemy27",
//            phase = Phase.phase4,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = 0,
//            FirstPosY = 0,
//            FirstPosZ = 0,
//            TargetPosX = 0,
//            TargetPosY = 0,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 6.0f,
//            model = "koa",
//            category = EnemyCategory.type1,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy27
//        new EnemyData()
//{
//    name = "enemy28",
//            phase = Phase.phase4,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = 0,
//            FirstPosY = 0,
//            FirstPosZ = 0,
//            TargetPosX = 1,
//            TargetPosY = 0,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 6.3f,
//            model = "koa",
//            category = EnemyCategory.type1,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy28
//        new EnemyData()
//{
//    name = "enemy29",
//            phase = Phase.phase4,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = 0,
//            FirstPosY = 0,
//            FirstPosZ = 0,
//            TargetPosX = 2,
//            TargetPosY = 0,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 6.6f,
//            model = "koa",
//            category = EnemyCategory.type1,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy29
//        new EnemyData()
//{
//    name = "enemy30",
//            phase = Phase.phase4,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = 0,
//            FirstPosY = 0,
//            FirstPosZ = 0,
//            TargetPosX = 3,
//            TargetPosY = 0,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 6.9f,
//            model = "koa",
//            category = EnemyCategory.type1,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy30
//        new EnemyData()
//{
//    name = "enemy31",
//            phase = Phase.phase4,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = 0,
//            FirstPosY = 0,
//            FirstPosZ = 0,
//            TargetPosX = 4,
//            TargetPosY = 0,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 7.2f,
//            model = "koa",
//            category = EnemyCategory.type1,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy31
//        new EnemyData()
//{
//    name = "enemy32",
//            phase = Phase.phase4,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = 0,
//            FirstPosY = 0,
//            FirstPosZ = 0,
//            TargetPosX = 5,
//            TargetPosY = 0,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 7.5f,
//            model = "koa",
//            category = EnemyCategory.type1,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy32
//        new EnemyData()
//{
//    name = "enemy33",
//            phase = Phase.phase4,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = 3,
//            FirstPosY = -3,
//            FirstPosZ = 0,
//            TargetPosX = -3,
//            TargetPosY = -4,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 7.8f,
//            model = "koa",
//            category = EnemyCategory.type1,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy33

////***********************************************************
////  Phase5
////***********************************************************
//        new EnemyData()
//{
//    name = "enemy34",
//            phase = Phase.phase5,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = 3,
//            FirstPosY = -3,
//            FirstPosZ = 0,
//            TargetPosX = -3,
//            TargetPosY = -3,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 12,
//            model = "koa",
//            category = EnemyCategory.type2,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy34
//        new EnemyData()
//{
//    name = "enemy35",
//            phase = Phase.phase5,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = 3,
//            FirstPosY = -3,
//            FirstPosZ = 0,
//            TargetPosX = -3,
//            TargetPosY = -2,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 13,
//            model = "koa",
//            category = EnemyCategory.type2,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy35
//        new EnemyData()
//{
//    name = "enemy36",
//            phase = Phase.phase5,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = 3,
//            FirstPosY = -3,
//            FirstPosZ = 0,
//            TargetPosX = -3,
//            TargetPosY = -1,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 14,
//            model = "koa",
//            category = EnemyCategory.type2,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy36
//        new EnemyData()
//{
//    name = "enemy37",
//            phase = Phase.phase5,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = 3,
//            FirstPosY = -3,
//            FirstPosZ = 0,
//            TargetPosX = -3,
//            TargetPosY = 0,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 15,
//            model = "koa",
//            category = EnemyCategory.type2,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy37
//        new EnemyData()
//{
//    name = "enemy38",
//            phase = Phase.phase5,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = 3,
//            FirstPosY = -3,
//            FirstPosZ = 0,
//            TargetPosX = -3,
//            TargetPosY = 1,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 16,
//            model = "koa",
//            category = EnemyCategory.type2,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy38
//        new EnemyData()
//{
//    name = "enemy39",
//            phase = Phase.phase5,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = 3,
//            FirstPosY = -3,
//            FirstPosZ = 0,
//            TargetPosX = -3,
//            TargetPosY = 2,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 17,
//            model = "koa",
//            category = EnemyCategory.type2,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy39
//        new EnemyData()
//{
//    name = "enemy40",
//            phase = Phase.phase5,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = -3,
//            FirstPosY = -2,
//            FirstPosZ = 0,
//            TargetPosX = -4,
//            TargetPosY = 1,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 18,
//            model = "koa",
//            category = EnemyCategory.type3,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy40
//        new EnemyData()
//{
//    name = "enemy41",
//            phase = Phase.phase5,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = -3,
//            FirstPosY = -2,
//            FirstPosZ = 0,
//            TargetPosX = -3,
//            TargetPosY = 1,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 19,
//            model = "koa",
//            category = EnemyCategory.type3,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy41
//        new EnemyData()
//{
//    name = "enemy42",
//            phase = Phase.phase5,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = -3,
//            FirstPosY = -2,
//            FirstPosZ = 0,
//            TargetPosX = -2,
//            TargetPosY = 1,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 20,
//            model = "koa",
//            category = EnemyCategory.type3,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy42
//        new EnemyData()
//{
//    name = "enemy43",
//            phase = Phase.phase5,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = -3,
//            FirstPosY = -2,
//            FirstPosZ = 0,
//            TargetPosX = -1,
//            TargetPosY = 1,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 21,
//            model = "koa",
//            category = EnemyCategory.type3,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy43
//        new EnemyData()
//{
//    name = "enemy44",
//            phase = Phase.phase5,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = -3,
//            FirstPosY = -2,
//            FirstPosZ = 0,
//            TargetPosX = 0,
//            TargetPosY = 1,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 22,
//            model = "koa",
//            category = EnemyCategory.type3,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy44
//        new EnemyData()
//{
//    name = "enemy45",
//            phase = Phase.phase5,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = -3,
//            FirstPosY = -2,
//            FirstPosZ = 0,
//            TargetPosX = 1,
//            TargetPosY = 1,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 23,
//            model = "koa",
//            category = EnemyCategory.type3,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy45
//        new EnemyData()
//{
//    name = "enemy46",
//            phase = Phase.phase5,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = -3,
//            FirstPosY = -2,
//            FirstPosZ = 0,
//            TargetPosX = 2,
//            TargetPosY = 1,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 24,
//            model = "koa",
//            category = EnemyCategory.type3,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy46
//        new EnemyData()
//{
//    name = "enemy47",
//            phase = Phase.phase5,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = -3,
//            FirstPosY = -2,
//            FirstPosZ = 0,
//            TargetPosX = 3,
//            TargetPosY = 1,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 25,
//            model = "koa",
//            category = EnemyCategory.type3,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy47
//        new EnemyData()
//{
//    name = "enemy48",
//            phase = Phase.phase5,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = -3,
//            FirstPosY = -2,
//            FirstPosZ = 0,
//            TargetPosX = 4,
//            TargetPosY = 1,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 26,
//            model = "koa",
//            category = EnemyCategory.type3,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy48
//        new EnemyData()
//{
//    name = "enemy49",
//            phase = Phase.phase5,
//            StartPosX = 12,
//            StartPosY = 3,
//            StartPosZ = 0,
//            FirstPosX = -3,
//            FirstPosY = -2,
//            FirstPosZ = 0,
//            TargetPosX = 5,
//            TargetPosY = 1,
//            TargetPosZ = 0,
//            EntryPosX = 0,
//            EntryPosY = 0,
//            sideNo = 0,
//            AppearanceTime = 27,
//            model = "koa",
//            category = EnemyCategory.type3,
//            Size = 5.0f,
//            NextStep1 = 1,
//            NextStep2 = 2,
//            NextStep3 = 3,
//            NextStep4 = 4,
//            NextStep5 = -1
//        },  // enemy49

    };
}

