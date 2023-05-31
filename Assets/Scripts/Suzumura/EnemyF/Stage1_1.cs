using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//***********************************************************
//  1-1�����فI�I
//***********************************************************
public class Stage1_1 : MonoBehaviour
{
    public static EnemyData[] enemydatas = new EnemyData[] {
//***********************************************************
//  Phase1
//***********************************************************
        new EnemyData(){
            name = "enemy01",
            phase = Phase.phase1,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,�@�@�@�@//state�R���x
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
            sideNo = 0,
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
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 4,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,�@�@�@�@//state�R���x
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
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = -2,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 6,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,�@�@�@�@//state�R���x
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
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 8,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
          




 //�������t�F�[�Y�Q 
        new EnemyData(){
            name = "enemy06",
            phase = Phase.phase2,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -6,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy07",
            phase = Phase.phase2,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -4,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 2,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,�@�@�@�@//state�R���x
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
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 4,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,�@�@�@�@//state�R���x
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
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 6,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy10",
            phase = Phase.phase2,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 2,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 8,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,�@�@�@�@//state�R���x
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
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 4,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 10,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
       new EnemyData(){
            name = "enemy30",
            phase = Phase.phase2,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 6,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 12,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01



//�������t�F�[�Y�R
         new EnemyData(){
            name = "enemy12",
            phase = Phase.phase3,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -4,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy13",
            phase = Phase.phase3,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = 2,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 2,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy14",
            phase = Phase.phase3,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 4,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy15",
            phase = Phase.phase3,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 2,
            TargetPosY = 2,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 6,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy16",
            phase = Phase.phase3,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 4,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 8,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy17",
            phase = Phase.phase3,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 6,
            TargetPosY = 2,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 10,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01



 //�����������t�F�[�Y�S
         new EnemyData(){
            name = "enemy12",
            phase = Phase.phase4,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -4,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy13",
            phase = Phase.phase4,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -4,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 2,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy14",
            phase = Phase.phase4,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -4,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 4,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy15",
            phase = Phase.phase4,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 3,
            TargetPosY = 1,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 6,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy16",
            phase = Phase.phase4,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 3,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 8,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy17",
            phase = Phase.phase4,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 3,
            TargetPosY = -3,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 10,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 3,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01

        
 //�����������t�F�[�Y5
        new EnemyData(){
            name = "enemy18",
            phase = Phase.phase5,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -4,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 2,
            AppearanceTime = 0,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 5,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy19",
            phase = Phase.phase5,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 2,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 5,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy20",
            phase = Phase.phase5,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 4,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 5,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy21",
            phase = Phase.phase5,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 2,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 6,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 5,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy22",
            phase = Phase.phase5,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 4,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 8,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 5,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy23",
            phase = Phase.phase5,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 6,
            TargetPosY = 0,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 10,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 5,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01

         new EnemyData(){
            name = "enemy24",
            phase = Phase.phase5,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -4,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 0,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 5,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy25",
            phase = Phase.phase5,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = -2,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 2,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 5,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy26",
            phase = Phase.phase5,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = -1,
            FirstPosZ = 0,
            TargetPosX = 0,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 4,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 5,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy27",
            phase = Phase.phase5,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = -1,
            FirstPosZ = 0,
            TargetPosX = 2,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 6,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 5,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy28",
            phase = Phase.phase5,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 4,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 8,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 5,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
        new EnemyData(){
            name = "enemy29",
            phase = Phase.phase5,
            StartPosX = 12,//�͂���
            StartPosY = 3,
            StartPosZ = 0,
            FirstPosX = 3,
            FirstPosY = 0,
            FirstPosZ = 0,
            TargetPosX = 6,
            TargetPosY = -1,
            TargetPosZ = 0,
            EntryPosX = 8.1f,//�r�b�N���}�[�N
            EntryPosY = 2,
            sideNo = 0,
            AppearanceTime = 10,//�o������
            model = "koa",
            category = EnemyCategory.typeNone,//���̑��x
            Size = 5.0f,
            NextStep1 = 3,
            Data1 = 5,�@�@�@�@//state�R���x
            NextStep2 = 5,
            Data2 = 10,
            NextStep3 = 4,
            Data3 = 5,
            NextStep4 = -1,
            NextStep5 = -1
        },  // enemy01
    };
}