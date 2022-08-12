using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using JennysInsanity.Items;
//using JennysInsanity.Items.Weapons;

namespace JennysInsanity.NPCs
{
    [AutoloadHead]
    // Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
    public class GreaterDemon : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Greater Demon");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[5];
		}

		public override void SetDefaults() {
			npc.width = 72;
			npc.height = 56;
			npc.damage = 90;
			npc.defense = 12;
			npc.lifeMax = 20000;
			//npc.lifeMax = 20;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.knockBackResist = 0.75f;
			npc.aiStyle = 14;
			aiType = NPCID.Demon;
			animationType = NPCID.Demon;
			banner = Item.NPCtoBanner(NPCID.Demon);
			bannerItem = Item.BannerToItem(banner);
			npc.boss = true;
			npc.lavaImmune = true;
			npc.noTileCollide = true;
		}

		public void CustomBehavior(ref float ai) {
			float distance = npc.Distance(Main.player[npc.target].Center);
			if (distance <= 250) {
				npc.alpha = 100;
				if (distance > 100) {
					// Make the NPC fade out the farther away the NPC is.
					npc.alpha += (int)(155 * ((distance - 100) / 150));
				}
				return;
			}
			npc.alpha = 255;
		}

        public override void AI()
        {
            if (npc.target < 0 || npc.target == 255)
            {
                npc.TargetClosest(false);
                npc.direction = 1;
                npc.velocity.Y = npc.velocity.Y - 0.1f;
                if(npc.timeLeft > 20)
                {
                    npc.timeLeft = 20;
                    return;
                }
            }
        }

public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			
		//	if(Main.hardMode == true)
		//	{
			//return SpawnCondition.ZoneUnderworldHeight.Chance * 0.75f;
			//return SpawnCondition.OceanMonster.Chance * 0.5f : 0f;
			if(Main.hardMode)
			return SpawnCondition.Underworld.Chance * 0.005f;
			return SpawnCondition.SolarEclipse.Chance * 0.001f; // Remember to test this value for balance
		}

				public override void NPCLoot() {
				//	npcLoot.Add(ItemDropRule.Common(ItemID.Shackle, 50));
				//Item.NewItem(npc.getRect(), ModContent.ItemType<MoltenTrident>());
				/////////////////////Item.NewItem(npc.getRect(), ModContent.ItemType<MoltenTrident>());
										int choice = Main.rand.Next(10);
			int item = 0;
			switch (choice) {
				case 0:
					item = ModContent.ItemType<MoltenTrident>();
					break;
				case 1:
					item = ModContent.ItemType<KOBat>();
					break;
				case 2:
					item = ModContent.ItemType<SatanistBook>();
					break;
			}
			if (item > 0) {
				Item.NewItem(npc.getRect(), item);
			}
			if (Main.expertMode) {
				npc.DropBossBags();
			}
			else {
				choice = Main.rand.Next(7);
				if (choice == 0) {
					Item.NewItem(npc.getRect(), ModContent.ItemType<MoltenTrident>());
				}
				else if (choice == 1) {
					Item.NewItem(npc.getRect(), ModContent.ItemType<KOBat>());
				}
				if (choice != 1) {
					Item.NewItem(npc.getRect(), ItemID.Bunny);
				}
				Item.NewItem(npc.getRect(), ModContent.ItemType<Items.SatanistBook>());
			}
		}
					
					public void Update(NPC npc, ref int buffIndex)
{
npc.velocity = npc.velocity*(3.88f);
}

public float Timer {
	get => npc.ai[0];
	set => npc.ai[0] = value;
}
}
}