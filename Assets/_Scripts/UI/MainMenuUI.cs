using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI; 

public class MainMenuUI : MonoBehaviour
{
    [Header("Main Menu Panels")]
    public GameObject mainMenuPanel;
    public GameObject optionsPanel;
    public GameObject creditsPanel;

    [Header("Buttons")]
    public Button startGameButton;
    public Button optionsButton;
    public Button creditsButton;
    public Button quitButton;
    public Button backButtonOptions; 
    public Button backButtonCredits; 

    private void Start()
    {
    
    }

    private void StartGame()
    {
        SceneManager.LoadScene("GameScene"); 
    }

    private void ShowOptions()
    {
        mainMenuPanel.SetActive(false);
        optionsPanel.SetActive(true);
    }

    private void ShowCredits()
    {
        mainMenuPanel.SetActive(false);
        creditsPanel.SetActive(true);
    }

    private void QuitGame()
    {
        Application.Quit();
    }

    private void ShowMainMenuFromOptions()
    {
        optionsPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }

    private void ShowMainMenuFromCredits()
    {
        creditsPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }

}
