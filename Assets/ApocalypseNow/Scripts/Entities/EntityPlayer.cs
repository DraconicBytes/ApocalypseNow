using UnityEngine;
using System.Collections;

/// <summary>
/// Skript für den Spielercharakter
/// </summary>
public class EntityPlayer : EntityLiving {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Move(Vector2 direction)
    {
        // Calc movement
        direction = direction.normalized * MovementSpeed;
    }
}
