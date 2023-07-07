using SquintlysPotteryMod.Content.Items.BIG;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace SquintlysPotteryMod.Content.Tiles.BIG;

public class PokeyPot : ModTile
{
    public const int NextStyleWidth = 36;
    public override void SetStaticDefaults()
    {
        TileID.Sets.DisableSmartCursor[base.Type] = true;
        Main.tileFrameImportant[base.Type] = true;

        TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
        TileObjectData.newTile.StyleHorizontal = true;
        TileObjectData.newTile.StyleWrapLimit = 111;
        TileObjectData.newTile.Width = 2;
        TileObjectData.newTile.CoordinateHeights = new int[3] { 16, 16, 18 };
        TileObjectData.newTile.CoordinatePaddingFix = new Point16(0, 2);

        TileObjectData.addTile(base.Type);
    }
}
