using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        if (Application.CanStreamedLevelBeLoaded("Game"))
        {
            SceneManager.LoadScene("Game");
        }
        else
        {
            Debug.LogError("Game scene not found.");
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
