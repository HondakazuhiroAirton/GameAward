using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamManagerScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        // 生成時にPlayerを検索して格納
        GameObject Player = GameObject.Find("Player");
        // マネージャー開始時にプレイヤーからサイズを取ってくる
        // <Player_kari>の部分はPlayerにつけるスクリプトの名前に変更
        float ParticleSize = Player.GetComponent<Player_kari>().ParticleSize;

        this.transform.localScale = new Vector3(ParticleSize, ParticleSize, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
