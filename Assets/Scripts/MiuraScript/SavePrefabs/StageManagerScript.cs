using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManagerScript : MonoBehaviour
{
    // �S�X�e�[�W���
    [SerializeField]private StageClearDate[] AllStage;
    // ���݂̃X�e�[�W
    [SerializeField]private int StageIndex;

    private static GameObject instance;

    // Geter/Seter���̑��֐�**************************************************************
    // �X�e�[�W�S���擾
    public StageClearDate[] GetStageInformation()
    {
        return AllStage;
    }

    // �X�e�[�W�S���Z�b�g
    public void SetStageInformation(StageClearDate[] date)
    {
        AllStage = date;
    }

    // �X�e�[�W���擾
    public int GetStageIndex()
    {
        return StageIndex;
    }

    // �X�e�[�W���Z�b�g
    public void SetStageIndex(int date)
    {
        StageIndex = date;
    }

    // �w�肵���X�e�[�W�̃N���A�󋵂𒼐ڕύX����ϐ�
    public void SetInformation(int stageNo,StageClearState state) /*stageNo = �ʂ��ԍ�*/
    {
        AllStage[stageNo].State = state;
    }

    // �X�e�[�W���N���A�������Ɏg���֐�
    public void ClearStage(int stageNo) /*stageNo = �ʂ��ԍ�*/
    {
        // ��������ʂ��ԍ��X�e�[�W���N���A�ɕύX
        AllStage[stageNo].State = StageClearState.CLEAR;
        // ���̃X�e�[�W���`�������W�̕ύX
        AllStage[stageNo + 1].State = StageClearState.CHALLENGE;
    }

    void Awake()
    {
        CheckInstance();
    }


    // �X�^�[�g
    void Start()
    {
        // �V�[�����ׂ��ł����̃I�u�W�F�N�g�͏����Ȃ�
        DontDestroyOnLoad(this.gameObject);
    }

    // �A�b�v�f�[�g
    void Update()
    {
        
    }

    void CheckInstance()
    {
        if (instance == null)
        {
            instance = this.gameObject;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
