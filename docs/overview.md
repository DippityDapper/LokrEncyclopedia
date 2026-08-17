# LokrEncyclopedia — Overview

The smallest plugin in the solution: unlocks the base game's pre-existing,
shipped-but-disabled Encyclopedia button on the main menu. No character
content, no `CharacterAPI` involvement — it exists as a standalone plugin
that depends only on `LokrModAPI` precisely because it's conceptually
unrelated to character creation and shouldn't force a dependency on
`LokrCharacterLoader`. This design demonstrates the separation of concerns
in the modular plugin architecture — see [`../../docs/modapi-plan.md`](../../docs/modapi-plan.md) §1 for the full rationale.

Clicking the unlocked button shows the vanilla **Coming Soon!** popup
(serialized on the button; this plugin does not add Encyclopedia UI).
Confirmed 2026-08-15 — see
[`../../docs/issues/resolved/encyclopedia-button-unverified-click.md`](../../docs/issues/resolved/encyclopedia-button-unverified-click.md).

## In this folder

- [`layout.md`](layout.md) — file structure
- [`classes.md`](classes.md) — the plugin entry point and its one patch
- [`conventions.md`](conventions.md) — how this plugin follows the shared plugin shape
- [`cross-references.md`](cross-references.md) — the naming collision with `LokrCharacterLab`'s own `UIMainMenuPatches.cs`

## Plugin metadata

`LokrEncyclopediaPlugin.cs`: `Guid = "com.lokrmodding.encyclopedia"`,
`Name = "LoKR Encyclopedia"`, `Version = "1.0.0"`,
`[BepInDependency(LokrModAPIPlugin.Guid)]` — depends only on `LokrModAPI`,
no dependency on `LokrCharacterLoader`, by design.
