using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_AnimationController : MonoBehaviour
{
    private Player_Movement playerMovement; 
    public Animator animator; 

    void Start()
    {
        
        playerMovement = GetComponent<Player_Movement>();
        animator = GetComponent<Animator>();

        
        if (playerMovement == null)
        {
            Debug.LogError("Player_Movement script not found!");
        }
        if (animator == null)
        {
            Debug.LogError("Animator component not found!");
        }

        
    }

    void Update()
    {
        MovemantAnimation();
    }

    private void MovemantAnimation()
    {
        // Chama o método MovePlayer() e obtém as informações de movimento
        Player_Movement.MovementInfo movementInfo = playerMovement.MovePlayer();

        // Acesse as informações de movimento
        Vector3 movement = movementInfo.movement;
        bool isMoving = movementInfo.isMoving;

        if (!isMoving)
        {
            animator.SetFloat("Speed", 0f);
        }
        else if (isMoving)
        {
            animator.SetFloat("Speed", 0.5f);
        }
        if (isMoving && playerMovement.speed > 2.1)
        {
            animator.SetFloat("Speed", 1f);

        }
    }
}
