using System.Linq;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using LokrModAPI;

namespace LokrEncyclopedia
{
	/// <summary>Plugin entry point that unlocks the base game's disabled Encyclopedia button.</summary>
	[BepInPlugin(Guid, Name, Version)]
	[BepInDependency(LokrModAPIPlugin.Guid)]
	public class LokrEncyclopediaPlugin : BaseUnityPlugin
	{
		/// <summary>This plugin's BepInEx GUID.</summary>
		public const string Guid = "com.lokrmodding.encyclopedia";
		/// <summary>This plugin's display name.</summary>
		public const string Name = "LoKR Encyclopedia";
		/// <summary>This plugin's version string.</summary>
		public const string Version = "1.0.0";

		/// <summary>This plugin's shared BepInEx log source, set once in Awake().</summary>
		internal static ManualLogSource Log;

		private Harmony harmony;

		private void Awake()
		{
			Log = Logger;

			harmony = new Harmony(Guid);
			harmony.PatchAll();

			Log.LogInfo(string.Format(
				"{0} v{1} loaded — {2} method(s) patched.",
				Name, Version, harmony.GetPatchedMethods().Count()));
		}
	}
}
