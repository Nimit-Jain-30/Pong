using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WinnerSceneController : MonoBehaviour
{
    public TextMeshProUGUI winnerNameText;

    void Start()
    {
        if (winnerNameText != null)
        {
            // Retrieve the winner's name from the previous scene
            winnerNameText.text = PlayerPrefs.GetString("WinnerName", "No Winner");
        }
        else
        {
            Debug.LogError("WinnerNameText is not assigned in the Inspector!");
        }
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Game");  // Load the main game scene
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");  // Load the main menu scene
    }
}
