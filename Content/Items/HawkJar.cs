using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace SquintlysPotteryMod.Content.Items
{
	public class HawkJar : ModItem
	{
		public override void SetStaticDefaults() {
			            
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.createTile = ModContent.TileType<Tiles.CanopicJars>();             
			Item.placeStyle = 2;

            Item.width = 15; 			
			Item.height = 32; 
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
				.AddIngredient(ItemID.ClayBlock, 8)
				.AddIngredient(ItemID.SandBlock)
				.AddTile<Tiles.PottersWheel>()
				.Register();
		}
	}
}
