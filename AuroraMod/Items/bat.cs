using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items
{
	public class bat : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Baseball Bat");
			Tooltip.SetDefault("Using a bat to kill zombies, cliché.");
		}
		public override void SetDefaults()
		{
			item.damage = 12;
			item.melee = true;
            item.scale = 1.25f;
            item.width = 32;
            item.height = 32;
            item.useTime = 18;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(9, 15);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
