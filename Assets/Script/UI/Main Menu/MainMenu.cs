using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [SerializeField]private GameObject OptionsMenuController;
    [SerializeField]private GameObject MainMenuController;
    public void ButtonPlay()
    {
        SceneManager.LoadScene("Map");
    }
    public void OpenOptions()
    {
        MainMenuController.SetActive(false);
        OptionsMenuController.SetActive(true);
    }
    public void CloseOptions()
    {
        MainMenuController.SetActive(true);
        OptionsMenuController.SetActive(false);
    }
    public void ButtonQuit()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
}
