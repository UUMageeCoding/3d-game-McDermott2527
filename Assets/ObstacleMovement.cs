using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] float distanceToCoverX;
    [SerializeField] float speed;

    private Vector3 startingPosition;

    void Start()
    {
        startingPosition = transform.position;
    }
        void Update()
    {
        Vector3 v = startingPosition;
        v.x += distanceToCoverX * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
    }