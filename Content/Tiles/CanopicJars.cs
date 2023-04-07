using SquintlysPotteryMod.Content.Items;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
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
        Main.tileLavaDeath[base.Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2);
        TileObjectData.newTile.CoordinateHeights = new int[2] { 16, 18 };
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
        int frame = frameY / 38;

        if (frame == 0)
            item = ModContent.ItemType<Items.JackelJar>();
        else if (frame == 1)
            item = ModContent.ItemType<Items.BaboonJar>();
        else if (frame == 2)
            item = ModContent.ItemType<Items.HawkJar>();
        else if (frame == 3)
            item = ModContent.ItemType<Items.HumanJar>();

        if (item > 0)
            Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 32, 48, item);
    }
}
