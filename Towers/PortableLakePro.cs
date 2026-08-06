using Il2CppAssets.Scripts.Models.Towers;

namespace PowersInShop.Towers;

public class PortableLakePro : ModPowerTowerPro
{
    public override string BaseTower => TowerType.PortableLakePro;
    protected override int Order => 19;
    public override int BaseCost => 1000;
}