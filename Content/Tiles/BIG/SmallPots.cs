using SquintlysPotteryMod.Content.Items.BIG;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace SquintlysPotteryMod.Content.Tiles.BIG;

public class SmallPots : ModTile
{
    public override void SetStaticDefaults()
    {
        TileID.Sets.DisableSmartCursor[base.Type] = true;
        Main.tileFrameImportant[base.Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
        TileObjectData.newTile.StyleHorizontal = true;
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
            item = ModContent.ItemType<BigNativePot13>();
        else if (frame == 1)
            item = ModContent.ItemType<BigNativePot14>();
        else if (frame == 2)
            item = ModContent.ItemType<BigNativePot15>();
        else if (frame == 3)
            item = ModContent.ItemType<BigNativePot16>();
        else if (frame == 4)
            item = ModContent.ItemType<BigNativePot17>();
        else if (frame == 5)
            item = ModContent.ItemType<BigGreekPot13>();
        else if (frame == 6)
            item = ModContent.ItemType<BigGreekPot14>();
        else if (frame == 7)
            item = ModContent.ItemType<BigGreekPot15>();
        else if (frame == 8)
            item = ModContent.ItemType<BigGreekPot16>();
        else if (frame == 9)
            item = ModContent.ItemType<BigGreekPot17>();
        else if (frame == 10)
            item = ModContent.ItemType<BigEgyptPot12>();
        else if (frame == 11)
            item = ModContent.ItemType<BigEgyptPot13>();
        else if (frame == 12)
            item = ModContent.ItemType<BigEgyptPot14>();
        else if (frame == 13)
            item = ModContent.ItemType<BigEgyptPot15>();
        else if (frame == 14)
            item = ModContent.ItemType<BigEgyptPot16>();
        else if (frame == 15)
            item = ModContent.ItemType<BigAfricanPot13>();
        else if (frame == 16)
            item = ModContent.ItemType<BigAfricanPot14>();
        else if (frame == 17)
            item = ModContent.ItemType<BigAfricanPot15>();
        else if (frame == 18)
            item = ModContent.ItemType<BigAfricanPot16>();
        else if (frame == 19)
            item = ModContent.ItemType<BigAfricanPot17>();
        else if (frame == 20)
            item = ModContent.ItemType<BigMingPot13>();
        else if (frame == 21)
            item = ModContent.ItemType<BigMingPot14>();
        else if (frame == 22)
            item = ModContent.ItemType<BigMingPot15>();
        else if (frame == 23)
            item = ModContent.ItemType<BigMingPot16>();
        else if (frame == 24)
            item = ModContent.ItemType<BigMingPot17>();
        else if (frame == 25)
            item = ModContent.ItemType<BigAztecPot13>();
        else if (frame == 26)
            item = ModContent.ItemType<BigAztecPot14>();
        else if (frame == 27)
            item = ModContent.ItemType<BigAztecPot15>();
        else if (frame == 28)
            item = ModContent.ItemType<BigAztecPot16>();
        else if (frame == 29)
            item = ModContent.ItemType<BigAztecPot17>();

        if (item > 0)
            Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 32, 48, item);
    }
}
