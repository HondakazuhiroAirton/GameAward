using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour
{
    public GameObject thunder;
    Vector3 createPosition;



    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            createPosition = transform.position;
            createPosition.y -= 1.0f; // �_��y���W - 1�̈ʒu�ɗ��𐶐�����

            Instantiate(thunder, createPosition, Quaternion.identity);
        }

    }
}
