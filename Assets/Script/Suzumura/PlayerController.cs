using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    void FixedUpdate()
    {
        // 入力をxに代入
        float x = Input.GetAxis("Horizontal");

        // 同一のGameObjectが持つRigidbodyコンポーネントを取得
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        // rigidbodyのx軸に力を加える
        rigidbody.AddForce(x, 0, 0);
    }
}
