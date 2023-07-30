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
            if (!ShiftKeyWasChecked && !InputController.instance.GetKey(Key.LeftShift) && WorldManager.instance?.CurrentSave?.LastPlayedRound is not null)
            {

				if (Plugin.AutoPauseConfig.Value == true)
				{
					GameScreen.instance?.TimePause();
				}

				var submitClickInfo = AccessTools.Method(typeof(CustomButton), "SubmitClick");
                submitClickInfo.Invoke(___ContinueButton, null);
            }

            ShiftKeyWasChecked = true;

        }
	}
}
