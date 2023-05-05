using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager s_instance;

    // ƒQ[ƒ€‹N“®‚ÉŒÄ‚Î‚ê‚éŠÖ”
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void Initialize()
    {
        new GameObject("GameManager", typeof(GameManager));
        new GameObject("GameManager", typeof(InputManager));




    }


    protected void Awake()
    {
        Application.targetFrameRate = 60;

        if (s_instance)
        {
            Destroy(this.gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnDestroy()
    {

    }
}
