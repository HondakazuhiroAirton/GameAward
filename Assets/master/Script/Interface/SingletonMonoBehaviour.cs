// SingletonMonoBehaviour.cs
// シングルトン化クラスファイル
using System;
using UnityEngine;


/**
 * シングルトン化クラス
 */
public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T s_instance;
    public static T Instance
    {
        get
        {
            if (s_instance == null)
            {
                Type t = typeof(T);
                s_instance = (T)FindObjectOfType(t);
                if (s_instance == null)
                {
                    Debug.LogError(t + " をアタッチしているGameObjectはありません");
                }
            }
            return s_instance;
        }
    }

    virtual protected void Awake()
    {
        // 他のGameObjectにアタッチされているか場合は破棄する
        if (this != Instance)
        {
            Destroy(this);
            Debug.LogError(typeof(T) +　" は既に他のGameObject(" + Instance.gameObject.name + ")にアタッチされているため破棄されました");
            return;
        }

        DontDestroyOnLoad(this.gameObject);
    }
}