using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;

namespace StacklandsAutoContinue;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    public static ConfigEntry<bool> AutoPauseConfig;

    private void Awake()
    {
        AutoPauseConfig = Config.Bind("General", "AutoPause", true, "Pause the game with automatically loading");

        Harmony harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);
        harmony.PatchAll();
    }
}
