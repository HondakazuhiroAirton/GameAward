/*****************************************************************//**
 * @file   InputManager.cs
 * @brief  ���̓f�o�C�X�Ǘ��N���X
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

    // �f�o�C�X���q����Ă��邩�ǂ���
    public bool gamepadCurrentConnect => _gamepad != null ? true : false;
    public bool mouseCurrentConnect => _mouse != null ? true : false;
    public bool keyboardCurrentConnect => _keyboard != null ? true : false;

    // �f�o�C�X�`�F�b�N�t���[����
    private const float deviceCheckFrameTime = 30.0f / 60.0f;
    private float _deviceCheckTimeCount = 0;

    protected override void Awake()
    {
        base.Awake();

        _gamepad = Gamepad.current;
        _mouse = Mouse.current;
        _keyboard = Keyboard.current;

        GameInput.actions.Enable();

        // �Q�[���p�b�h���ڑ��������Ƃ��L�[�{�[�h��L��������
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

        // �Q�[���p�b�h���ڑ��������Ƃ��L�[�{�[�h��L��������
        SetKeyboardActive(_gamepad == null);
    }


    // �Q�[���p�b�h�̗L�����֐�
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

    // �}�E�X�̗L�����֐�
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

    // �L�[�{�[�h�̗L�����֐�
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

    // �f�o�C�X�̗L�����֐�
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
