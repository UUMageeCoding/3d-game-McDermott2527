using UnityEngine;

public class Hurtbox : MonoBehaviour
{
   void OnTriggerEnter(Collider other) // Activates on a collision
    {
        Debug.Log("Hit");
    }
}
