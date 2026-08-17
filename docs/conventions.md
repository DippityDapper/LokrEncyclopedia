# LokrEncyclopedia — Conventions

- One Harmony patch, one plugin, doing exactly one thing — no internal
  abstraction layer, no `CharacterAPI`-style resolver pattern, because
  there's nothing here for other mods to extend or hook into.
- Standard plugin bootstrap (`[BepInPlugin]` + `[BepInDependency]` +
  `Harmony(Guid).PatchAll()` in `Awake`) matches every other plugin in
  this solution — see `../../LokrModAPI/docs/overview.md`,
  `../../LokrCharacterLoader/docs/overview.md`, and
  `../../LokrLab/docs/overview.md` for the same shape elsewhere.
