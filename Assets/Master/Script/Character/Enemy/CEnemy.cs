using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;





public class CEnemy : MonoBehaviour
{
    List<Func<bool>> funcs;
    Func<bool> _funcs;
    int funcIndex;

    void SetAction(Func<bool> funcs)
    {
        _funcs = funcs;
    }





    // Start is called before the first frame update
    void Start()
    {
        funcIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (funcs.Count > funcIndex) return;

        if (_funcs())
        {
            funcIndex++;
            _funcs = funcs[funcIndex];
        }
    }
}
