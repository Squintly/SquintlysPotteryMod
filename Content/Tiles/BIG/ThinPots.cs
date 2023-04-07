using SquintlysPotteryMod.Content.Items.BIG;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace SquintlysPotteryMod.Content.Tiles.BIG;

public class ThinPots : ModTile
{
    public override void SetStaticDefaults()
    {
        TileID.Sets.DisableSmartCursor[base.Type] = true;
        Main.tileFrameImportant[base.Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style3x4);
        TileObjectData.newTile.StyleHorizontal = true;
        TileObjectData.newTile.Width = 2;
        TileObjectData.newTile.CoordinateHeights = new int[4] { 16, 16, 16, 18 };
        TileObjectData.newTile.CoordinatePaddingFix = new Point16(0, 2);
        TileObjectData.addTile(base.Type);
        ModTranslation name = base.CreateMapEntryName();
        name.SetDefault("Giant Pot");
        base.AddMapEntry(new Color(139, 0, 0), name);
    }
    public override void KillMultiTile(int x, int y, int frameX, int frameY)
    {

        int item = 0;
        int frame = frameX / 36;

        if (frame == 0)
            item = ModContent.ItemType<BigAfricanPot7>();
        else if (frame == 1)
            item = ModContent.ItemType<BigAfricanPot8>();
        else if (frame == 2)
            item = ModContent.ItemType<BigAfricanPot9>();
        else if (frame == 3)
            item = ModContent.ItemType<BigAfricanPot12>();
        else if (frame == 4)
            item = ModContent.ItemType<BigAztecPot9>();
        else if (frame == 5)
            item = ModContent.ItemType<BigAztecPot10>();
        else if (frame == 6)
            item = ModContent.ItemType<BigAztecPot11>();
        else if (frame == 7)
            item = ModContent.ItemType<BigAztecPot12>();
        else if (frame == 8)
            item = ModContent.ItemType<BigEgyptPot7>();
        else if (frame == 9)
            item = ModContent.ItemType<BigEgyptPot9>();
        else if (frame == 10)
            item = ModContent.ItemType<BigGreekPot11>();
        else if (frame == 11)
            item = ModContent.ItemType<BigGreekPot12>();
        else if (frame == 12)
            item = ModContent.ItemType<BigMingPot7>();
        else if (frame == 13)
            item = ModContent.ItemType<BigMingPot8>();
        else if (frame == 14)
            item = ModContent.ItemType<BigMingPot9>();
        else if (frame == 15)
            item = ModContent.ItemType<BigMingPot11>();
        else if (frame == 16)
            item = ModContent.ItemType<BigMingPot12>();
        else if (frame == 17)
            item = ModContent.ItemType<BigNativePot9>();

        if (item > 0)
            Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 32, 48, item);
    }
}
