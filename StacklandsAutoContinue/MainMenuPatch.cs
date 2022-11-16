using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.InputSystem;

namespace StacklandsAutoContinue
{


    [HarmonyPatch(typeof(MainMenu), "Update")]
    public static class MainMenuPatch
    {
        public static bool ShiftKeyWasChecked = false;

        public static void Postfix()
        {
            if (!ShiftKeyWasChecked && !InputController.instance.GetKey(Key.LeftShift) && WorldManager.instance.CurrentSaveGame.LastPlayedRound != null)
            {
                WorldManager.instance.LoadPreviousRound();
                WorldManager.instance.Play();
            }

            ShiftKeyWasChecked = true;

        }

    }
}
