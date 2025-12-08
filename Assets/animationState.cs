using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class animationState : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalking", true);
        }

        if (!Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalking", false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("isJumping", true);
        }

        if (!Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("isJumping", false);
        }
    }
}
