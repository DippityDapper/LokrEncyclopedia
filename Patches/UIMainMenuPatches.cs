using HarmonyLib;

namespace LokrEncyclopedia.Patches
{
	/// <summary>Enables the base game's pre-existing, disabled-by-default Encyclopedia button.</summary>
	/// <remarks>
	/// Split into its own plugin per docs/modapi-plan.md §1 — unrelated to character creation,
	/// no reason to depend on LokrCharacterLoader. Logic unchanged from the original migration.
	///
	/// `encyclopediaButton` is a pre-existing public field on UIMainMenu (it ships
	/// disabled/inactive in the base game) — see lokr-modding/docs/gameplay-changes.md §1.
	/// </remarks>
	[HarmonyPatch(typeof(UIMainMenu), "Start")]
	internal static class UIMainMenu_Start_Patch
	{
		/// <summary>Enables and activates the Encyclopedia button after the main menu is set up.</summary>
		[HarmonyPostfix]
		private static void Postfix(UIMainMenu __instance)
		{
			__instance.encyclopediaButton.enabled = true;
			__instance.encyclopediaButton.gameObject.SetActive(true);
		}
	}
}
