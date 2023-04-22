using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManagerScript : MonoBehaviour
{
    // 全ステ
    public int[][] AllStage;  

    void Start()
    {
        // CSVからもらったデータとくらべて、0またはNULLなら0

        int StageIndex = 0;

        for (int i = 0; i < 4; i++)// World (Worldが全部で4つだから4)
        {
            for (int j = 0; j < 5; j++)// Stage (1Worldに5ステージだから5)
            {

                //switch () // クリアしてるかどうかで判断
                //{


                //}

                // 通し番号を1個進める
                StageIndex++;
            }

        }
    }

    void Update()
    {
        
    }
}
