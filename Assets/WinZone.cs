using UnityEngine;

public class WinZone : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other) // Activates on a collision
    {
        Debug.Log("You Win!");
    }
    void Update()
    {
        
    }
}
