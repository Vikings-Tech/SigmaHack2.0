using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChangeScript : MonoBehaviour
{
    public ScreenOrientation screenOrientation = ScreenOrientation.Portrait;

    private void Start()
    {
        Screen.orientation = screenOrientation;
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void GoToDIYMenu()
    {
        SceneManager.LoadScene("DIYMenuScene");
    }

    public void GoToNavMenu()
    {
        SceneManager.LoadScene("DIYNavMenu");
    }

    public void GoToDIYShelf()
    {
        SceneManager.LoadScene("DIYTutShelf");
    }

    public void GoToDIYAC()
    {
        SceneManager.LoadScene("DIYTutAC");
    }

    public void GoToLeaderBoard()
    {
        SceneManager.LoadScene("LeaderBoardScene");
    }

    public void GoToWebNav()
    {
        SceneManager.LoadScene("WebsiteTutScene");
    }
    
}
