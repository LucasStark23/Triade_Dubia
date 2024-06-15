using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Este método será chamado quando um objeto com um Collider com a opção "Is Trigger" marcada entra em contato
    private void OnTriggerEnter(Collider other)
    {
        // Verifica se o objeto que entrou em contato é o jogador (pode ser identificado pela tag "Player")
        if (other.CompareTag("Player"))
        {
            // Carrega a próxima cena na ordem do Build Settings
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(nextSceneIndex);
            }
            else
            {
                Debug.LogWarning("Não há mais cenas a serem carregadas.");
            }
        }
    }
}
