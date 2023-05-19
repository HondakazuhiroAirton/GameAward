using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUp 
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void Initialize()
    {
        new GameObject("GameManager", typeof(GameManager));
        new GameObject("InputManager", typeof(InputManager));



        Application.targetFrameRate = 60;

    }
}
