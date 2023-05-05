using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BeamHead : MonoBehaviour
{
    // 共通変数
    [SerializeField]
    LayerMask hitLayer;     // 衝突するレイヤー

    [SerializeField]
    float _speed;           // ビームの移動速度

    [SerializeField]
    float maxDistance;      // ビームの最大の長さ 

    Vector3 pos;            // ビーム(先端)のポジション

    Vector3 dir;            // ビームの方向
    float speed;            // ビームの移動速度
    float rad;              // ビームの半径

    int layerMask;          // 衝突するレイヤーのマスク

    Ray ray;
    RaycastHit[] hit;


    // Start is called before the first frame update
    void Start()
    {
        rad = transform.lossyScale.x / 2;

        dir = transform.up;         // 移動方向の初期化
        pos = transform.position;   // 

        ray.origin = transform.position;
        ray.direction = -dir;       // 移動方向 

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
