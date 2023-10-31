using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [Header("Player Stats")]
    public Slider healthBar;
    public Text healthText;
    public Slider manaBar;
    public Text manaText;

    [Header("Game Stats")]
    public Text scoreText;
    public Text levelText;
    public Text timerText;

    [Header("Other UI Elements")]
    public Image spellIcon; 

    private Player player;

    private void Start()
    {
        player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        UpdatePlayerStats();
        UpdateGameStats();
    }

    private void UpdatePlayerStats()
    {
    }

    private void UpdateGameStats()
    {
    }

    private string FormatTime(float time)
    {
        int minutes = (int)(time / 60);
        int seconds = (int)(time % 60);
        return $"{minutes.ToString("00")}:{seconds.ToString("00")}";
    }

}
