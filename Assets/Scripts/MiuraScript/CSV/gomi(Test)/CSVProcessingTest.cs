using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CSVProcessingTest : MonoBehaviour
{
    //�@�������ޔz��
    public MonsterData[] monsterData;

    void Start()
    {
        //�@�e�L�X�g�t�@�C���̓ǂݍ��݂��s���Ă����N���X
        TextAsset textasset = new TextAsset();
        //�@csv�t�@�C����ǂݍ��܂���B
        //�@�t�@�C���́uResources�v�t�H���_�����A�����ɓ���Ă������ƁB�܂�"CSVTestData"�̕����̓t�@�C�����ɍ��킹�ĕύX����B
        textasset = Resources.Load("CSVTestData", typeof(TextAsset)) as TextAsset;
        //�@CSVSerializer��p����csv�t�@�C����z��ɗ������ށB
        monsterData = CSVSerializer.Deserialize<MonsterData>(textasset.text);
    }

    void Update()
    {

    }
}
