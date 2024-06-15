using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GameState
    {
        Exploration,
        Battle
    }

    public GameState currentState;

    public GameObject playerCharacter; // Objeto do Mago Carmesim
    private Player_Movement playerMovement; // Refer�ncia ao script Player_Movement
    private Player_AnimationController playerAnimationController;
    

    public BattleManager currentBattleManager; // Refer�ncia ao BattleManager atual

    void Start()
    {
        currentState = GameState.Exploration;

        // Obt�m a refer�ncia ao script Player_Movement
        playerMovement = playerCharacter.GetComponent<Player_Movement>();
        playerAnimationController = playerCharacter.GetComponent <Player_AnimationController>();
        

        EnableExplorationMode();
    }

    void Update()
    {
        if (currentState == GameState.Exploration)
        {
            // L�gica para controle de movimento e intera��o no modo de explora��o
        }
        else if (currentState == GameState.Battle)
        {
            // L�gica para controle de batalha
        }
    }

    public void StartBattle(BattleManager battleManager, GameObject[] enemies)
    {
        currentBattleManager = battleManager;
        currentState = GameState.Battle;
        DisableExplorationMode();
        EnableBattleMode(enemies);
    }

    public void EndBattle()
    {
        currentState = GameState.Exploration;
        DisableBattleMode();
        EnableExplorationMode();
    }

    void EnableExplorationMode()
    {
        playerCharacter.SetActive(true); // Ativa o personagem do jogador
        playerMovement.enabled = true; // Ativa o script de movimento do jogador
        if (currentBattleManager != null)
        {
            currentBattleManager.gameObject.SetActive(false); // Desativa o sistema de batalha atual
        }
    }

    void DisableExplorationMode()
    {
        playerMovement.enabled = false; // Desativa o script de movimento do jogador
        // L�gica adicional para desativar outros elementos de explora��o, se houver
        playerAnimationController.animator.SetFloat("Speed", 0f);
        
        
    }

    void EnableBattleMode(GameObject[] enemies)
    {
        currentBattleManager.StartBattle(playerCharacter, enemies); // Inicia o sistema de batalha com os inimigos
    }

    void DisableBattleMode()
    {
        if (currentBattleManager != null)
        {
            currentBattleManager.EndBattle(); // Finaliza a batalha atual
        }
    }
}
