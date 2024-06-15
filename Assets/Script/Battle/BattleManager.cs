using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public GameObject player;
    public GameObject[] enemies;

    // Método para iniciar a batalha
    public void StartBattle(GameObject player, GameObject[] enemies)
    {
        this.player = player;
        this.enemies = enemies;

        // Ative o sistema de batalha
        gameObject.SetActive(true);

        // Inicialize os elementos da batalha
        InitializeBattle();
    }

    private void InitializeBattle()
    {
        // Lógica de inicialização da batalha
        Debug.Log("Batalha iniciada!");
        // Exemplo: posicionar inimigos, configurar UI, etc.
    }

    // Método para finalizar a batalha
    public void EndBattle()
    {
        // Lógica de finalização da batalha
        Debug.Log("Batalha finalizada!");
        gameObject.SetActive(false);
    }
}
