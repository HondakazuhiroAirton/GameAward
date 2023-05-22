using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamManagerScript : MonoBehaviour
{
    // AudioSourceコンポーネント取得
    private AudioSource audio;
    
    void Start()
    {
        // AudioSource取得
        audio = this.GetComponent<AudioSource>();
    }

    void Update()
    {
        // 子オブジェクト全てが非アクティブの時、マネージャーデリート

        // 子オブジェクトの数を取得
        int childCount = transform.childCount;

        // 非アクティプの数
        int falseCount = 0;

        // 前から順に子オブジェクトのアクティブを確認する
        for (int i = 0; i < childCount; i++)
        {
            // 子オブジェクトを順に取得する
            Transform childTransform = transform.GetChild(i);
            GameObject childObject = childTransform.gameObject;

            // アクティブを確認する
            // 非アクティブだった場合
            if (childObject.activeSelf == false)
            {
                falseCount++;
            }
            else // アクティブだった場合
            {
                // for分終わり
                break;
            }

        }


        if (Time.deltaTime <= 0)
        {
            audio.enabled = false;
        }
        else
        {
            audio.enabled = true;
        }

        // 子オブジェクトが全部非アクティプの場合
        if (falseCount >= childCount)
        {
            // マネージャー削除
            Destroy(this.gameObject);
        }
    }
}
