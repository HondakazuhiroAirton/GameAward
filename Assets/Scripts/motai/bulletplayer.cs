using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletplayer : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    public float ballSpeed = 10.0f;
    // �ʂ̈ړ�����
    public Vector3 moveVal;

    private float Wx;
    private float Wy;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.Find("koa");

        if (enemy != null)
        {
            // �v���C���[�̏ꏊ�擾
            Vector3 EnemyPos = enemy.transform.position;

            // �x�N�g���v�Z
            moveVal = EnemyPos - this.transform.position;

            // ���K��
            moveVal = moveVal.normalized;

            // �␳�W����������
            moveVal.x *= ballSpeed;
            moveVal.y *= ballSpeed;
            moveVal.z *= ballSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // �ʂ𖈃t���[���𓮂����Ă�
        transform.position += moveVal;

        Wx = Camera.main.WorldToViewportPoint(transform.position).x;
        Wy = Camera.main.WorldToViewportPoint(transform.position).y;

        if (0 >= Wx || Wx >= 1)
        {
            GameObject.Destroy(this.gameObject);
        }
        else if (0 >= Wy || Wy >= 1)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Destroy(this.gameObject);
    }
}
