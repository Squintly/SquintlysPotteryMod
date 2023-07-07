using SquintlysPotteryMod.Content.Items.BIG;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace SquintlysPotteryMod.Content.Tiles.BIG;

public class GiantPottersWheelTile : ModTile
{
    public const int NextStyleWidth = 72;
    public override void SetStaticDefaults()
    {
        TileID.Sets.DisableSmartCursor[base.Type] = true;
        Main.tileFrameImportant[base.Type] = true;
        Main.tileLavaDeath[base.Type] = true;
        
        TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
        TileObjectData.newTile.Height = 4;
        TileObjectData.newTile.Width = 4;
        TileObjectData.newTile.CoordinateHeights = new [] { 16, 16, 16, 18 };
        TileObjectData.newTile.Origin = new Point16(0, 1);
        TileObjectData.addTile(base.Type);
        
        AnimationFrameHeight = 72;
    }

    public override void AnimateTile(ref int frame, ref int frameCounter)
    {
        frameCounter++;
        if (frameCounter >= 9)
        {
            frameCounter = 0;
            if (++frame >= 5)
            {
                frame = 0;
            }
        }
    }
}
