using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    //private Vector3 objPosition;
    public ParticleSystem ps;
    private Vector3 Position;
    private ParticleSystemTriggerEventType type;
    System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> psa;
    void Start()
    {
        ps.Stop();
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

        if (Input.GetKeyDown(KeyCode.Q))//ç∂âÒì]
        {
            transform.Rotate(Vector3.down * 10);
        }
        if (Input.GetKeyDown(KeyCode.E))//âEâÒì]
        {
            transform.Rotate(Vector3.up * 10);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            ps.Play();
        }
    }
    /*private void OnTriggerEnter(Collider other)
    {
        ps.GetTriggerParticles(type,psa);
        Debug.Log("Hit1");
    }*/
    private void OnCollisionEnter(Collision collision)
    {
        ps.GetTriggerParticles(type, psa);
        Debug.Log("Hit2");
    }
}
