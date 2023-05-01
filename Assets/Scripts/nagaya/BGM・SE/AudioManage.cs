using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class AudioManage : MonoBehaviour
{
    int volume;
    
    
    // Start is called before the first frame update
    void Start()
    {
        TitleBgm();
    }

    // Update is called once per frame
    void Update()
    {

    }


    void TitleBgm()
    {
        BGMManager.Instance.Play(
                  audioPath: BGMPath.BATTLE27, //�Đ��������I�[�f�B�I�̃p�X
                  volumeRate: 1,                //���ʂ̔{��
                  delay: 0,                //�Đ������܂ł̒x������
                  pitch: 1,                //�s�b�`
                  isLoop: true,             //���[�v�Đ����邩
                  allowsDuplicate: false             //����BGM�Əd�����čĐ������邩
                );
        /// </summary>
        /*volume��float*/
        //BGM�S�̂̃{�����[����ύX
        BGMManager.Instance.ChangeBaseVolume(volume);

        //BATTLE27��BGM�������ꎞ��~
        BGMManager.Instance.Pause(BGMPath.BATTLE27);

        //�ꎞ��~���Ă���BATTLE27��BGM�������ĊJ
        BGMManager.Instance.UnPause(BGMPath.BATTLE27);

        //�S�Ă�BGM���~
        BGMManager.Instance.Stop();

        //�S�Ă�BGM���t�F�[�h�A�E�g
        BGMManager.Instance.FadeOut();

        //�Đ����Ă���BATTLE27����2�b�Ł[�t�F�[�h�A�E�g���A�t�F�[�h�A�E�g��Ƀ��O��\��
        BGMManager.Instance.FadeOut(BGMPath.BATTLE27, 2, () => {
            Debug.Log("BGM�t�F�[�h�A�E�g�I��");
        });

    }

}
