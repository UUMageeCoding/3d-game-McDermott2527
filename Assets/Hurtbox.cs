using UnityEngine;

public class Hurtbox : MonoBehaviour
{
   void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hurt");
    }
}
