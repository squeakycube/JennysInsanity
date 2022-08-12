using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JennysInsanity.Items
{
	public class MilkRing : ModItem
	{
		public override void SetDefaults() {
			item.width = 30;
			item.height = 32;
			item.accessory = true;
			item.value = Item.sellPrice(gold: 10);
			item.rare = ItemRarityID.Green;
		}

	//public class GreenExclusiveAccessory : ExclusiveAccessory
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Increases melee and ranged damage by 50%");
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			// 50% melee and ranged damage increase
			//player.minionDamage -= 0.1f;
			player.maxMinions += 3;
			}
		}
	}
