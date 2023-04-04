using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DontDestroy : MonoBehaviour
{

    public static GameObject instance;

    // Start is called before the first frame update
    void Start()
    {      
        DontDestroyOnLoad(this.gameObject);    
    }

    void Awake()
    {
        CheckInstance();
    }

    // Update is called once per frame
    void Update()
    { 

    }

    void CheckInstance()
    {
        if (instance == null)
        {
            instance = this.gameObject;
        }
       else
        {
            Destroy(gameObject);
        }
    }
}
