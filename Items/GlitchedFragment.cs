using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace JennysInsanity.Items
{
	public class GlitchedFragment : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("MoltenTrident"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("It feels tingley.");
		}

		public override void SetDefaults() 
		{
			item.ranged = true;
			item.width = 20;
			item.height = 20;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.value = Item.buyPrice(silver: 10);
		}
	}
}