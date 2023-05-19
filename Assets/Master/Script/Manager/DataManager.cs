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
    /// �X�R�A�̉��Z
    /// </summary>
    /// <param name="val"></param>
    void AddScore(int val)
    {
        _score = val;
    }

    /// <summary>
    /// ���C�t������炷
    /// </summary>
    void LostLife()
    {
        _life--;
    }

    /// <summary>
    /// �|�����G�̃J�E���g�̉��Z 
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
