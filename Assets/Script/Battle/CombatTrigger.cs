using System.Linq;
using UnityEngine;

public class CombatTrigger : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject[] enemies; // Referência aos inimigos específicos para este combate
    public BattleManager battleManager; // Referência ao BattleManager específico

    void Start()
    {
        // Encontrar o GameManager na cena
        gameManager = FindObjectOfType<GameManager>();

        // Encontrar os inimigos como filhos do objeto atual que possuem o componente Enemy ou Collider
        enemies = GetComponentsInChildren<Collider>() // ou Enemy, dependendo do componente usado para identificar inimigos
                   .Select(c => c.gameObject)
                   .ToArray();

        // Encontrar o BattleManager como componente do objeto atual
        battleManager = GetComponent<BattleManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Verifica se o objeto que entrou no trigger é o jogador
        if (other.CompareTag("Player"))
        {
            // Inicia a batalha com os inimigos especificados
            gameManager.StartBattle(battleManager, enemies);
        }
    }
}
