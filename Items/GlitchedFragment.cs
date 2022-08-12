using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace JennysInsanity.Items
{
	public class GlitchedFragment : ModItem
	{
		public override void SetStaticDefaults() 
		{
			//This will drop from glitch boss and will be an endgame crafting item
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