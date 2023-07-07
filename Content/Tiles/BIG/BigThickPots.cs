using SquintlysPotteryMod.Content.Items.BIG;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace SquintlysPotteryMod.Content.Tiles.BIG;

public class BigThickPots : ModTile
{
    public const int NextStyleWidth = 72;
    public override void SetStaticDefaults()
    {
        TileID.Sets.DisableSmartCursor[base.Type] = true;
        Main.tileFrameImportant[base.Type] = true;

        TileObjectData.newTile.CopyFrom(TileObjectData.Style3x4);
        TileObjectData.newTile.Width = 4;
        TileObjectData.newTile.CoordinateHeights = new int[4] { 16, 16, 16, 18 };
        TileObjectData.newTile.CoordinatePaddingFix = new Point16(0,2);

        TileObjectData.newTile.StyleHorizontal = true;
        TileObjectData.newTile.StyleWrapLimit = 111;

        TileObjectData.addTile(base.Type);
    }
}
