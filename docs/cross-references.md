# LokrEncyclopedia — Cross-references

**Naming collision, not a bug:** despite the file/class being named
`UIMainMenuPatches`, the patch target in this plugin is genuinely
`UIMainMenu` (the deeper post-save-slot hub screen). Do not confuse this
with `LokrCharacterLab`'s own `Patches/UIMainMenuPatches.cs`, which —
despite an identical file name — actually patches the *different* class
`UIMainScreen` (the title screen shown right after boot, not the hub
screen). See `../../LokrLab/docs/architecture.md` for that
distinction and why the two files ended up with the same name despite
targeting different classes.
