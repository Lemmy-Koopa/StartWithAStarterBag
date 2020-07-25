
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StartWithAStarterBag.Items
{
	public class StarterBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Right click for items");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.rare = 2;
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			player.QuickSpawnItem(ItemID.MiningPotion, Main.rand.Next(1, 3));
			player.QuickSpawnItem(ItemID.SpelunkerPotion);
			player.QuickSpawnItem(ItemID.WormholePotion, Main.rand.Next(2, 6));
			player.QuickSpawnItem(ItemID.IronskinPotion, Main.rand.Next(1, 3));
			player.QuickSpawnItem(ItemID.LesserHealingPotion, Main.rand.Next(3, 5));
			player.QuickSpawnItem(ItemID.Torch, Main.rand.Next(25, 60));
			player.QuickSpawnItem(ItemID.SlimeStaff);
			player.QuickSpawnItem(ItemID.AmethystStaff);
			player.QuickSpawnItem(ItemID.CopperBow);
			player.QuickSpawnItem(ItemID.CopperBroadsword);
			player.QuickSpawnItem(ItemID.WoodenArrow, Main.rand.Next(100, 200));
			player.QuickSpawnItem(ItemID.Star, Main.rand.Next(3, 7));
			player.QuickSpawnItem(ItemID.Wood, Main.rand.Next(20, 100));
			player.QuickSpawnItem(ItemID.ThrowingKnife, 200);
			player.QuickSpawnItem(ItemID.RecallPotion, 5);
			player.QuickSpawnItem(ItemID.LifeCrystal, 2);
		}
	}
}
