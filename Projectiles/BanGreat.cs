using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace JennysInsanity.Projectiles
{
	public class BanGreat : ModProjectile
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("GreaterBananarang"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() 
		{
			projectile.aiStyle = 3;
				projectile.CloneDefaults(ProjectileID.Bananarang);
	// projectile.aiStyle = 3; This line is not needed since CloneDefaults sets it.
	aiType = ProjectileID.Bananarang;
			//projectile.friendly = true;
			projectile.penetrate = 3;
			projectile.damage = 220;
			projectile.ranged = true;
			projectile.width = 52;
			projectile.height = 50;
			projectile.knockBack = 9;
			projectile.tileCollide = false;
						projectile.extraUpdates = 1;            //Set to above 0 if you want the projectile to update multiple time in a frame
									projectile.friendly = true;         //Can the projectile deal damage to enemies?
			projectile.hostile = false;         //Can the projectile deal damage to the player?
		}
	}
}