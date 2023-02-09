// ExpansionGameInput.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public partial class GameInput
{
    private static GameInput _instance;
    public static GameInput actions => _instance == null ? _instance = new GameInput() : _instance;
}