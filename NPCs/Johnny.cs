using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JennysInsanity.NPCs
{
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class Johnny : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Johnny");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Guide];
		}

		public override void SetDefaults() {
			npc.width = 18;
			npc.height = 40;
			npc.damage = 240;
			npc.defense = 6;
			npc.lifeMax = 1000;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			aiType = NPCID.Zombie;
			animationType = NPCID.Guide;
			//banner = Item.NPCtoBanner(NPCID.Zombie);
			//bannerItem = Item.BannerToItem(banner);
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			return SpawnCondition.OverworldNightMonster.Chance * 0.005f;
			//return SpawnCondition.Overworld
		}

        public override void OnHitPlayer(Player player, int damage, bool crit)
        {
            {
                player.AddBuff(BuffID.Bleeding, 2400, true);
                NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("SkinWalker"));
                npc.life = 0;
            }
        }

        //  public override void NPCLoot()
        //   {
        //      {
        //NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Thomas"));
        //       }
        //    }

    }
}