using Overdrive.ProBuilderPlus;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinZone : MonoBehaviour
{
    public GameObject winScreen;
    void Start()
    {
    }

    void OnTriggerEnter(Collider other) // Activates on a collision
    {
        Time.timeScale = 0f;
    }
    void Update()
    {
        
    }
}
