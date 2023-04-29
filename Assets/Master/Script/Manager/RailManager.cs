using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum RailNo
{
    UP = 0,
    RIGHT,
    DOWN,
    LEFT,
}


public class RailManager : MonoBehaviour
{
    private List<Rail> _rails;
  
   
    void Start()
    {
        var rails = this.gameObject.GetComponentsInChildren<Rail>();
        _rails.AddRange(rails);

        var c = new Comparison<Rail>(Compare);
        _rails.Sort(c);
    }

    public RailData GetRailData(RailNo no)
    {
        return _rails[(int)no].GetRailData();
    }

    static int Compare(Rail a, Rail b)
    {
        return a.RailNo - b.RailNo;
    }
   
}