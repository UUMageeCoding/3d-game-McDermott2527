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
   
    void Update()
    {
      void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Detected");
    }  
    }
}
