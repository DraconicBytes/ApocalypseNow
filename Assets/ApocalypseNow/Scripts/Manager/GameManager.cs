using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Hält Referenzen für die Spielscene und steuert Grundlegende Funktionen
/// </summary>
public class GameManager : MonoBehaviour {
    #region Fields
    // IO
    public InputProcessor InputProcessor;

    // UI
    public HUD HUD;
    public GameMenu GameMenu;

    // Level
    public Level Level;

    // Player
    public EntityPlayer Player;

    // Game paused
    [SerializeField]
    public bool GamePaused { get; private set; }
    #endregion

    #region Unity Messages
    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start () {
	
	}

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update () {
	
	}
    #endregion

    #region Messages
    /// <summary>
    /// Pauses the game and displays the game menu
    /// </summary>
    /// <param name="paused"></param>
    public void PauseGame(bool paused)
    {
        GamePaused = paused;
        GameMenu.gameObject.SetActive(paused);
    }

    /// <summary>
    /// Restarts the game from the beginning
    /// </summary>
    public void RestartGame()
    {
        SceneManager.LoadScene("Level");
    }

    /// <summary>
    /// Quits the current session and displays the main menu
    /// </summary>
    public void GotoMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    /// <summary>
    /// Closes the application
    /// </summary>
    public void ExitGame()
    {
        Application.Quit();
    }
    #endregion
}
