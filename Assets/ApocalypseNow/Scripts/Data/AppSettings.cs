using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.ApocalypseNow.Scripts.Data
{
    public class AppSettings
    {
        // Menu
        public static KeyCode GameMenuKey           = KeyCode.Escape;
        public static KeyCode PlayerCharacterKey    = KeyCode.C;
        public static KeyCode PlayerInventoryKey    = KeyCode.I;

        // Movement
        public static KeyCode PlayerMoveForwardKey  = KeyCode.W;
        public static KeyCode PlayerMoveLeftKey     = KeyCode.A;
        public static KeyCode PlayerMoveBackwardKey = KeyCode.S;
        public static KeyCode PlayerMoveRightKey    = KeyCode.D;
        public static KeyCode PlayerJumpKey         = KeyCode.Space;
        public static KeyCode PlayerDodgeKey        = KeyCode.LeftShift;

        //Combat
        public static KeyCode PlayerAttackKey   = KeyCode.Mouse0;
        public static KeyCode PlayerHotbar1Key  = KeyCode.Keypad1;
        public static KeyCode PlayerHotbar2Key  = KeyCode.Keypad2;
        public static KeyCode PlayerHotbar3Key  = KeyCode.Keypad3;
        public static KeyCode PlayerHotbar4Key  = KeyCode.Keypad4;
        public static KeyCode PlayerHotbar5Key  = KeyCode.Keypad5;
        public static KeyCode PlayerHotbar6Key  = KeyCode.Keypad6;
        public static KeyCode PlayerHotbar7Key  = KeyCode.Keypad7;
        public static KeyCode PlayerHotbar8Key  = KeyCode.Keypad8;

        public AppSettings()
        {
            Load();
        }

        public void Load()
        {

        }

        public void Save()
        {

        }
    }
}
