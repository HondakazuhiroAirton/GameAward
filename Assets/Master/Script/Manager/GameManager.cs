using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum GameState
{
    None,
    Start,
    InGame,
    Pause,
    End
}

public class GameManager : MonoBehaviour
{
    private static GameManager s_instance;

    GameState gameState = GameState.None;

    protected void Awake()
    {   
        //if (s_instance)
        //{
        //    Destroy(this.gameObject);
        //    return;
        //}
        //DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)
        {
            case GameState.InGame:


                break;
        }
    }


    void Enter()
    {

    }

    void Run()
    {

    }

    void Exit()
    {

    }

}






