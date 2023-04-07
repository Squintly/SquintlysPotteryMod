using SquintlysPotteryMod.Content.Items.BIG;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace SquintlysPotteryMod.Content.Tiles.BIG;

public class BigThinPots : ModTile
{
    public override void SetStaticDefaults()
    {
        TileID.Sets.DisableSmartCursor[base.Type] = true;
        Main.tileFrameImportant[base.Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style3x4);
        TileObjectData.newTile.CoordinateHeights = new int[4] { 16, 16, 16, 18 };
        TileObjectData.newTile.StyleHorizontal = true;
        TileObjectData.addTile(base.Type);
        ModTranslation name = base.CreateMapEntryName();
        name.SetDefault("Giant Pot");
        base.AddMapEntry(new Color(139, 0, 0), name);
    }
    public override void KillMultiTile(int x, int y, int frameX, int frameY)
    {

        int item = 0;
        int frame = frameX / 54;

        if (frame == 0)
            item = ModContent.ItemType<BigEgyptPot1>();//
        else if (frame == 1)
            item = ModContent.ItemType<BigEgyptPot2>();//
        else if (frame == 2)
            item = ModContent.ItemType<BigEgyptPot3>();//
        else if (frame == 3)
            item = ModContent.ItemType<BigMingPot1>();//
        else if (frame == 4)
            item = ModContent.ItemType<BigMingPot2>();//
        else if (frame == 5)
            item = ModContent.ItemType<BigMingPot3>();//
        else if (frame == 6)
            item = ModContent.ItemType<BigMingPot4>();//
        else if (frame == 7)
            item = ModContent.ItemType<BigMingPot5>();//
        else if (frame == 8)
            item = ModContent.ItemType<BigAztecPot7>();//
        else if (frame == 9)
            item = ModContent.ItemType<BigAfricanPot1>();//
        else if (frame == 10)
            item = ModContent.ItemType<BigAfricanPot3>();//
        else if (frame == 11)
            item = ModContent.ItemType<BigAfricanPot4>();//
        else if (frame == 12)
            item = ModContent.ItemType<BigAfricanPot5>();//
        else if (frame == 13)
            item = ModContent.ItemType<BigGreekPot1>();//
        else if (frame == 14)
            item = ModContent.ItemType<BigGreekPot2>();//
        else if (frame == 15)
            item = ModContent.ItemType<BigGreekPot5>();//
        else if (frame == 16)
            item = ModContent.ItemType<BigNativePot3>();//
        else if (frame == 17)
            item = ModContent.ItemType<BigNativePot2>();//
        else if (frame == 18)
            item = ModContent.ItemType<BigNativePot6>();//
        else if (frame == 19)
            item = ModContent.ItemType<BigEgyptPot10>();//
        else if (frame == 20)
            item = ModContent.ItemType<BigEgyptPot11>();//
        else if (frame == 21)
            item = ModContent.ItemType<BigGreekPot6>();//
        else if (frame == 22)
            item = ModContent.ItemType<BigGreekPot7>();//
        else if (frame == 23)
            item = ModContent.ItemType<BigGreekPot8>();//
        else if (frame == 24)
            item = ModContent.ItemType<BigGreekPot9>();//
        else if (frame == 25)
            item = ModContent.ItemType<BigGreekPot10>();//
        else if (frame == 26)
            item = ModContent.ItemType<BigMingPot6>();//
        else if (frame == 27)
            item = ModContent.ItemType<BigMingPot10>();//
        else if (frame == 28)
            item = ModContent.ItemType<BigNativePot8>();
        else if (frame == 29)
            item = ModContent.ItemType<BigNativePot10>();
        else if (frame == 30)
            item = ModContent.ItemType<BigAfricanPot10>();
        else if (frame == 31)
            item = ModContent.ItemType<BigAfricanPot11>();
        else if (frame == 32)
            item = ModContent.ItemType<BigAztecPot8>();

        if (item > 0)
            Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 32, 48, item);
    }
}
