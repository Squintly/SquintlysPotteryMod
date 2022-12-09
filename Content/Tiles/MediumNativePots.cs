﻿using SquintlysPotteryMod.Content.Items;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace SquintlysPotteryMod.Content.Tiles;

public class MediumNativePots : ModTile
{
    public override void SetStaticDefaults()
    {
        TileID.Sets.DisableSmartCursor[base.Type] = true;
        Main.tileFrameImportant[base.Type] = true;
        Main.tileLighted[base.Type] = true;
        Main.tileLavaDeath[base.Type] = true;
        TileID.Sets.FramesOnKillWall[base.Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2);
        TileObjectData.newTile.CoordinateHeights = new int[2] { 16, 18 };
        TileObjectData.newTile.CoordinateWidth = 18;
        TileObjectData.newTile.StyleHorizontal = true;
        TileObjectData.addTile(base.Type);
        ModTranslation name = base.CreateMapEntryName();
        name.SetDefault("Medium Pot");
        base.AddMapEntry(new Color(139, 0, 0), name);
    }
    public override void KillMultiTile(int x, int y, int frameX, int frameY)
    {

        int item = 0;
        int frame = frameX / 20;

        if (frame == 0)
            item = ModContent.ItemType<Items.NativePot8>();
        else if (frame == 1)
            item = ModContent.ItemType<Items.NativePot9>();
        else if (frame == 2)
            item = ModContent.ItemType<Items.NativePot10>();
        else if (frame == 3)
            item = ModContent.ItemType<Items.NativePot11>();
        else if (frame == 4)
            item = ModContent.ItemType<Items.NativePot12>();

        if (item > 0)
            Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 32, 48, item);
    }
}