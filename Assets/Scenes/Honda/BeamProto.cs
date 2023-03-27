using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamProto : MonoBehaviour
{

    public class Beamline
    {
        public Vector3 startPos;
        public Vector3 direction;
        public float distance;
    }


    // 共通変数
    [SerializeField]
    LayerMask hitLayer;     // 衝突するレイヤー

    float speed;            // ビームの移動速度
    bool useFlag;
    bool isHit;             // 接触フラグ

    float maxDistance;      // ビームの長さ
    float radius = 0.2f;
    private int layerMask;  // 衝突するレイヤーのマスク
    RaycastHit hit;


    Vector3 startPos;       // ビームの開始位置
    Vector3 headPos;
    Vector3 tailPos;


    float time;
    float maxTime;

    List<Beamline> beamlines = new List<Beamline>();

    // Start is called before the first frame update
    void Start()
    {
        Beamline fastBeamLine = new Beamline();

        fastBeamLine.startPos = tailPos = transform.position;
        fastBeamLine.direction = transform.forward;
        fastBeamLine.distance = 10f;
        beamlines.Add(fastBeamLine);
        layerMask = hitLayer;
        speed = 10;
     
    }

    // Update is called once per frame
    void Update()
    {
        // bool isHit;
        // RaycastHit hit;

        foreach (var line in  beamlines)
        {

            line.startPos += line.direction * speed * Time.deltaTime;
            Debug.Log(line.startPos);
            var Hit = Physics.SphereCast(line.startPos, radius, line.direction, out hit, line.distance, layerMask);


            if (Hit) isHit = true;

            if (isHit)
            {
                line.distance -= speed * Time.deltaTime;
                //time += Time.deltaTime;
                if (line.distance <= 0)
                {
                    line.distance = 0;
                    isHit = false;
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        if (beamlines.Count == 0) return;

        foreach (var line in beamlines)
        {
            Gizmos.color = Color.white;
            Gizmos.DrawRay(line.startPos, line.direction * line.distance);
        }

        
        if (isHit) Gizmos.color = Color.red;
        else Gizmos.color = Color.white;

        Gizmos.DrawSphere(startPos + transform.forward * maxDistance, radius);
    }


    public void CreateBeamLine()
    {

    }
}
