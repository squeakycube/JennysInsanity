using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JennysInsanity.NPCs
{
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class Crow : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Raven");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[4];
        }

		public override void SetDefaults() {
			npc.width = 38;
			npc.height = 38;
			npc.damage = 45;
			npc.defense = 6;
			npc.lifeMax = 2000;
			npc.HitSound = SoundID.NPCHit28;
			npc.DeathSound = SoundID.NPCDeath31;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 17;
			aiType = NPCID.Vulture;
			animationType = NPCID.Vulture;
			//banner = Item.NPCtoBanner(NPCID.Vulture);
			//bannerItem = Item.BannerToItem(Vulture);
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
            if (Main.hardMode)
            return SpawnCondition.Overworld.Chance * 0.075f;
            return SpawnCondition.OverworldNightMonster.Chance * 0.095f;
            return SpawnCondition.SolarEclipse.Chance * 0.3f;

        }

        public override void OnHitPlayer(Player player, int damage, bool crit)
        {
            if (Main.rand.NextBool(3))
            {
                player.AddBuff(BuffID.Bleeding, 2400, true);
            }
        }

        public override void NPCLoot()
        {
            if (Main.rand.NextBool(10))
            {
                Item.NewItem(npc.getRect(), mod.ItemType("RavenSkull"));
            }
        }

        /*public override void HitEffect(int hitDirection, double damage) {
			for (int i = 0; i < 10; i++) {
				int dustType = Main.rand.Next(139, 143);
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
			}
		}*/
    }
}