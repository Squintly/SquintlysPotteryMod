using SquintlysPotteryMod.Content.Items.BIG;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace SquintlysPotteryMod.Content.Tiles.BIG;

public class PokeyPot : ModTile
{
    public override void SetStaticDefaults()
    {
        TileID.Sets.DisableSmartCursor[base.Type] = true;
        Main.tileFrameImportant[base.Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
        TileObjectData.newTile.StyleHorizontal = true;
        TileObjectData.newTile.Width = 2;
        TileObjectData.newTile.CoordinateHeights = new int[3] { 16, 16, 18 };
        TileObjectData.newTile.CoordinatePaddingFix = new Point16(0, 2);
        TileObjectData.addTile(base.Type);
        ModTranslation name = base.CreateMapEntryName();
        name.SetDefault("Giant Pot");
        base.AddMapEntry(new Color(139, 0, 0), name);
    }
    public override void KillMultiTile(int i, int j, int TileFrameX, int TileFrameY)
    {
        Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ModContent.ItemType<BigAfricanPot6>());
    }
}
