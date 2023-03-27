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


    // ���ʕϐ�
    [SerializeField]
    LayerMask hitLayer;     // �Փ˂��郌�C���[

    float speed;            // �r�[���̈ړ����x
    bool useFlag;
    bool isHit;             // �ڐG�t���O

    float maxDistance;      // �r�[���̒���
    float radius = 0.2f;
    private int layerMask;  // �Փ˂��郌�C���[�̃}�X�N
    RaycastHit hit;


    Vector3 startPos;       // �r�[���̊J�n�ʒu
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
