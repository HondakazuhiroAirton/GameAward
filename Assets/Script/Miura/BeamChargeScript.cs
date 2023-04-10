using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BeamComboScript : MonoBehaviour
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
        // tmp��Combo�̐��l������
        float tmpCombo = PlayerClassScript.GetAmount();

        // ���t���[���r�[���c��(Amount)�̒l��\������
        this.textComponent.text = tmpCombo + "Combo" .ToString();

    }
}