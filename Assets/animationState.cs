using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.TextCore.Text;


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
