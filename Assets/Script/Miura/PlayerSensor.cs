using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSensor : MonoBehaviour
{

    Vector2 EnemyPos;
    Vector2 CollisionEnemyPos;
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
        else if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("“G‚ð”ð‚¯‚é‚æ");
            EnemyPos = transform.parent.GetComponent<Enemy>().transform.position;
            CollisionEnemyPos = collision.transform.position;
            Vector2 Compare = new Vector2(EnemyPos.x - CollisionEnemyPos.x, EnemyPos.y - CollisionEnemyPos.y);

            if (Compare.x >= 0)
            {
                if (Compare.y >= 0)
                {
                    EnemyPos.x = EnemyPos.x + 100;
                    EnemyPos.y = EnemyPos.y + 100;
                    this.transform.position = EnemyPos;
                    //transform.parent.GetComponent<Enemy>().rb.AddForce(new Vector2(1.5f, 1f));
                }
                else
                {
                    EnemyPos.x = EnemyPos.x + 100;
                    EnemyPos.y = EnemyPos.y - 100;
                    this.transform.position = EnemyPos;
                    //transform.parent.GetComponent<Enemy>().rb.AddForce(new Vector2(1.5f, -1f));
                }
            }
            else if (Compare.x < 0)
            {
                if (Compare.y >= 0)
                {
                    EnemyPos.x = EnemyPos.x - 100;
                    EnemyPos.y = EnemyPos.y + 100;
                    this.transform.position = EnemyPos;
                    //transform.parent.GetComponent<Enemy>().rb.AddForce(new Vector2(-1.5f,1f));
                }
                else
                {
                    EnemyPos.x = EnemyPos.x - 100;
                    EnemyPos.y = EnemyPos.y - 100;
                    this.transform.position = EnemyPos;
                   // transform.parent.GetComponent<Enemy>().rb.AddForce(new Vector2(-1.5f, -1f));
                }
            }
        }
    }

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    transform.parent.GetComponent<Enemy>().SetEnemyState(0);
    //}

}
