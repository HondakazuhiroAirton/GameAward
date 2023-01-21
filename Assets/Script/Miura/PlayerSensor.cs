using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSensor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("“–‚½‚è”»’è");
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("ŽË’öŒ—“à‚¾‚æ");
            transform.parent.GetComponent<Enemy>().SetEnemyState(2);
        }
    }

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    transform.parent.GetComponent<Enemy>().SetEnemyState(0);
    //}

}
