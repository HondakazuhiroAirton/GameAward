using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteor2 : MonoBehaviour
{
    private float speed = -0.5f;
    public float createPosition;
    public float xPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        createPosition = transform.position.x;
        xPosition = -Screen.width / 100;//-Screen.height;

        // �ʒu�̍X�V
        transform.Translate(Time.deltaTime * speed, 0,0);

        // �Q�[����ʂ���O���Ə�����
        if (xPosition > createPosition)
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
