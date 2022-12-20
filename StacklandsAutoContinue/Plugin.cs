using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;

namespace StacklandsAutoContinue;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    public static ConfigEntry<bool> AutoPauseConfig;
    public static ManualLogSource Log;

    private void Awake()
    {
        AutoPauseConfig = Config.Bind("General", "AutoPause", true, "Pause the game with automatically loading");

        Log = Logger;
        Harmony harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);
        harmony.PatchAll();
    }
}
