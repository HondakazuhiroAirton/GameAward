using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CSVProcessingTest : MonoBehaviour
{
    //　流し込む配列
    public MonsterData[] monsterData;

    void Start()
    {
        //　テキストファイルの読み込みを行ってくれるクラス
        TextAsset textasset = new TextAsset();
        //　csvファイルを読み込ませる。
        //　ファイルは「Resources」フォルダを作り、そこに入れておくこと。また"CSVTestData"の部分はファイル名に合わせて変更する。
        textasset = Resources.Load("CSVTestData", typeof(TextAsset)) as TextAsset;
        //　CSVSerializerを用いてcsvファイルを配列に流し込む。
        monsterData = CSVSerializer.Deserialize<MonsterData>(textasset.text);
    }

    void Update()
    {

    }
}
