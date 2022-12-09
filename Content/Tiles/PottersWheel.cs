using SquintlysPotteryMod.Content.Items;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace SquintlysPotteryMod.Content.Tiles;

public class PottersWheel : ModTile
{
    public override void SetStaticDefaults()
    {
        TileID.Sets.DisableSmartCursor[base.Type] = true;
        Main.tileFrameImportant[base.Type] = true;
        Main.tileLighted[base.Type] = true;
        Main.tileLavaDeath[base.Type] = true;
        TileID.Sets.FramesOnKillWall[base.Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
        TileObjectData.newTile.CoordinateHeights = new [] { 16, 18 };
        TileObjectData.newTile.Origin = new Point16(0, 1);
        TileObjectData.addTile(base.Type);

        ModTranslation name = base.CreateMapEntryName();
        name.SetDefault("Potter's Wheel");
        base.AddMapEntry(new Color(139, 0, 0), name);
    }

    private readonly int animationFrameWidth = 36;

    public override void AnimateIndividualTile(int type, int i, int j, ref int frameXOffset, ref int frameYOffset)
    {
        // Tweak the frame drawn by x position so tiles next to each other are off-sync and look much more interesting
        int uniqueAnimationFrame = Main.tileFrame[Type] + i;
        if (i % 2 == 0)
            uniqueAnimationFrame += 3;
        if (i % 3 == 0)
            uniqueAnimationFrame += 3;
        if (i % 4 == 0)
            uniqueAnimationFrame += 3;
        uniqueAnimationFrame %= 5;

        // frameYOffset = modTile.animationFrameHeight * Main.tileFrame [type] will already be set before this hook is called
        // But we have a horizontal animated texture, so we use frameXOffset instead of frameYOffset
        frameXOffset = uniqueAnimationFrame * animationFrameWidth;
    }

    public override void AnimateTile(ref int frame, ref int frameCounter)
    {

        // Spend 9 ticks on each of 6 frames, looping
        frameCounter++;
        if (frameCounter >= 9)
        {
            frameCounter = 0;
            if (++frame >= 5)
            {
                frame = 0;
            }
        }

        //// Or, more compactly:
        //if (++frameCounter >= 9)
        //{
        //    frameCounter = 0;
        //    frame = ++frame % 5;
        //}


    }

    public override void KillMultiTile(int i, int j, int TileFrameX, int TileFrameY)
    {
        Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ModContent.ItemType<PottersWheelItem>());
    }
}
