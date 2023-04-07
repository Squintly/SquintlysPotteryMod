using SquintlysPotteryMod.Content.Items.BIG;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace SquintlysPotteryMod.Content.Tiles.BIG;

public class BigThickPots : ModTile
{
    public override void SetStaticDefaults()
    {
        TileID.Sets.DisableSmartCursor[base.Type] = true;
        Main.tileFrameImportant[base.Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style3x4);
        TileObjectData.newTile.Width = 4;
        TileObjectData.newTile.CoordinateHeights = new int[4] { 16, 16, 16, 18 };
        TileObjectData.newTile.CoordinatePaddingFix = new Point16(0,2);
        TileObjectData.newTile.StyleHorizontal = true;
        TileObjectData.addTile(base.Type);
        ModTranslation name = base.CreateMapEntryName();
        name.SetDefault("Giant Pot");
        base.AddMapEntry(new Color(139, 0, 0), name);
    }
    public override void KillMultiTile(int x, int y, int frameX, int frameY)
    {

        int item = 0;
        int frame = frameX / 72;

        if (frame == 0)
            item = ModContent.ItemType<BigEgyptPot4>();//
        else if (frame == 1)
            item = ModContent.ItemType<BigEgyptPot5>();//
        else if (frame == 2)
            item = ModContent.ItemType<BigAztecPot1>();//
        else if (frame == 3)
            item = ModContent.ItemType<BigAztecPot2>();//
        else if (frame == 4)
            item = ModContent.ItemType<BigAztecPot4>();//
        else if (frame == 5)
            item = ModContent.ItemType<BigAztecPot5>();//
        else if (frame == 6)
            item = ModContent.ItemType<BigAfricanPot2>();//
        else if (frame == 7)
            item = ModContent.ItemType<BigGreekPot3>();//
        else if (frame == 8)
            item = ModContent.ItemType<BigGreekPot4>();//
        else if (frame == 9)
            item = ModContent.ItemType<BigNativePot4>();//
        else if (frame == 10)
            item = ModContent.ItemType<BigNativePot5>();//
        else if (frame == 11)
            item = ModContent.ItemType<BigNativePot7>();//

        if (item > 0)
            Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 32, 48, item);
    }
}
