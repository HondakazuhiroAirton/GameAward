using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamProto : MonoBehaviour
{
    [SerializeField]
    LayerMask hitLayer; // 衝突するレイヤー
    [SerializeField]
    float speed;        // ビームの移動速度
    [SerializeField]
    float maxDistance;  // ビームの長さ

    float radius = 0.2f;
    private int layerMask; // 衝突するレイヤーのマスク
    RaycastHit hit;

    bool isHit;

    float time;

    [SerializeField]
    float maxtime;

    Vector3 tailPos; // ビームの終端
    Vector3 headPos; // ビームの始端

    //List<BeamProto>
    // Start is called before the first frame update
    void Start()
    {
        layerMask = hitLayer;
        speed = 10;
        tailPos = transform.position;
        maxDistance = 10;
        maxtime = 0.2f;
        isHit = false;
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        bool Hit;
        // RaycastHit hit;
        tailPos += transform.forward * speed * Time.deltaTime;

        if (!isHit)
        {
            Hit = Physics.SphereCast(tailPos, radius, transform.forward, out hit, maxDistance, layerMask);
            if (Hit)
            {
                isHit = true;
                Debug.Log("hit");
            }
        }
        else if (isHit)
        {
            if (time <= maxtime)
            {
                time += Time.deltaTime;
                maxDistance -= speed * Time.deltaTime;
                if (maxDistance <= 0)
                {
                    maxDistance = 0;
                }
            }
            else
            {
                time = 0;
                Hit = Physics.SphereCast(tailPos, radius, transform.forward, out hit, maxDistance, layerMask);
                if (!Hit)
                {
                    isHit = false;
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawRay(tailPos, transform.forward * maxDistance);

        if (isHit) Gizmos.color = Color.red;
        else Gizmos.color = Color.white;
        
        Gizmos.DrawSphere(tailPos + transform.forward * maxDistance, radius);
    }
}
