using System.Reflection;
using HarmonyLib;
using BepInEx;

namespace FreeCoffee
{

    [BepInPlugin("blueskutya.citizen-sleeper.plugin", "free-coffee", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            var harmony = new Harmony("blueskutya.citizensleeper.freecoffee.patch");

            var assembly = Assembly.GetExecutingAssembly();
            harmony.PatchAll(assembly);

            // Plugin startup logic
            Logger.LogInfo("Plugin free-coffee is loaded!");
        }

    }

}
