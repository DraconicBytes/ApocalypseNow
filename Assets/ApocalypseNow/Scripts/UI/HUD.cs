using UnityEngine;
using System.Collections;

/// <summary>
/// Backend für das Spielinterface
/// </summary>
public class HUD : MonoBehaviour {

    public GameManager Manager;


    public void MenuButtonPressed()
    {
        Manager.PauseGame(true);
    }
}
