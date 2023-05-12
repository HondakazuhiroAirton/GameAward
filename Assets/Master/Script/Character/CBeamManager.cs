using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBeamManager : MonoBehaviour
{
    float ChargeTime;       // ���͎��� 
    float maxChargeTime;    // �ő���͎���

    float BRemainingAmount;  // �r�[���c��

    float MaxDistance;          // �ő勗��
    float ScaleMagnification;   // �X�P�[���g�嗦
    float DistanceMagnification;// �����g�嗦

    float ScaleLowerLimit;
    float DistanceLowerLimit;
    float BPowerLowerLimit;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ChargeTime += Time.deltaTime;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            ChargeTime = 0;
        }

        if (ChargeTime >= maxChargeTime) ChargeTime = maxChargeTime;

        if (BRemainingAmount <= BPowerLowerLimit) return;



    }

    private void FixedUpdate()
    {



    }


    void CreateBeam(float chargeTime)
    {
        var BeamScale = (chargeTime * ScaleMagnification) + ScaleLowerLimit;
        var BeamDistance = (chargeTime * DistanceMagnification) + DistanceLowerLimit;





    }
}
