using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteor1 : MonoBehaviour
{
    private float speed = -0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // à íuÇÃçXêV
        transform.Translate(0,Time.deltaTime * speed,0);
    }

    /*void OnBecameInvisible()
    {
        GameObject.Destroy(this.gameObject);
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
