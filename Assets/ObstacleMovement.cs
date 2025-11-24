using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Vector3 pointA = new Vector3(29, 11, 17); // Start point
    public Vector3 pointB = new Vector3(41, 11, 23); // End point
    public float speed = 1.0f; // Movement speed

    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1); // Bounce time calculation
        transform.position = Vector3.Lerp(pointA, pointB, time); // Moves object between point A and B
    }
}