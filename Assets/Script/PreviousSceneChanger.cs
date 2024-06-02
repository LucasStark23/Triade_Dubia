using UnityEngine;
using UnityEngine.SceneManagement;

public class PreviousSceneChanger : MonoBehaviour
{
    // Este método será chamado quando um objeto com um Collider com a opção "Is Trigger" marcada entra em contato
    private void OnTriggerEnter(Collider other)
    {
        // Verifica se o objeto que entrou em contato é o jogador (pode ser identificado pela tag "Player")
        if (other.CompareTag("Player"))
        {
            // Carrega a cena anterior na ordem do Build Settings
            int previousSceneIndex = SceneManager.GetActiveScene().buildIndex - 1;
            if (previousSceneIndex >= 0)
            {
                SceneManager.LoadScene(previousSceneIndex);
            }
            else
            {
                Debug.LogWarning("Não há cenas anteriores a serem carregadas.");
            }
        }
    }
}
