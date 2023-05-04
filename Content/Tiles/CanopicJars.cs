using SquintlysPotteryMod.Content.Items;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.Enums;

namespace SquintlysPotteryMod.Content.Tiles;

public class CanopicJars : ModTile
{
    public override void SetStaticDefaults()
    {
        TileID.Sets.DisableSmartCursor[base.Type] = true;
        Main.tileFrameImportant[base.Type] = true;

        TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2);
        TileObjectData.newTile.CoordinateHeights = new int[2] { 16, 18 };
        TileObjectData.newTile.StyleHorizontal = true;

        TileObjectData.newTile.RandomStyleRange = 3;
        TileObjectData.newTile.StyleWrapLimit = 3;
        TileObjectData.newTile.StyleMultiplier = 3;
        TileObjectData.addTile(base.Type);
    }
}
