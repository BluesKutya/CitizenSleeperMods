using HarmonyLib;
using PixelCrushers.DialogueSystem.PlayMaker;

namespace FreeCoffee
{
	class FreeCoffee
	{

		[HarmonyPatch(typeof(GetVariable))]
		[HarmonyPatch(nameof(GetVariable.GetAndStore))]
		internal class PlayMaker_GetVariable__GetAndStore__Patch
		{
			[HarmonyPrefix]
			public static bool Prefix(GetVariable __instance)
			{
				if (__instance.variableName == null || string.IsNullOrEmpty(__instance.variableName.Value) || !"Player_Energy".Equals(__instance.variableName.Value)) {
					return true; //run the orignal code
				}

				__instance.storeFloatResult.Value = 100.0f;
				return false; //Tell Harmony to not run the original method
			}
		}

	}

}
