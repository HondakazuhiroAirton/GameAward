using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BeamChargeScript : MonoBehaviour
{
    // �v���C���[�f�[�^�I�u�W�F�N�g�ێ�
    public GameObject PlayerDate;
    // Geter�g�p�p�̃X�N���v�g�ێ�
    public PlayerClass PlayerClassScript;
    // ���̃I�u�W�F�N�g�̃e�L�X�g�R���|�[�l���g�ۑ�
    private TextMeshProUGUI textComponent;
    void Start()
    {
        // �X�N���v�g���E���Ă���
        PlayerClassScript = PlayerDate.GetComponent<PlayerClass>();
        // �e�L�X�g�R���|�[�l���g�擾
        textComponent = this.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        // tmp��Amount�̐��l������
        float tmpAmount = PlayerClassScript.GetAmount();

        // ����1�����o���ĕ\�������ق������䂵�₷������
        // �\����������2�ʂ܂łɂ���**********************
        // �E��2�V�t�g
        tmpAmount = tmpAmount * 100;
        // ���܂�����
        float Amari = tmpAmount % 1;
        // ����
        tmpAmount = tmpAmount - Amari;
        // ����2�V�t�g���Ė߂�
        tmpAmount = tmpAmount / 100;
        //************************************************

        // ���t���[���r�[���c��(Amount)�̒l��\������
        this.textComponent.text =  tmpAmount +"%" .ToString();

    }
}
