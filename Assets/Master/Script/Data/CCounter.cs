using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCounter<T>
{
    private T _Val;
    protected T Val => _Val;

    public CCounter(T val)
    {
        _Val = val;
    }

    virtual protected void Set(T val)
    {
        _Val = val;
    }
}
