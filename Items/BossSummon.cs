using JennysInsanity.NPCs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JennysInsanity.Items
{
	public class BossSummon : ModItem
	{
			public override void SetStaticDefaults() {
			Tooltip.SetDefault("The underworld would like this.");
			ItemID.Sets.SortingPriorityBossSpawns[item.type] = 13; // This helps sort inventory know this is a boss summoning item.
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 20;
			item.rare = ItemRarityID.Cyan;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = ItemUseStyleID.HoldingUp;
			item.UseSound = SoundID.Item44;
			item.consumable = true;
		}

		// We use the CanUseItem hook to prevent a player from using this item while the boss is present in the world.
		public override bool CanUseItem(Player player) {
			// "player.ZoneUnderworldHeight" could also be written as "player.position.Y / 16f > Main.maxTilesY - 200"
			return player.ZoneUnderworldHeight;
			//return player.ZoneUnderworldHeight && !NPC.AnyNPCs(ModContent.NPCType<NPCs.GreaterDemon>()) && !NPC.AnyNPCs(ModContent.NPCType<GreaterDemon>()) && !NPC.AnyNPCs(ModContent.NPCType<GreaterDemon>());
		}

		public override bool UseItem(Player player) {
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<NPCs.GreaterDemon>());
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<NPCs.GreaterDemon>());
			return true;
		}

		public override void AddRecipes() {
	ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ObsidianBrick, 50);
			recipe.AddIngredient(ItemID.GuideVoodooDoll, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}