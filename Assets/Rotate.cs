using Unity.VisualScripting;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed = 50f; // Speed of rotation

    private void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0); // Y Axis rotation calaculation
    }
}
