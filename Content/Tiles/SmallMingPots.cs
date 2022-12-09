using SquintlysPotteryMod.Content.Items;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace SquintlysPotteryMod.Content.Tiles;

public class SmallMingPots : ModTile
{
    public override void SetStaticDefaults()
    {
        TileID.Sets.DisableSmartCursor[base.Type] = true;
        Main.tileFrameImportant[base.Type] = true;
        Main.tileLighted[base.Type] = true;
        Main.tileLavaDeath[base.Type] = true;
        TileID.Sets.FramesOnKillWall[base.Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
        TileObjectData.newTile.CoordinateHeights = new int[1] { 18 };
        TileObjectData.newTile.CoordinateWidth = 18;
        TileObjectData.newTile.StyleHorizontal = true;
        TileObjectData.addTile(base.Type);
        ModTranslation name = base.CreateMapEntryName();
        name.SetDefault("Medium Pot");
        base.AddMapEntry(new Color(139, 0, 0), name);
    }
    public override bool Drop(int i, int j)
    {
        Tile t = Main.tile[i, j];
        int style = t.TileFrameX / 18;

        // It can be useful to share a single tile with multiple styles. This code will let you drop the appropriate bar if you had multiple.
        if (style == 0)
        {
            Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 16, 16, ModContent.ItemType<Items.MingPot12>());
        }
        else if (style == 1)
        {
            Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 16, 16, ModContent.ItemType<Items.MingPot13>());
        }
        else if (style == 2)
        {
            Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 16, 16, ModContent.ItemType<Items.MingPot14>());
        }
        else if (style == 3)
        {
            Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 16, 16, ModContent.ItemType<Items.MingPot15>());
        }
        else if (style == 4)
        {
            Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 16, 16, ModContent.ItemType<Items.MingPot16>());
        }

        return base.Drop(i, j);
    }
}
