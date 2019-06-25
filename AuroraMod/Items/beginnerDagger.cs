using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items
{
	public class beginnerDagger : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Apprentice Dagger");
			Tooltip.SetDefault("A dagger meant for beginners.");
		}
		public override void SetDefaults()
		{
			item.damage = 10;
			item.melee = true;
            item.scale = 1.2f;
            item.width = 42;
			item.height = 42;
			item.useTime = 1;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(9, 5);
            recipe.AddIngredient(22, 1);
            recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
