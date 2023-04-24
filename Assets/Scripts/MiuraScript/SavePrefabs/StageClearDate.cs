using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StageClearDate
{
    public string stage; // �X�e�[�W�̖��O
    public int StageNo; // �X�e�[�W�ԍ�
    public StageClearState State; // �N���A��

}

// �X�e�[�W�̈���
public enum StageClearState
{
    NONE = 0, // �X�e�[�W�����o��
    CHALLENGE = 1, // �X�e�[�W���풆
    CLEAR = 2   // �X�e�[�W�N���A
}