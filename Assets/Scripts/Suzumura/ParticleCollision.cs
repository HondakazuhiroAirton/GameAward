using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollision : MonoBehaviour
{
    /// <summary>
    /// �p�[�e�B�N��������GameObject(Collider)�ɓ�����ƌĂяo�����
    /// </summary>
    /// <param name="other"></param>

    public float stopcount = 2.0f;
    public float currenttime = 0;
    public float rotatetime = 0;
    public bool bUse;

    // Start is called before the first frame update
    void Start()
    {
        bUse = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!bUse)
        {
            currenttime += Time.deltaTime;
            rotatetime++;
            if (rotatetime <= 30) BoardCollision.instance.CollisionBoard(3.0f);
            if (currenttime >= stopcount)
            {
                bUse = true;
                currenttime = 0;
                rotatetime = 0;
                Debug.Log("����!");
            }
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        // ������������̐F�������_���ɕς���
        //other.gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();

        // �����ɓG���r�[���ɓ��������Ƃ��̏����������Ƃ悳����
        if (other.gameObject.tag == "Enemy")
        {
            GameObject obj = GameObject.FindGameObjectWithTag("Enemy");
            Destroy(obj);
        }

        // ��]������ɓ����������̏���
        if (other.gameObject.tag == "shaft" && bUse)
        {
            // ��̃p�[�e�B�N���ł����������瓖���蔻����ꎞ�I�ɐ؂�
            if (bUse) bUse = false;
            Debug.Log("��~...");
        }
    }

}