using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Effekseer;

public class BeamEffect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // �G�t�F�N�V�A�̃G�t�F�N�g���炤
        EffekseerEffectAsset effect = Resources.Load<EffekseerEffectAsset>("beemeee");

        // transform�̈ʒu�ŃG�t�F�N�g���Đ�����
        EffekseerHandle handle = EffekseerSystem.PlayEffect(effect, transform.position);

        //// �v���C���[��Z�p�x�����Ă���
        //float tmp = Player.transform.eulerAngles.z;
        //// tramsform�̉�]��ݒ肷��
        //Quaternion rot = Quaternion.Euler(tmp - 90, 270, 90);
        handle.SetRotation(Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
