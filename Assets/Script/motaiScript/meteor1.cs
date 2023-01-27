using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteor1 : MonoBehaviour
{
    private float speed = -0.5f;
    public float createPosition;
    public float yPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        createPosition = transform.position.y;
        yPosition = -Screen.height / 100;//-Screen.width;

        // 位置の更新
        transform.Translate(0, Time.deltaTime * speed, 0);

        // ゲーム画面から外れると消える
        if (yPosition > createPosition)
        {
            GameObject.Destroy(this.gameObject);
            Destroy(this);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {//collision.tag == "Player"
        if (collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
