using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // 流し込む配列
    public EnemyData[] enemyData;

    // Start is called before the first frame update
    void Start()
    {
        // テキストファイルの読み込みを行ってくれるクラス
        TextAsset textasset = new TextAsset();
        // csvファイルを読み込ませる
        textasset = Resources.Load("CSVEnemy", typeof(TextAsset)) as TextAsset;
        // CSVSerializerを用いてcsvファイルを配列に流し込む
        enemyData = CSVSerializer.Deserialize<EnemyData>(textasset.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
