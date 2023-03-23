using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollision2 : MonoBehaviour
{
    /// <summary>
    /// �p�[�e�B�N��������GameObject(Collider)�ɓ�����ƌĂяo�����
    /// </summary>
    /// <param name="other"></param>
    private void OnParticleCollision(GameObject other)
    {
        // ������������̐F�������_���ɕς���
        //other.gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();

        // �����ɓG���r�[���ɓ��������Ƃ��̏����������Ƃ悳����
        if (other.gameObject.tag == "board")//shaft
        {
            GameObject obj = GameObject.FindGameObjectWithTag("board");
            obj.transform.Rotate(Vector3.down * 90);
        }
        if (other.gameObject.tag == "Enemy")
        {
            GameObject obj = GameObject.FindGameObjectWithTag("Enemy");
            Destroy(obj);
        }
    }
}