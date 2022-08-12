using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace JennysInsanity.Items
{
	public class SatanistBook : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Wiresword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A book forgot to time, does one dare to cast its spells?");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults() 
		{
			//item.damage = 70;
			//item.melee = true;
			//item.width = 40;
			//item.height = 40;
			//item.useTime = 20;
			//item.useAnimation = 20;
			//item.useStyle = 1;
			//item.knockBack = 6;
			//item.value = 10000;
			//item.rare = 2;
			//item.UseSound = SoundID.Item1;
			//item.autoReuse = true;
			item.width = 40;
			item.height = 40;

			item.magic = true;
			item.mana = 100;
			item.damage = 1835;
			item.knockBack = 13.55f;
			item.crit = 30;
			item.noMelee = true;

			item.useTime = 440;
			item.useAnimation = 440;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.UseSound = SoundID.Item43;
			
			item.shoot = ProjectileID.DD2ExplosiveTrapT3Explosion;
			item.shootSpeed = 9.25f;

			item.value = Item.buyPrice(gold: 100);
			item.rare = ItemRarityID.Blue;
		}
	}
}