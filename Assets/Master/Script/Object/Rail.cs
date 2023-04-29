using UnityEngine;



public struct RailData
{
    public float rightEnd;      // �E�[
    public float leftEnd;       // ���[
    public Vector3 rotation;    // ��]
    public Vector3 point;       // ���S���W
}



public class Rail : MonoBehaviour
{
    [SerializeField]
    private RailNo _railNo;     // ���[����ID
    private bool _enable;       // �L�����t���O

    /// �L�����t���O
    public bool Active => _enable;
    /// ���[����ID
    public RailNo RailNo => _railNo;

    private void Start()
    {
        Enable();
    }

    public void Enable()
    {
        _enable = true;
    }

    public void Disable()
    {
        _enable = false;
    }


    public RailData GetRailData()
    {
        RailData railDeta;
        railDeta.rightEnd = transform.position.x + transform.localScale.x / 2;
        railDeta.leftEnd = transform.position.x - transform.localScale.x / 2;
        railDeta.rotation = transform.up;
        railDeta.point = transform.position;
        return railDeta;
    }
}
