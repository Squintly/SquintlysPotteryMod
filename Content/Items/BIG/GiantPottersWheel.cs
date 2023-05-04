using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace SquintlysPotteryMod.Content.Items.BIG
{
	public class GiantPottersWheelItem : ModItem
	{
		public override void SetStaticDefaults() {
			            
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.createTile = ModContent.TileType<Tiles.BIG.GiantPottersWheelTile>(); 
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
				.AddIngredient(ItemID.Wood, 20)
				.AddIngredient(ItemID.IronBar,2)
				.AddIngredient(ItemID.ClayBlock,2)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
