using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace SquintlysPotteryMod.Content.Items
{
	public class EgyptPot7 : ModItem
	{
		public override void SetStaticDefaults() {
			            
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.createTile = ModContent.TileType<Tiles.MediumEgyptPots>();             
			Item.placeStyle = 1;

            Item.width = 15; 			
			Item.height = 27; 
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
				.AddIngredient(ItemID.SandBlock)
				.AddTile<Tiles.PottersWheel>()
				.Register();
		}
	}
}
