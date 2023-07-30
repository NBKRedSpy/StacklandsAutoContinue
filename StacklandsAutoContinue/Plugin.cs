using HarmonyLib;

namespace StacklandsAutoContinue;

public class Plugin : Mod
{
    public static ConfigEntry<bool> AutoPauseConfig;
    public static ModLogger ModLogger;

    private void Awake()
    {
        ModLogger = Logger;
        AutoPauseConfig = Config.GetEntry<bool>("Auto Pause", true);

        Harmony.PatchAll();
    }
}
