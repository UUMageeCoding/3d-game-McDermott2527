using Overdrive.ProBuilderPlus;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinZone : MonoBehaviour
{
    public GameObject winScreen;
    void Start()
    {
        winScreen = GameObject.Find("WinScreen");
        winScreen.SetActive(false);
    }

    void OnTriggerEnter(Collider other) // Activates on a collision
    {
        winScreen.SetActive(true);
        Time.timeScale = 0f;
    }
    void Update()
    {
        
    }
}
