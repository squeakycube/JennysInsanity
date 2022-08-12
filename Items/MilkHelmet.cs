using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JennysInsanity.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class MilkHelmet : ModItem
	{
			public override void SetStaticDefaults() {
			Tooltip.SetDefault("This is a modded helmet.");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 7;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ModContent.ItemType<MilkRobes>();
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "trollface.jpg";
			player.allDamage -= 0.2f;
			/* Here are the individual weapon class bonuses.
			player.meleeDamage -= 0.2f;
			player.thrownDamage -= 0.2f;
			player.rangedDamage -= 0.2f;
			player.magicDamage -= 0.2f;
			player.minionDamage -= 0.2f;
			*/
			player.setBonus += player.minionDamage += 4.5f;
			player.minionDamage += 0.6f;
			player.maxMinions -= 1;
		}

		public override void AddRecipes() {
	ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ObsidianBrick, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}