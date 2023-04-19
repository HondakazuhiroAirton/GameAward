using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursoll : MonoBehaviour
{
    // ゲームオブジェクト配列で管理
    public GameObject[] iti;

    // 今の位置を入れておく変数
    [SerializeField] private int NowPosition;

    void Start()
    {
        // 最初はステージ1
        NowPosition = 0;
        this.transform.position = iti[NowPosition].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            NowPosition += 1;
            if (NowPosition > 2/*<-マジックナンバー ワールドの合計の数-1を入れたい*/) NowPosition = 0;
            this.transform.position = iti[NowPosition].transform.position;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            NowPosition -= 1;
            if (NowPosition < 0) NowPosition = 2;/*<-マジックナンバー ワールドの合計の数-1を入れたい*/
            this.transform.position = iti[NowPosition].transform.position;
        }
    }
}
