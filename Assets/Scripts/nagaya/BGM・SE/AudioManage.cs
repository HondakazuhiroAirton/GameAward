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
                  audioPath: BGMPath.BATTLE27, //再生したいオーディオのパス
                  volumeRate: 1,                //音量の倍率
                  delay: 0,                //再生されるまでの遅延時間
                  pitch: 1,                //ピッチ
                  isLoop: true,             //ループ再生するか
                  allowsDuplicate: false             //他のBGMと重複して再生させるか
                );
        /// </summary>
        /*volumeはfloat*/
        //BGM全体のボリュームを変更
        BGMManager.Instance.ChangeBaseVolume(volume);

        //BATTLE27のBGMだけを一時停止
        BGMManager.Instance.Pause(BGMPath.BATTLE27);

        //一時停止しているBATTLE27のBGMだけを再開
        BGMManager.Instance.UnPause(BGMPath.BATTLE27);

        //全てのBGMを停止
        BGMManager.Instance.Stop();

        //全てのBGMをフェードアウト
        BGMManager.Instance.FadeOut();

        //再生しているBATTLE27だけ2秒でーフェードアウトし、フェードアウト後にログを表示
        BGMManager.Instance.FadeOut(BGMPath.BATTLE27, 2, () => {
            Debug.Log("BGMフェードアウト終了");
        });

    }

}
