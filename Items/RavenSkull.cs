using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JennysInsanity.Items
{
    //[AutoloadEquip(EquipType.AccessorySlot)]
    public class RavenSkull : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Its pretty, isnt it? -Jennifer");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 100;
            item.maxStack = 9999;
            // item.rare = ItemRarityID.Blue;
        }
    }
}