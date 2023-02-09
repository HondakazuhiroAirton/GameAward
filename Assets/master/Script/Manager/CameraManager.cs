using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction : int
{
    Left,
    Right,
    Top,
    Bottom,
}

public struct ViewportRect
{
    public float Left;
    public float Right;
    public float Top;
    public float Bottom;
}

public struct ViewportIsOverRect
{
    public bool Left;
    public bool Right;
    public bool Top;
    public bool Bottom;
}

public class CameraManager : MonoBehaviour
{
    protected static CameraManager instance;
    private Camera MainCamera;
    static ViewportRect viewportRect;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        MainCamera = Camera.main;

        var lb = MainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0));
        var rt = MainCamera.ViewportToWorldPoint(new Vector3(1, 1, 0));

        viewportRect.Left = lb.x;
        viewportRect.Right = rt.x;
        viewportRect.Top = rt.y;
        viewportRect.Bottom = lb.y;
    }

    public Camera GetMainCamera()
    {
        return MainCamera;
    }

    public static CameraManager GetInstance()
    {
        return instance;
    }

    public static ViewportRect GetViewportRect()
    {
        return viewportRect;
    }

    public static ViewportIsOverRect TargetIsCheckOverLine(GameObject ObjPos)
    {
        ViewportIsOverRect Rect;

        Rect.Top = ObjPos.transform.position.y > viewportRect.Top ? true : false;
        Rect.Bottom = ObjPos.transform.position.y < viewportRect.Bottom ? true : false;
        Rect.Right = ObjPos.transform.position.x > viewportRect.Right ? true : false;
        Rect.Left = ObjPos.transform.position.x < viewportRect.Left ? true : false;

        return Rect;
    }

}
