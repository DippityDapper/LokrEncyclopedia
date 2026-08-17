# LokrEncyclopedia — Classes

## `LokrEncyclopediaPlugin` (`LokrEncyclopediaPlugin.cs`)

```csharp
[BepInPlugin(Guid, Name, Version)]
[BepInDependency(LokrModAPIPlugin.Guid)]
public class LokrEncyclopediaPlugin : BaseUnityPlugin
```

- `Guid = "com.lokrmodding.encyclopedia"`, `Name = "LoKR Encyclopedia"`, `Version = "1.0.0"`.
- Depends only on `LokrModAPIPlugin` (via `[BepInDependency]`) — no dependency on `LokrCharacterLoader`, by design (see `overview.md`).
- `internal static ManualLogSource Log` — exposes the plugin's logger to the rest of the (one-file) codebase.
- `Awake()`: standard boilerplate — grabs the logger, creates a `Harmony(Guid)` instance, calls `harmony.PatchAll()` (auto-discovers every `[HarmonyPatch]`-attributed class in the assembly), logs how many methods got patched.

This is the minimal BepInEx plugin shape used consistently across all four
plugins in this solution — see [`conventions.md`](conventions.md).

## `UIMainMenu_Start_Patch` (`Patches/UIMainMenuPatches.cs`)

```csharp
[HarmonyPatch(typeof(UIMainMenu), "Start")]
internal static class UIMainMenu_Start_Patch
{
    [HarmonyPostfix]
    private static void Postfix(UIMainMenu __instance)
}
```

- Postfix on `UIMainMenu.Start()`.
- Body: `__instance.encyclopediaButton.enabled = true;` and
  `__instance.encyclopediaButton.gameObject.SetActive(true);`.
- `encyclopediaButton` is a **pre-existing public field** on the base
  game's `UIMainMenu` — it ships disabled/inactive out of the box. This
  patch is the entire feature: flip two flags, nothing more. The button's
  serialized click shows vanilla **Coming Soon!**; there is no Encyclopedia
  window in C# to unlock.

See [`cross-references.md`](cross-references.md) for an important naming
note about this file.
