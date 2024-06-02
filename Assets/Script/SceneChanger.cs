using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Este m�todo ser� chamado quando um objeto com um Collider com a op��o "Is Trigger" marcada entra em contato
    private void OnTriggerEnter(Collider other)
    {
        // Verifica se o objeto que entrou em contato � o jogador (pode ser identificado pela tag "Player")
        if (other.CompareTag("Player"))
        {
            // Carrega a pr�xima cena na ordem do Build Settings
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(nextSceneIndex);
            }
            else
            {
                Debug.LogWarning("N�o h� mais cenas a serem carregadas.");
            }
        }
    }
}
