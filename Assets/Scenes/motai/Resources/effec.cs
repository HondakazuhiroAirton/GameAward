using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Effekseer;

public class effec : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // �G�t�F�N�g���擾����B
        EffekseerEffectAsset effect = Resources.Load<EffekseerEffectAsset>("Bullet");
        // transform�̈ʒu�ŃG�t�F�N�g���Đ�����
        EffekseerHandle handle = EffekseerSystem.PlayEffect(effect, transform.position);
        // transform�̉�]��ݒ肷��B
        handle.SetRotation(transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
