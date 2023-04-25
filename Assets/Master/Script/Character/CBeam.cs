using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beamline
{
    public Vector3 startPos;
    public Vector3 direction;
    public float distance;
    public bool isHit;             // 接触フラグ
    public bool enable;
}

public class CBeam : MonoBehaviour
{
    // 共通変数
    [SerializeField]
    LayerMask hitLayer;     // 衝突するレイヤー

    float speed;            // ビームの移動速度
    bool useFlag;           // 使用フラグ

    float maxDistance;      // ビームの長さ
    float radius = 0.2f;    // ビームの半径
    int layerMask;          // 衝突するレイヤーのマスク

    RaycastHit hit;

    int currentHeadNo;
    int currentEndNo;

    Vector3 startPos;       // ビームの開始位置

    Vector3 headPos;
    Vector3 tailPos;

    float time;
    float maxTime;

    List<Beamline> beamlines = new List<Beamline>();

    bool hitTrigger;

    Vector3 hetPos;

    // Start is called before the first frame update
    void Start()
    {
        // 最初のビームを設定
        Beamline fastBeamLine = new Beamline();
        fastBeamLine.startPos = tailPos = transform.position;
        fastBeamLine.direction = transform.forward;
        fastBeamLine.distance = 10f;
        fastBeamLine.enable = true;

        beamlines.Add(fastBeamLine);

        // レイヤーマスクの設定
        layerMask = hitLayer;

        currentHeadNo = currentEndNo = 0;
        hitTrigger = false;

        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        beamlines[currentEndNo].startPos += beamlines[currentEndNo].direction * speed * Time.deltaTime;

        var Hit = Physics.SphereCast(
            beamlines[currentEndNo].startPos, radius,
            beamlines[currentEndNo].direction, out hit,
            beamlines[currentEndNo].distance, layerMask);

        //Physics.CheckBox()
        //Physics.OverlapSphere();
        if (Hit && !hitTrigger)
        {
            hitTrigger = true;
            hetPos = hit.point;
            beamlines[currentEndNo].isHit = true;
            beamlines[currentEndNo].enable = true;
            var createBeamLine = hit.collider.GetComponent<ICollisionAction>().CollisionEvent(beamlines[currentEndNo]);
        }

        if (hitTrigger)
        {
            beamlines[currentEndNo].distance -= speed * Time.deltaTime;

            if (beamlines[currentEndNo].distance <= 0)
            {
                hitTrigger = false;
                beamlines[currentEndNo].distance = 0;

                // beamlines[currentEndNo].startPos = hetPos;
                // currentEndNo++;
            }
        }

        Debug.Log(beamlines[currentEndNo].distance);

        foreach (var line in beamlines)
        {
            if (!useFlag) continue;
           


        }
    }



    private void OnDrawGizmos()
    {
        if (beamlines.Count == 0) return;

        foreach (var line in beamlines)
        {
            if (!line.enable) continue;
            Gizmos.color = Color.white;
            Gizmos.DrawRay(line.startPos, line.direction * line.distance);
        }
    }
}
