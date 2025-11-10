using System;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class HighJump : MonoBehaviour
{
    void Start()
    {

    }
    [SerializeField] PlayerPrefs PlayerController;
  private void OnCollisionEnter(Collision collision)
  {
    Debug.Log("Collision Detected");
  }

    private void OnCollisionExit(Collision collision)
  {
    Debug.Log("Collision Stopped");
  }  
  void Update()
  { 
    
 }
}
