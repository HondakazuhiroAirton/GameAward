using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflector : MonoBehaviour
{
    public GameObject reflector;
    public GameObject[] Object;

    public ReflectorData[] reflectorData;

    // StageChanger�I�u�W�F�N�g
    public GameObject StageChanger;

    // Start is called before the first frame update
    void Start()
    {
        // �e�̃I�u�W�F�N�g(StageChanger)���擾
        StageChanger = GameObject.Find("StageChanger");
        // �X�N���v�g���NextStage���擾
        StageNo nextStageNo = StageChanger.GetComponent<StageChangerScript>().NextStage;
        Debug.Log(nextStageNo);

        // NextStage�̔ԍ��œǂݍ��ރt�@�C���𕪊򂷂�
        switch (nextStageNo)
        {
            case StageNo.Stage1_1:
                reflectorData = Stage11.reflectordatas;
                break;
        }
        // �o��
        //Object[0] = Instantiate(
        //    reflector,
        //    new Vector3(reflectorData[0].PosX, reflectorData[0].PosY, reflectorData[0].PosZ),
        //    Quaternion.identity,
        //    transform
        //    );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
