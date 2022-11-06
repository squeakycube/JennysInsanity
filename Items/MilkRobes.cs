using Terraria.ModLoader;
using Terraria.ID;

namespace JennysInsanity.Items
{
	[AutoloadEquip(EquipType.Body)]
	internal class MilkRobes : ModItem
	{
		public void SetDefaults() {
			item.width = 18;
			item.height = 14;
			item.rare = ItemRarityID.Blue;
			item.vanity = true;
		}

		public void SetMatch(bool male, ref int equipSlot, ref bool robes) {
			robes = true;
			// The equipSlot is added in ExampleMod.cs --> Load hook
			equipSlot = mod.GetEquipSlot("MilkRobes_Legs", EquipType.Legs);
		}

		public void DrawHands(ref bool drawHands, ref bool drawArms) {
			drawHands = true;
		}
	}
}
