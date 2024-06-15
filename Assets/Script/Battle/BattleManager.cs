using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public GameObject player;
    public GameObject[] enemies;

    // M�todo para iniciar a batalha
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
        // L�gica de inicializa��o da batalha
        Debug.Log("Batalha iniciada!");
        // Exemplo: posicionar inimigos, configurar UI, etc.
    }

    // M�todo para finalizar a batalha
    public void EndBattle()
    {
        // L�gica de finaliza��o da batalha
        Debug.Log("Batalha finalizada!");
        gameObject.SetActive(false);
    }
}
