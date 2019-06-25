using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items
{
	public class trafficSign : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Traffic Sign");
			Tooltip.SetDefault("Stop! Wait a minute.");
		}
		public override void SetDefaults()
		{
			item.damage = 30;
			item.melee = true;
			item.width = 42;
            item.scale = 1.6f;
            item.height = 42;
			item.useTime = 14;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 40;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(22, 10);
            recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
        
    }
}
