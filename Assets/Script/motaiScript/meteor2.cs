using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteor2 : MonoBehaviour
{
    private float speed = -0.5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �ʒu�̍X�V
        transform.Translate(Time.deltaTime * speed, 0,0);

    }

    /*void OnBecameInvisible()
    {
        GameObject.Destroy(gameObject);
    }*/


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy" || collision.tag == "Player")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
