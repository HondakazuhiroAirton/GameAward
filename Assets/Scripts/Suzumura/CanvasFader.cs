using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]

public class CanvasFader : MonoBehaviour
{
    //フェード用のキャンバス
    private CanvasGroup _canvasGroup;

    //フェードの状態
    private enum FadeState
    {
        None,
        FadeIn,
        FadeOut
    }
    private FadeState _fadeState = FadeState.None;

    //フェード時間
    [SerializeField] private float _duration;

    //タイムスケールを無視するか
    [SerializeField] private bool _ignoreTimeScale = true;

    //フェード終了後のコールバック
    private Action _onFinished = null;

    // フェード切り替え回数
    private int FadeCount = 0;

    public GameObject AppearanceNoticeObj;
    private AppearanceNotice appearanceNotice;


    // Start is called before the first frame update
    void Start()
    {
        appearanceNotice = AppearanceNoticeObj.GetComponent<AppearanceNotice>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_fadeState == FadeState.None)
        {
            return;
        }

        float fadeSpeed = 1f / _duration;
        if (_ignoreTimeScale)
        {
            fadeSpeed *= Time.unscaledDeltaTime;
        }
        else
        {
            fadeSpeed *= Time.deltaTime;
        }

        _canvasGroup.alpha += fadeSpeed * (_fadeState == FadeState.FadeIn ? 1f : -1f);

        //フェード終了判定
        // フェード中
        if (_canvasGroup.alpha > 0 && _canvasGroup.alpha < 1)
        {
            return;
        }
        
        // 透明になった→フェードインに変更
        if (_canvasGroup.alpha == 0 && FadeCount<5)
        {
            _fadeState = FadeState.FadeIn;
            FadeCount++;
            return;
        }
        // くっきり映った→フェードアウトに変更
        else if (_canvasGroup.alpha == 1 && FadeCount < 5)
        {
            _fadeState = FadeState.FadeOut;
            FadeCount++;
            return;
        }

        // ここまで処理が進んだらフェードが終わっている
        _onFinished?.Invoke();

        _fadeState = FadeState.None;
        appearanceNotice.DestroyExclamation();       // クローンを削除
        this.enabled = false;
    }

    public static CanvasFader Begin(GameObject target, bool isFadeOut, float duration, bool ignoreTimeScale = true, Action onFinished = null)
    {   //　                                                                                ↑ignoreTimeScaleとonFinishedは省略可
        CanvasFader canvasFader = target.GetComponent<CanvasFader>();
        if (canvasFader == null)
        {
            canvasFader = target.AddComponent<CanvasFader>();
        }

        canvasFader.Play(isFadeOut, duration, ignoreTimeScale, onFinished);

        return canvasFader;
    }
    public void Play(bool isFadeOut, float duration, bool ignoreTimeScale = true, Action onFinished = null)
    {
        this.enabled = true;

        if (_canvasGroup == null)
        {
            _canvasGroup = GetComponent<CanvasGroup>();
        }

        _canvasGroup.alpha = isFadeOut ? 1 : 0;
        _fadeState = isFadeOut ? FadeState.FadeOut : FadeState.FadeIn;

        _duration = duration;
        _ignoreTimeScale = ignoreTimeScale;
        _onFinished = onFinished;
    }
}
