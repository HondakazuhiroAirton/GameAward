using UnityEngine;



public struct RailData
{
    public float rightEnd;      // 右端
    public float leftEnd;       // 左端
    public Vector3 rotation;    // 回転
    public Vector3 point;       // 中心座標
}



public class Rail : MonoBehaviour
{
    [SerializeField]
    private RailNo _railNo;     // レールのID
    private bool _enable;       // 有効化フラグ

    /// 有効化フラグ
    public bool Active => _enable;
    /// レールのID
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
