using Terraria.ModLoader;

namespace JennysInsanity
{
	public class JennysInsanity : Mod
	{

				public override void Load() {

				// Add certain equip textures
				AddEquipTexture(null, EquipType.Legs, "MilkRobes_Legs", "JennysInsanity/Items/MilkRobes_Legs");
				//AddEquipTexture(new Items.Armor.BlockyHead(), null, EquipType.Head, "BlockyHead", "ExampleMod/Items/Armor/ExampleCostume_Head");
				//AddEquipTexture(new Items.Armor.BlockyBody(), null, EquipType.Body, "BlockyBody", "ExampleMod/Items/Armor/ExampleCostume_Body", "ExampleMod/Items/Armor/ExampleCostume_Arms");
				//AddEquipTexture(new Items.Armor.BlockyLegs(), null, EquipType.Legs, "BlockyLeg", "ExampleMod/Items/Armor/ExampleCostume_Legs");
		}

	}
}