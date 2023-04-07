using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace SquintlysPotteryMod.Content.Items.BIG
{
	public class BigAztecPot10 : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Massive Jungle Pot");
            
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.createTile = ModContent.TileType<Tiles.BIG.ThinPots>(); // This sets the id of the tile that this item should place when used.
            Item.placeStyle = 5;

            Item.width = 18; // The item texture's width
			Item.height = 32; // The item texture's height

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
				.AddIngredient(ItemID.ClayBlock, 8)
				.AddIngredient(ItemID.JungleGrassSeeds)
                .AddTile<Tiles.BIG.GiantPottersWheelTile>()
                .Register();
		}
	}
}
