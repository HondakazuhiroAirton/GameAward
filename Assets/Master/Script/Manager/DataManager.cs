using System.Collections;
using System.Collections.Generic;
using UnityEngine;




 public class Counter<T>
{
    public Counter(T defaultVal)
    {
        _count = defaultVal;
    }

    private T _count;
    public T Count => _count;

    private T max;
    private T min;

};


public class DataManager
{
    int _score;
    int _beamPower;
    int _life;
    
    void Init()
    {
        

        
    }


    int _specialBeamCount = 0;
   
    int _totalScore = 0;

    /// <summary>
    /// スコアの加算
    /// </summary>
    /// <param name="val"></param>
    void AddScore(int val)
    {
        _score = val;
    }

    /// <summary>
    /// ライフを一つ減らす
    /// </summary>
    void LostLife()
    {
        _life--;
    }

    /// <summary>
    /// 倒した敵のカウントの加算 
    /// </summary>
   

    // Start is called before the first frame update
    void Start()
    {
        _beamPower = 10000;
        _specialBeamCount = 0;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="val"></param>
    void AddSpecialBeamCount(int val)
    {
        _specialBeamCount += val;
    }

    void UseBeamPower(int val)
    {
        _beamPower -= val;
    }
}
