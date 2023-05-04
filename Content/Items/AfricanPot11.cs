using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace SquintlysPotteryMod.Content.Items
{
	public class AfricanPot11 : ModItem
	{
		public override void SetStaticDefaults() {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.createTile = ModContent.TileType<Tiles.MediumAfricanPots>();
			Item.placeStyle = 5;

            Item.width = 18;
			Item.height = 28;

			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTime = 10;
			Item.useAnimation = 15;

			Item.maxStack = 99;
			Item.consumable = true;
		}
		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.ClayBlock, 4)
				.AddIngredient(ItemID.GrassSeeds)
				.AddTile<Tiles.PottersWheel>()
				.Register();
		}
	}
}
