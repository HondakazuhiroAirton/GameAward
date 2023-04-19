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
        Boom = GameObject.Find("red").GetComponent<ParticleSystem>();
        boom = this.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            BoomCreate();
        }

    }

    public void BoomCreate()
    {
        Instantiate(Boom, this.transform.position, Quaternion.Euler(-180,0,0));
    }
}
