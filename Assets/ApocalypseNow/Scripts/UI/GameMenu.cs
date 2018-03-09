using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/// <summary>
/// Backend für das Spielmenu
/// </summary>
public class GameMenu : MonoBehaviour {
    public GameManager Manager;

	public void UnpauseButtonPressed()
    {
        Manager.PauseGame(false);
    }

    public void RestartButtonPressed()
    {
        Manager.RestartGame();
    }

    public void MainMenuButtonPressed()
    {
        Manager.GotoMainMenu();
    }

    public void ExitButtonPressed()
    {
        Manager.ExitGame();
    }
}
