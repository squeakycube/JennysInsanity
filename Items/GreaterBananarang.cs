using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace JennysInsanity.Items
{
	public class GreaterBananarang : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("MoltenTrident"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A great bannana weapon once wielded by Nor Mal the Monke Slayer.");
		}

		public override void SetDefaults() 
		{
			item.damage = 160;
			//item.melee = true;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 8;
			item.useAnimation = 16;
			item.useStyle = ItemUseStyleID.Stabbing;
			item.knockBack = 8;
			item.value = 10000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 18.5f;
			item.value = Item.buyPrice(gold: 100);
			//item.mana = 12;

			//item.shoot = mod.ProjectileID.TridentBolt;
			item.shoot = mod.ProjectileType("BanGreat");
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChlorophyteOre, 15);
			recipe.AddIngredient(ItemID.Bananarang, 30);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}