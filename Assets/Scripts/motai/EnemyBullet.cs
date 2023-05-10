using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    // �L���[�u(�G��)
    [SerializeField] GameObject ball;
    [SerializeField] GameObject player;
    Animator animator;
    public const float maxtime = 5.0f;
    public const float mintime = 2.0f;
    public float time;

    void Start()
    {
        // animator�R���|�[�l���g���擾
        animator = GetComponent<Animator>();

        player = GameObject.Find("Player");
    }

    void Update()
    {
        if (player == null) return;

        time += Time.deltaTime;

        if (time >= mintime)// 2�b��������A�j���[�V�����X�^�[�g
        {
            animator.SetBool("enemyS_flag", true);//3�b�`4�b�E4�b�`5�b��2��
        }
        if (time >= maxtime)// 5�b��������e���o�ăA�j���[�V�����X�g�b�v �^�C�}�[0
        {
            BallShot();
            animator.SetBool("enemyS_flag", false);
            time = 0;
            return;
        }



    }

    void BallShot()// �L���[�u(�G��)
    {

        // ���܂𐶂ݏo���Ă�
        Instantiate(ball, transform.position, this.transform.rotation);
        
    }
}