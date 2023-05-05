using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BeamHead : MonoBehaviour
{
    // ���ʕϐ�
    [SerializeField]
    LayerMask hitLayer;     // �Փ˂��郌�C���[

    [SerializeField]
    float _speed;           // �r�[���̈ړ����x

    [SerializeField]
    float maxDistance;      // �r�[���̍ő�̒��� 

    Vector3 pos;            // �r�[��(��[)�̃|�W�V����

    Vector3 dir;            // �r�[���̕���
    float speed;            // �r�[���̈ړ����x
    float rad;              // �r�[���̔��a

    int layerMask;          // �Փ˂��郌�C���[�̃}�X�N

    Ray ray;
    RaycastHit[] hit;


    // Start is called before the first frame update
    void Start()
    {
        rad = transform.lossyScale.x / 2;

        dir = transform.up;         // �ړ������̏�����
        pos = transform.position;   // 

        ray.origin = transform.position;
        ray.direction = -dir;       // �ړ����� 

        layerMask = hitLayer;
    }

    // Update is called once per frame
    void Update()
    {
        pos = dir * _speed * Time.deltaTime;
        transform.position += pos;

        ray.origin = transform.position;

        var HitObjects = Physics.SphereCastAll(ray, rad, maxDistance, layerMask);

        foreach (var obj in HitObjects)
        {
            obj.collider.gameObject.GetComponent<CollisionAction>()?.CollisionEvent(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<ICollisionAction>()?.CollisionEvent(collision);


        //collision.gameObject.GetComponent<ICollisionAction>()?.CollisionEvent() ;
        //foreach (ContactPoint point in collision.contacts)
        //{
        //    // var reflectPos = Vector2.Reflect(transform.position, point.normal);
        //    var reflectPos = point.normal;
        //    dir = reflectPos.normalized;
        //    ray.direction = -dir;
        //}
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(ray.origin, ray.direction * maxDistance);
    }
}
