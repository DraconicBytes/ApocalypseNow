using UnityEngine;
using System.Collections;
using Assets.ApocalypseNow.Scripts.Data;

/// <summary>
/// Verarbeitet Eingaben von der Tastatur
/// </summary>
public class InputProcessor : MonoBehaviour {
    public GameManager Manager;


    // Use this for initialization
    void Start () {
	
	}
	
	/// <summary>
    /// Process inputs from the keyboard/mouse
    /// </summary>
	void Update () {
        // Blende Spielmenu ein
        if (Input.GetKeyDown(AppSettings.GameMenuKey))
            Manager.PauseGame(Manager.GamePaused);

        if (!Manager.GamePaused)
        {
            // Player controls
            Manager.Player.Move(
                (Input.GetKey(AppSettings.PlayerMoveForwardKey) ? Vector2.up : Vector2.zero) +
                (Input.GetKey(AppSettings.PlayerMoveBackwardKey) ? Vector2.down : Vector2.zero) +
                (Input.GetKey(AppSettings.PlayerMoveLeftKey) ? Vector2.left : Vector2.zero) +
                (Input.GetKey(AppSettings.PlayerMoveRightKey) ? Vector2.right : Vector2.zero));

        }
	}
}