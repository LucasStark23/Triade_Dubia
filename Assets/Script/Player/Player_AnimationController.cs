using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_AnimationController : MonoBehaviour
{
    private Player_Movement playerMovement; // Referência ao script de movimentação
    private Animator animator; // Referência ao componente Animator

    void Start()
    {
        // Obtém referências para o script de movimentação e para o componente Animator
        playerMovement = GetComponent<Player_Movement>();
        animator = GetComponent<Animator>();

        // Verifica se as referências foram obtidas com sucesso
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
        // Chama o método MovePlayer() e obtém as informações de movimento
        Player_Movement.MovementInfo movementInfo = playerMovement.MovePlayer();

        // Acesse as informações de movimento
        Vector3 movement = movementInfo.movement;
        bool isMoving = movementInfo.isMoving;

        if (!isMoving)
        {
            animator.SetFloat("Speed", 0f);
        }
        else if(isMoving)
        {
            animator.SetFloat("Speed", 0.5f);
        }
        if (isMoving && playerMovement.speed > 5.1)
        {
            animator.SetFloat("Speed", 1f);
            
        }
    }
}
