using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamProto : MonoBehaviour
{
    [SerializeField]
    LayerMask hitLayer; // �Փ˂��郌�C���[
    [SerializeField]
    float speed;        // �r�[���̈ړ����x
    [SerializeField]
    float maxDistance;  // �r�[���̒���

    float radius = 0.2f;
    private int layerMask; // �Փ˂��郌�C���[�̃}�X�N
    RaycastHit hit;

    bool isHit;

    float time;

    [SerializeField]
    float maxtime;

    Vector3 tailPos; // �r�[���̏I�[
    Vector3 headPos; // �r�[���̎n�[

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
