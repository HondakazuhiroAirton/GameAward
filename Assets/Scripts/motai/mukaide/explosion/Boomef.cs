using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boomef : MonoBehaviour
{
    public ParticleSystem Boom; //パーティクルの取得
    public GameObject boom;

    // Start is called before the first frame update
    void Start()
    {
        boom = GameObject.Find("boom");
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void BoomCreate()
    {
        Instantiate(Boom, this.transform.position, Quaternion.Euler(-180,0,0));
    }
}
