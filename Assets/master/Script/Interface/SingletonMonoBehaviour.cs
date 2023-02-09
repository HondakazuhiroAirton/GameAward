// SingletonMonoBehaviour.cs
// �V���O���g�����N���X�t�@�C��
using System;
using UnityEngine;


/**
 * �V���O���g�����N���X
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
                    Debug.LogError(t + " ���A�^�b�`���Ă���GameObject�͂���܂���");
                }
            }
            return s_instance;
        }
    }

    virtual protected void Awake()
    {
        // ����GameObject�ɃA�^�b�`����Ă��邩�ꍇ�͔j������
        if (this != Instance)
        {
            Destroy(this);
            Debug.LogError(typeof(T) +�@" �͊��ɑ���GameObject(" + Instance.gameObject.name + ")�ɃA�^�b�`����Ă��邽�ߔj������܂���");
            return;
        }

        DontDestroyOnLoad(this.gameObject);
    }
}