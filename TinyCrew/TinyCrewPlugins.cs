using System;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using UnityEngine.SceneManagement;

namespace TinyCrew;

[BepInAutoPlugin("tinycrew.plugin")]
[BepInProcess("Among Us.exe")]
public partial class TinyCrewPlugin : BasePlugin
{
    public Harmony Harmony { get; } = new("tinycrew.plugin");
    public static ConfigEntry<float> ConfigScale { get; private set; }
    public static float ScaleMod => ConfigScale.Value;

    public override void Load()
    {
        ConfigScale = Config.Bind("Scale", "GlobalModifier", 2f, "");
        Harmony.PatchAll();
        ConfigScale.SettingChanged += (_, _) =>
        {
            if (HudManager.InstanceExists) HudStartPatch.UpdateSize();
            foreach (var player in PlayerControl.AllPlayerControls) player.UpdateSize();
        };
        SceneManager.add_sceneLoaded((Action<Scene, LoadSceneMode>)((scene, _) =>
        {
            if (scene.name == "MainMenu") ModManager.Instance.ShowModStamp();
        }));
    }
}
