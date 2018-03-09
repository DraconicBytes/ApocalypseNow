using UnityEngine;
using System.Collections;

public enum HealthLevels { Unwounded, Bruised, Hurt, Injured, Wounded, Mauled, Crippled, Incapacitated}

/// <summary>
/// Basisklasse für alle Entities, die sterben können
/// </summary>
public class EntityLiving : Entity {

    protected bool isConscious = true;
    protected float MovementSpeed = 0;
    protected float MoveMentSpeedMultiplier = 1;
    protected int WoundModifier = 0;

    // Character attributes
    // Physical
    protected int Strength = 1;
    protected int Dexterity = 1;
    protected int Stamina = 1;
    // Social
    protected int Charisma = 1;
    protected int Manipulation = 1;
    protected int Appearance = 1;
    // Mental
    protected int Perception = 1;
    protected int Intelligence = 1;
    protected int Wits = 1;

    // Character Abilities
    protected int Brawl = 1;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void SetHealthLevel(HealthLevels level)
    {
        switch (level)
        {
            case HealthLevels.Unwounded:
            case HealthLevels.Bruised:
                break;
            case HealthLevels.Hurt:
            case HealthLevels.Injured:
                WoundModifier = -1;
                break;
            case HealthLevels.Wounded:
            case HealthLevels.Mauled:
                WoundModifier = -2;
                break;
            case HealthLevels.Crippled:
                MoveMentSpeedMultiplier = 0.5f;
                WoundModifier = -5;
                break;
            case HealthLevels.Incapacitated:
                MoveMentSpeedMultiplier = 0;
                isConscious = false;
                break;
            default:
                break;
        }
    }
}
