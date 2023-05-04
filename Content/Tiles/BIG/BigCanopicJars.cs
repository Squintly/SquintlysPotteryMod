using SquintlysPotteryMod.Content.Items.BIG;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.Enums;
using SquintlysPotteryMod.Content.Items;

namespace SquintlysPotteryMod.Content.Tiles.BIG;

public class BigCanopicJars : ModTile
{
    public override void SetStaticDefaults()
    {
        TileID.Sets.DisableSmartCursor[base.Type] = true;
        Main.tileFrameImportant[base.Type] = true;

        TileObjectData.newTile.CopyFrom(TileObjectData.Style3x4);
        TileObjectData.newTile.Width = 2;
        TileObjectData.newTile.CoordinateHeights = new int[4] { 16, 16, 16, 18 };
        TileObjectData.newTile.StyleHorizontal = true;

        TileObjectData.newTile.RandomStyleRange = 3;
        TileObjectData.newTile.StyleWrapLimit = 3;
        TileObjectData.newTile.StyleMultiplier = 3;

        TileObjectData.addTile(base.Type);
    }
}
