using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamManagerScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        // ��������Player���������Ċi�[
        GameObject Player = GameObject.Find("Player");
        // �}�l�[�W���[�J�n���Ƀv���C���[����T�C�Y������Ă���
        // <Player_kari>�̕�����Player�ɂ���X�N���v�g�̖��O�ɕύX
        float ParticleSize = Player.GetComponent<Player_kari>().ParticleSize;

        this.transform.localScale = new Vector3(ParticleSize, ParticleSize, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
