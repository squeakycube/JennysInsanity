using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JennysInsanity.Items
{
    public class TheMilkGodBlood : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The blessed milk god has blessed us with this liquid"
                + "\nHeals both the spirit and body");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 26;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useAnimation = 17;
            item.useTime = 17;
            item.useTurn = true;
            item.UseSound = SoundID.Item3;
            item.maxStack = 30;
            item.consumable = true;
            item.rare = ItemRarityID.Orange;
            item.healLife = 400; // While we change the actual healing value in GetHealLife, item.healLife still needs to be higher than 0 for the item to be considered a healing item
            item.potion = true; // Makes it so this item applies potion sickness on use and allows it to be used with quick heal
            item.value = Item.buyPrice(gold: 1000);
        }

        public override void GetHealLife(Player player, bool quickHeal, ref int healValue)
        {
            // Make the item heal half the player's max health normally, or one fourth if used with quick heal
            healValue = player.statLifeMax2 / (quickHeal ? 4 : 2);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GreaterHealingPotion, 15);
            recipe.AddIngredient(ItemID.Bone, 50);
            recipe.AddIngredient(ItemID.SoulofMight, 15);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(ItemID.SoulofFright, 15);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}