using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JennysInsanity.NPCs
{
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class Skinwalker : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("SkinWalker");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void SetDefaults() {
			npc.width = 34;
			npc.height = 46;
			npc.damage = 140;
			npc.defense = 6;
			npc.lifeMax = 4000;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			aiType = NPCID.Zombie;
			animationType = NPCID.Zombie;
			//banner = Item.NPCtoBanner(NPCID.Zombie);
			//bannerItem = Item.BannerToItem(banner);
		}

        public void Update(NPC npc, ref int buffIndex)
        {
            npc.velocity = npc.velocity * (10.088f);
        }

        //  public override void NPCLoot()
        //   {
        //      {
        //NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Thomas"));
        //       }
        //    }

    }
}