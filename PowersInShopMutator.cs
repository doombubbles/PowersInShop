using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Towers;
using Newtonsoft.Json.Linq;

namespace PowersInShop;

/// <summary>
/// Mutator to mark a power as being a power from shop
/// </summary>
public class PowersInShopMutator : ModMutator
{
    /// <summary>
    /// Using OnTowerSaved and OnTowerLoaded instead for backwards compatibility
    /// </summary>
    public override bool Saved => false;

    public override int Priority => 10;

    public override bool Mutate(Model baseModel, Model model, JToken data)
    {
        if (!model.Is(out TowerModel towerModel) ||
            !PowersInShopMod.PowersByName.TryGetValue(towerModel.baseId, out var powerTower) ||
            powerTower is not ModPowerTowerBase modPowerTowerBase) return true;

        modPowerTowerBase.MutateTower(towerModel);

        return true;
    }
}