using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace SquintlysPotteryMod.Content.Items
{
	public class PottersWheelItem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Pottery Wheel");
            base.Tooltip.SetDefault("Used for special crafting");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.createTile = ModContent.TileType<Tiles.PottersWheel>(); // This sets the id of the tile that this item should place when used.

			Item.width = 31; // The item texture's width
			Item.height = 29; // The item texture's height

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
				.AddIngredient(ItemID.Wood, 10)
				.AddIngredient(ItemID.IronBar)
				.AddIngredient(ItemID.ClayBlock)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
