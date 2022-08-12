using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JennysInsanity.Items
{
	public class MilkSpoiledToAnUnholyDegree : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("HE WILL COME, BE NOT AFRAID");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 26;
			item.useStyle = ItemUseStyleID.EatingUsing;
			item.useAnimation = 17;
			item.useTime = 17;
			item.useTurn = true;
			item.UseSound = SoundID.Item3;
			item.maxStack = 30;
			item.consumable = true;
			item.rare = ItemRarityID.Blue;
			item.value = Item.buyPrice(gold: 10000);
		}

		public override bool CanUseItem(Player player)
		{
			return !NPC.AnyNPCs(mod.NPCType("Thomas Lord of Milk"));
		}

		public override bool UseItem(Player player)
		{
			Main.PlaySound(SoundID.Roar, player.position);
			if (Main.netMode != 1)
			{
				NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Thomas"));
			}
			return true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			//recipe.AddIngredient(ItemID.TheMilkGodBlood, 10);
			recipe.AddIngredient(mod, "TheMilkGodBlood");
			//recipe.AddIngredient(ItemID.LuminiteBar, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
