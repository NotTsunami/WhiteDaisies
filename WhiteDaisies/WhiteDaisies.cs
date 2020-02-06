using BepInEx;
using RoR2;
using ItemCatalog = On.RoR2.ItemCatalog;

namespace Tsunami
{
    [BepInDependency("com.bepis.r2api")]
    [BepInPlugin("dev.tsunami.WhiteDaisies", "WhiteDaisies", "1.0.1")]
    public class WhiteDaisies : BaseUnityPlugin
    {
        public void Awake()
        {
            ItemCatalog.RegisterItem += (orig, index, def) =>
            {
                if (index == ItemIndex.TPHealingNova)
                {
                    def.tier = ItemTier.Tier1;
                }
                orig(index, def);
            };
        }
    }
}