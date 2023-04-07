using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace SquintlysPotteryMod.Content.Items.BIG
{
	public class BigNativePot14 : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Massive Forest Pot");
            
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.createTile = ModContent.TileType<Tiles.BIG.SmallPots>(); // This sets the id of the tile that this item should place when used.
            Item.placeStyle = 1;

            Item.width = 16; // The item texture's width
			Item.height = 16; // The item texture's height

			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTime = 10;
			Item.useAnimation = 15;

			Item.maxStack = 99;
			Item.consumable = true;
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.ClayBlock, 4)
				.AddIngredient(ItemID.Wood)
				.AddTile<Tiles.BIG.GiantPottersWheelTile>()
				.Register();
		}
	}
}
