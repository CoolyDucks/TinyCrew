using System.Numerics;
using HarmonyLib;

namespace TinyCrew.Patches;

[HarmonyPatch(typeof(CosmeticsLayer), nameof(CosmeticsLayer.SetScale))]
public static class CosmeticsLayerPatch
{
    public static void Prefix(ref Vector3 playerScale, ref Vector3 cosmeticsScale)
    {
        playerScale /= TinyCrewPlugin.ScaleMod;
        cosmeticsScale /= TinyCrewPlugin.ScaleMod;
    }
}
