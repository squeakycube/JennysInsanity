using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JennysInsanity.Items
{
    //[AutoloadEquip(EquipType.AccessorySlot)]
    public class BloodiedRavenSkull : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Gives more minions...at a cost.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = ItemRarityID.Blue;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.minionDamage -= 0.2f;
            player.maxMinions += 1;
            player.statLifeMax2 /= 3;
        }

     //       player.minionDamage -= 0.2f;
   //         player.maxMinions += 1;
 //       }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "RavenSkull", 5);
            recipe.AddIngredient(ItemID.SoulofFlight, 15);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}