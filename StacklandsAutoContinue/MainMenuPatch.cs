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
        public static bool ShiftKeyWasChecked;

        public static void Postfix(CustomButton ___ContinueButton)
        {
            if (!ShiftKeyWasChecked && !InputController.instance.GetKey(Key.LeftShift) && WorldManager.instance?.CurrentSaveGame?.LastPlayedRound != null)
            {
                WorldManager.instance.LoadPreviousRound();
                WorldManager.instance.Play();

                if (Plugin.AutoPauseConfig.Value == true)
                {
                    GameScreen.instance?.TimePause();
                }

            }

            ShiftKeyWasChecked = true;

        }

    }
}
