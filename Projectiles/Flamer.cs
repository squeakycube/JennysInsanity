using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace JennysInsanity.Projectiles
{
	public class Flamer : ModProjectile
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Flamer"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() 
		{
			projectile.aiStyle = 1;
			//projectile.friendly = true;
			projectile.penetrate = 3;
			projectile.damage = 220;
			projectile.ranged = true;
			projectile.width = 52;
			projectile.height = 50;
			projectile.knockBack = 6;
			projectile.tileCollide = false;
						projectile.extraUpdates = 1;            //Set to above 0 if you want the projectile to update multiple time in a frame
									projectile.friendly = true;         //Can the projectile deal damage to enemies?
			projectile.hostile = false;         //Can the projectile deal damage to the player?
		}

		public void OnHitNPC(ExamplePlayer player, NPC target, int buffIndex)
				{
			// Add the Onfire buff to the NPC for 1 second when the weapon hits an NPC
			// 60 frames = 1 second
			target.AddBuff(BuffID.OnFire, 1200);
		}

		public override void AI()
		{
			Lighting.AddLight(projectile.Center, 2.55f, 0.92f, 0.07f);
			
			//projectile.rotation -= 1.57f;
			//projectile.velocity.Y -= 0.785f;

		}
	}
}