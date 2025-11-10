using UnityEngine;

public class WinZone : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("You Win!");
    }
    void Update()
    {
        
    }
}
