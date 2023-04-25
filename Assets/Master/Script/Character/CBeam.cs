using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beamline
{
    public Vector3 startPos;
    public Vector3 direction;
    public float distance;
    public bool isHit;             // �ڐG�t���O
    public bool enable;
}

public class CBeam : MonoBehaviour
{
    // ���ʕϐ�
    [SerializeField]
    LayerMask hitLayer;     // �Փ˂��郌�C���[

    float speed;            // �r�[���̈ړ����x
    bool useFlag;           // �g�p�t���O

    float maxDistance;      // �r�[���̒���
    float radius = 0.2f;    // �r�[���̔��a
    int layerMask;          // �Փ˂��郌�C���[�̃}�X�N

    RaycastHit hit;

    int currentHeadNo;
    int currentEndNo;

    Vector3 startPos;       // �r�[���̊J�n�ʒu

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
        // �ŏ��̃r�[����ݒ�
        Beamline fastBeamLine = new Beamline();
        fastBeamLine.startPos = tailPos = transform.position;
        fastBeamLine.direction = transform.forward;
        fastBeamLine.distance = 10f;
        fastBeamLine.enable = true;

        beamlines.Add(fastBeamLine);

        // ���C���[�}�X�N�̐ݒ�
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
