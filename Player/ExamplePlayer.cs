using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JennysInsanity
{
	public class ExamplePlayer : ModPlayer
	{
		public bool examplePet;
		public bool exampleLightPet;
		
		public bool tmmcPet;


		public override void ResetEffects()
		{
			tmmcPet = false;
		}
	}
}