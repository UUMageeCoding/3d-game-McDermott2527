using UnityEngine;

public class AnimationState : MonoBehaviour
{
    Animator animator;
    PlayerController playerController;
    private CharacterController controller;
    void Start()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        
        if (Input.GetKey(KeyCode.W)) // Activates on pressing W
        {
            animator.SetBool("isWalking", true); // Starts walking the player
        }

        if (!Input.GetKey(KeyCode.W)) // Activates on releasing W
        {
            animator.SetBool("isWalking", false); // Stops walking the player
        }

        if (Input.GetKey(KeyCode.Space)) // Activates on pressing Space
        {
            animator.SetBool("isJumping", true); // Makes the player jump
        }

        if (!Input.GetKey(KeyCode.Space)) // Activates on releasing Space
        {
            animator.SetBool("isJumping", false); // Stops the jumping animation
        }
    }
}
