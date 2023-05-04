using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace SquintlysPotteryMod.Content.Items
{
	public class MingPot12 : ModItem
	{
		public override void SetStaticDefaults() {
			            
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.createTile = ModContent.TileType<Tiles.MediumMingPots>();          
			Item.placeStyle = 6;

            Item.width = 14; 		
			Item.height = 31; 
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
				.AddIngredient(ItemID.ClayBlock, 2)
				.AddIngredient(ItemID.Bone)
				.AddTile<Tiles.PottersWheel>()
				.Register();
		}
	}
}
