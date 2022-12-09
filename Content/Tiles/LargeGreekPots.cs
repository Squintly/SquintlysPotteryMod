using SquintlysPotteryMod.Content.Items;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace SquintlysPotteryMod.Content.Tiles;

public class LargeGreekPots : ModTile
{
    public override void SetStaticDefaults()
    {
        TileID.Sets.DisableSmartCursor[base.Type] = true;
        Main.tileFrameImportant[base.Type] = true;
        Main.tileLighted[base.Type] = true;
        Main.tileLavaDeath[base.Type] = true;
        TileID.Sets.FramesOnKillWall[base.Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
        TileObjectData.newTile.CoordinateHeights = new int[2] { 16, 18 };
        TileObjectData.newTile.StyleHorizontal = true;
        TileObjectData.addTile(base.Type);
        ModTranslation name = base.CreateMapEntryName();
        name.SetDefault("Large Pot");
        base.AddMapEntry(new Color(139, 0, 0), name);
    }
    public override void KillMultiTile(int x, int y, int frameX, int frameY)
    {

        int item = 0;
        int frame = frameX / 36;

        if (frame == 0)
            item = ModContent.ItemType<Items.GreekPot1>();
        else if (frame == 1)
            item = ModContent.ItemType<Items.GreekPot2>();
        else if (frame == 2)
            item = ModContent.ItemType<Items.GreekPot3>();
        else if (frame == 3)
            item = ModContent.ItemType<Items.GreekPot4>();
        else if (frame == 4)
            item = ModContent.ItemType<Items.GreekPot5>();

        if (item > 0)
            Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 32, 48, item);
    }
}
