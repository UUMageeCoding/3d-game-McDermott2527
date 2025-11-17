using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Vector3 pointA = new Vector3(29, 11, 17);
    public Vector3 pointB = new Vector3(41, 11, 23);
    public float speed = 1.0f;

    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);
    }
}