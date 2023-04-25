using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayerData :MonoBehaviour
{
    [SerializeField]
    private int life;
    [SerializeField]
    private float beamPower;

    CCounter<int> _life;
    CCounter<float> _beamPower;

    // Start is called before the first frame update
    void Start()
    {
        _life = new CCounter<int>(life);
        _beamPower = new CCounter<float>(beamPower);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
