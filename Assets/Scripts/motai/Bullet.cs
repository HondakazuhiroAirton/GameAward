using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float ballSpeed = 10.0f;
    private float Wx;
    private float Wy;

    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {

        var moveVal = transform.forward * ballSpeed * Time.deltaTime;
        transform.position += moveVal;

        Wx = Screen.width / 15;
        Wy = Screen.height / 15;
        Debug.Log("スクリーンx =" + Wx);
        Debug.Log("スクリーンy =" + Wy);

        if (transform.position.x == Wx || transform.position.y == Wy )
        {
            GameObject.Destroy(this.gameObject);
        }
        if(-transform.position.x == -Wx || -transform.position.y == -Wy)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
    /*void OnBecameInvisible()
    {
        GameObject.Destroy(this.gameObject);
    }*/
}
