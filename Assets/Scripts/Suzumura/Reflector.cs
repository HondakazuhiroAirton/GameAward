using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflector : MonoBehaviour
{
    public GameObject reflector;
    public GameObject[] Object;

    public ReflectorData[] reflectorData;

    // StageChangerオブジェクト
    public GameObject StageChanger;

    // Start is called before the first frame update
    void Start()
    {
        // 親のオブジェクト(StageChanger)を取得
        StageChanger = GameObject.Find("StageChanger");
        // スクリプト上のNextStageを取得
        StageNo nextStageNo = StageChanger.GetComponent<StageChangerScript>().NextStage;
        Debug.Log(nextStageNo);

        // NextStageの番号で読み込むファイルを分岐する
        switch (nextStageNo)
        {
            case StageNo.Stage1_1:
                reflectorData = Stage11.reflectordatas;
                break;
        }
        // 出現
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
