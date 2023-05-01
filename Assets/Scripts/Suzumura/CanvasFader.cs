using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]

public class CanvasFader : MonoBehaviour
{
    //�t�F�[�h�p�̃L�����o�X
    private CanvasGroup _canvasGroup;

    //�t�F�[�h�̏��
    private enum FadeState
    {
        None,
        FadeIn,
        FadeOut
    }
    private FadeState _fadeState = FadeState.None;

    //�t�F�[�h����
    [SerializeField] private float _duration;

    //�^�C���X�P�[���𖳎����邩
    [SerializeField] private bool _ignoreTimeScale = true;

    //�t�F�[�h�I����̃R�[���o�b�N
    private Action _onFinished = null;

    // �t�F�[�h�؂�ւ���
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

        //�t�F�[�h�I������
        // �t�F�[�h��
        if (_canvasGroup.alpha > 0 && _canvasGroup.alpha < 1)
        {
            return;
        }
        
        // �����ɂȂ������t�F�[�h�C���ɕύX
        if (_canvasGroup.alpha == 0 && FadeCount<5)
        {
            _fadeState = FadeState.FadeIn;
            FadeCount++;
            return;
        }
        // ��������f�������t�F�[�h�A�E�g�ɕύX
        else if (_canvasGroup.alpha == 1 && FadeCount < 5)
        {
            _fadeState = FadeState.FadeOut;
            FadeCount++;
            return;
        }

        // �����܂ŏ������i�񂾂�t�F�[�h���I����Ă���
        _onFinished?.Invoke();

        _fadeState = FadeState.None;
        appearanceNotice.DestroyExclamation();       // �N���[�����폜
        this.enabled = false;
    }

    public static CanvasFader Begin(GameObject target, bool isFadeOut, float duration, bool ignoreTimeScale = true, Action onFinished = null)
    {   //�@                                                                                ��ignoreTimeScale��onFinished�͏ȗ���
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
