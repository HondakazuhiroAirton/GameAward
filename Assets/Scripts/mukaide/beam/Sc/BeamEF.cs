using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamEF : MonoBehaviour
{
    public ParticleSystem Beamef; //パーティクルの取得
    public GameObject Create;

    // Start is called before the first frame update
    void Start()
    {
        Beamef = GameObject.Find("trail").GetComponent<ParticleSystem>();
        Create = this.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            BeamCreate();
        }

    }

    public void BeamCreate()
    {
        Instantiate(Beamef, this.transform.position, Quaternion.identity);
    }
}
