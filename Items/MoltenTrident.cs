using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace JennysInsanity.Items
{
	public class MoltenTrident : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("MoltenTrident"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("It hurts to hold.");
		}

		public override void SetDefaults() 
		{
			item.damage = 320;
			item.melee = true;
			item.magic = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.Stabbing;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 139.5f;
			item.value = Item.buyPrice(gold: 100);
			item.mana = 6;

			//item.shoot = mod.ProjectileID.TridentBolt;
			item.shoot = mod.ProjectileType("TridentBolt");
		}

		//public override void OnHitNPC() 
		public  void OnHitNPC(ExamplePlayer player, NPC target, int buffIndex)
		{
			// Add the Onfire buff to the NPC for 1 second when the weapon hits an NPC
			// 60 frames = 1 second
			target.AddBuff(BuffID.OnFire, 6000);
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 45);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}