using SquintlysPotteryMod.Content.Items.BIG;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
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
        Main.tileLavaDeath[base.Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style3x4);
        TileObjectData.newTile.Width = 2;
        TileObjectData.newTile.CoordinateHeights = new int[4] { 16, 16, 16, 18 };
        TileObjectData.newTile.StyleHorizontal = true;

        TileObjectData.newTile.RandomStyleRange = 3;

        TileObjectData.newTile.StyleWrapLimit = 3;
        TileObjectData.newTile.StyleMultiplier = 3;
        TileObjectData.addTile(base.Type);

        ModTranslation name = base.CreateMapEntryName();
        name.SetDefault("Canopic Jar");
        base.AddMapEntry(new Color(139, 0, 0), name);
    }
    public override void KillMultiTile(int x, int y, int frameX, int frameY)
    {

        int item = 0;
        int frame = frameY / 72;

        if (frame == 0)
            item = ModContent.ItemType<BigJackelJar>();
        else if (frame == 1)
            item = ModContent.ItemType<BigBaboonJar>();
        else if (frame == 2)
            item = ModContent.ItemType<BigHawkJar>();
        else if (frame == 3)
            item = ModContent.ItemType<BigHumanJar>();

        if (item > 0)
            Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 32, 48, item);
    }
}
