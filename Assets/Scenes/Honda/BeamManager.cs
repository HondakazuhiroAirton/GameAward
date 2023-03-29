using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamManager : MonoBehaviour
{
    [SerializeField]
    private GameObject Beam;

    float ChargeTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            var startPos = this.gameObject.transform.position;
            Instantiate(Beam, startPos, this.gameObject.transform.rotation);
        }
    }


    private void FixedUpdate()
    {

    }
}