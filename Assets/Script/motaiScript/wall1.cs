using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall1 : MonoBehaviour
{
    public GameObject meteor;
    Vector2 createPosition;

    public float minTime = 4.0f;
    public float maxTime = 6.0f;
    public float interval;
    public float time = 0.0f;
    public float xMinPosition = Screen.width;
    public float xMaxPosition = Screen.width;
    public float yMinPosition = -Screen.height;
    public float yMaxPosition = Screen.height;

    // Start is called before the first frame update
    void Start()
    {
        interval = GetRandomTime();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > interval)
        {
            createPosition = transform.position;
            createPosition.x -= 1.0f;
            createPosition = GetRandomPossition();
            Instantiate(meteor, createPosition, Quaternion.identity);
            time = 0.0f;
            interval = GetRandomTime();
        }
    }

    private float GetRandomTime()
    {
        return Random.Range(minTime, maxTime);
    }

    private Vector2 GetRandomPossition()
    {
        float x = Random.Range(xMinPosition, xMaxPosition);
        float y = Random.Range(yMinPosition, yMaxPosition);

        return new Vector2(x, y);
    }
}
