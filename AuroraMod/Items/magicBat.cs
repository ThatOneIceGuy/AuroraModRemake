using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items
{
	public class magicBat : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Enchanted Baseball Bat");
			Tooltip.SetDefault("Oh, That's a Baseball!");
		}
		public override void SetDefaults()
		{
			item.damage = 15;
			item.melee = true;
            item.scale = 1.25f;
            item.width = 42;
			item.height = 42;
			item.useTime = 14;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 12;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "bat");
            recipe.AddIngredient(109, 1);
            recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
        
    }
}
