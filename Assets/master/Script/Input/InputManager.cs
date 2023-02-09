/*****************************************************************//**
 * @file   InputManager.cs
 * @brief  入力デバイス管理クラス
 *********************************************************************/
using UnityEngine;
using UnityEngine.InputSystem;

public enum Device
{
    None,
    Gamepad,
    Keyboard,
    Mouse,
    All
}

public class InputManager : SingletonMonoBehaviour<InputManager>
{
    private Gamepad _gamepad;
    private Mouse _mouse;
    private Keyboard _keyboard;

    // デバイスが繋がれているかどうか
    public bool gamepadCurrentConnect => _gamepad != null ? true : false;
    public bool mouseCurrentConnect => _mouse != null ? true : false;
    public bool keyboardCurrentConnect => _keyboard != null ? true : false;

    // デバイスチェックフレーム数
    private const float deviceCheckFrameTime = 30.0f / 60.0f;
    private float _deviceCheckTimeCount = 0;

    protected override void Awake()
    {
        base.Awake();

        _gamepad = Gamepad.current;
        _mouse = Mouse.current;
        _keyboard = Keyboard.current;

        GameInput.actions.Enable();

        // ゲームパッドが接続が無いときキーボードを有効化する
        SetKeyboardActive(_gamepad == null);
    }

    void Update()
    {
        _deviceCheckTimeCount += Time.deltaTime;

        if (_deviceCheckTimeCount < deviceCheckFrameTime) return;

        _gamepad = Gamepad.current;
        _mouse = Mouse.current;
        _keyboard = Keyboard.current;

        _deviceCheckTimeCount = 0;

        // ゲームパッドが接続が無いときキーボードを有効化する
        SetKeyboardActive(_gamepad == null);
    }


    // ゲームパッドの有効化関数
    public void SetGamepadActive(bool activeFlag)
    {
        if (activeFlag)
        {       
            InputSystem.EnableDevice(Gamepad.current);
        }
        else
        {
            InputSystem.DisableDevice(Gamepad.current);
        }
    }

    // マウスの有効化関数
    public void SetMouseActive(bool activeFlag)
    {
        if (activeFlag)
        {
            InputSystem.EnableDevice(Mouse.current);
        }
        else
        {
            InputSystem.DisableDevice(Mouse.current);
        }
    }

    // キーボードの有効化関数
    public void SetKeyboardActive(bool activeFlag)
    {
        if (activeFlag)
        {
            InputSystem.EnableDevice(Keyboard.current);
        }
        else
        {
            InputSystem.DisableDevice(Keyboard.current);
        }
    }

    // デバイスの有効化関数
    public void SetDeviceActive(Device device, bool activeFlag)
    {
        switch (device)
        {
            default:
                break;

            case Device.Gamepad:
                {
                    if (activeFlag)
                    {
                        InputSystem.EnableDevice(Gamepad.current);
                    }
                    else
                    {
                        InputSystem.DisableDevice(Gamepad.current);
                    }

                    return;
                }
            case Device.Mouse:
                {
                    if (activeFlag)
                    {
                        InputSystem.EnableDevice(Mouse.current);
                    }
                    else
                    {
                        InputSystem.DisableDevice(Mouse.current);
                    }

                    return;
                }
            case Device.Keyboard:
                {
                    if (activeFlag)
                    {
                        InputSystem.EnableDevice(Keyboard.current);
                    }
                    else
                    {
                        InputSystem.DisableDevice(Keyboard.current);
                    }

                    return;
                }
            case Device.All:
                {
                    if (activeFlag)
                    {
                        InputSystem.EnableDevice(Gamepad.current);
                        InputSystem.EnableDevice(Mouse.current);
                        InputSystem.EnableDevice(Keyboard.current);
                    }
                    else
                    {
                        InputSystem.DisableDevice(Gamepad.current);
                        InputSystem.DisableDevice(Mouse.current);
                        InputSystem.DisableDevice(Keyboard.current);
                    }
                    return;
                }
        }
    }
}
