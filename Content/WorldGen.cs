//using Microsoft.Xna.Framework;
//using Microsoft.Xna.Framework.Graphics;
//using SquintlysPotteryMod.Content.Items.BIG;
//using System.Collections.Generic;
//using System.IO;
//using Terraria;
//using Terraria.DataStructures;
//using Terraria.GameContent.Generation;
//using Terraria.ID;
//using Terraria.Localization;
//using Terraria.ModLoader;
//using Terraria.ModLoader.IO;
//using Terraria.WorldBuilding;

//namespace SquintlysPotteryMod.Content
//{
//    public class WorldGen : ModSystem
//    {
//        public override void PostWorldGen()
//        {
//            int[] itemsToPlaceInChests = { ModContent.ItemType<GiantPottersWheelItem>() };
//            int itemsToPlaceInChestsChoice = 0;
//            if (Main.rand.NextBool(10)) {
//                for (int chestIndex = 0; chestIndex < 1000; chestIndex++)
//                {
//                    Chest chest = Main.chest[chestIndex];
//                    if (chest != null && Main.tile[chest.x, chest.y].TileType == TileID.Containers && Main.tile[chest.x, chest.y].TileFrameX == 1 * 36)
//                    {
//                        for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++)
//                        {
//                            if (chest.item[inventoryIndex].type == ItemID.None)
//                            {
//                                chest.item[inventoryIndex].SetDefaults(Main.rand.Next(itemsToPlaceInChests));
//                                //chest.item[inventoryIndex].SetDefaults(itemsToPlaceInChests[itemsToPlaceInChestsChoice]);
//                                //itemsToPlaceInChestsChoice = (itemsToPlaceInChestsChoice + 1) % itemsToPlaceInChests.Length;
//                                break;
//                            }
//                        }
//                    }
//                }
//            }
//        }
//    }
//}
