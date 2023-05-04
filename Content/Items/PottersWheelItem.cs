using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace SquintlysPotteryMod.Content.Items
{
	public class PottersWheelItem : ModItem
	{
		public override void SetStaticDefaults() {
			            
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.createTile = ModContent.TileType<Tiles.PottersWheel>(); 
			Item.width = 31; 			Item.height = 29; 
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
				.AddIngredient(ItemID.Wood, 10)
				.AddIngredient(ItemID.IronBar)
				.AddIngredient(ItemID.ClayBlock)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
