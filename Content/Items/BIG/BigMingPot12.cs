using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace SquintlysPotteryMod.Content.Items.BIG
{
	public class BigMingPot12 : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Massive Porcelain Pot");
            
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.createTile = ModContent.TileType<Tiles.BIG.ThinPots>(); // This sets the id of the tile that this item should place when used.
            Item.placeStyle = 16;

            Item.width = 14; // The item texture's width
			Item.height = 31; // The item texture's height

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
				.AddIngredient(ItemID.Bone)
				.AddTile<Tiles.BIG.GiantPottersWheelTile>()
				.Register();
		}
	}
}
