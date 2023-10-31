using UnityEngine;

public class PauseMenuUI : MonoBehaviour
{
    [Header("Pause Menu Panels")]
    public GameObject pauseMenuPanel;
    public GameObject optionsPanel; 
    public GameObject confirmQuitPanel; 

    [Header("Buttons")]
    public GameObject resumeButton;
    public GameObject optionsButton; 
    public GameObject quitToMainMenuButton;
    public GameObject confirmQuitYesButton; 
    public GameObject confirmQuitNoButton;

    private bool isPaused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f; 
        pauseMenuPanel.SetActive(true);
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f; 
        pauseMenuPanel.SetActive(false);
    }

    public void ShowOptions()
    {
        pauseMenuPanel.SetActive(false);
        optionsPanel.SetActive(true);
    }

    public void HideOptions()
    {
        optionsPanel.SetActive(false);
        pauseMenuPanel.SetActive(true);
    }

    public void ShowConfirmQuit()
    {
        confirmQuitPanel.SetActive(true);
    }

    public void QuitToMainMenu()
    {
        Time.timeScale = 1f; 
    }

    public void CancelQuit()
    {
        confirmQuitPanel.SetActive(false);
    }

}
