using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    //private Vector3 objPosition;
    public ParticleSystem ps;
    public Ray ray;
    private Vector3 Position;
    //private GameObject Player;

    void Start()
    {
       
        ps.Stop();

        ray.GetPoint(10000f);
        ray.ToString();

        //ray.GetPoint(100f);
        //ray.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * 100f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * 100f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * 100f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * 100f * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Q))//左回転
        {
            transform.Rotate(Vector3.down * 10);
        }
        if (Input.GetKeyDown(KeyCode.E))//右回転
        {
            transform.Rotate(Vector3.up * 10);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            ps.Play();
        }
    }
    private void OnParticleCollision(GameObject other)
    {

        GameObject obj = GameObject.Find("Cube");
        //GameObject obj2 = GameObject.Find("Cube(1)");
        Destroy(obj);
        //Destroy(obj2);
        // もし衝突した相手オブジェクトの名前が"Cube"ならば
        /*if (gameObject.tag == "Enemy")
        {
            // 衝突した相手オブジェクトを削除する
            Destroy(gameObject);
        }*/
    }
}
