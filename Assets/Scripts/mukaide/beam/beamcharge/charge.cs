using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charge : MonoBehaviour
{
    public ParticleSystem Charge; //パーティクルの取得
    public GameObject beamcharge;

    // Start is called before the first frame update
    void Start()
    {
        beamcharge = GameObject.Find("beamcharge");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Play();
        }
        if(Input.GetKeyUp(KeyCode.B))
        {
            Stop();
        }

    }
    public void Play()
    {
        if (Charge)
        {
            Charge.Play();
        }
    }

    public void Stop()
    {
        if (Charge)
        {
            Charge.Stop();
        }
    }
}
