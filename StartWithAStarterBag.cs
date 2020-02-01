using GoodProLib.GData;
using StartWithAStarterBag.Items;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace StartWithAStarterBag
{
	public class StartWithAStarterBag : Mod
	{
	}

	public class StartWithAStarterBagPlayer : ModPlayer
	{
		public override void SetupStartInventory(IList<Item> items, bool mediumcoreDeath)
		{
			Item item = new Item();
			item.SetDefaults(ModContent.ItemType<StarterBag>());
			item.stack = 1;
			items.Add(item);
		}
	}

	public class SWSBConfig : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ServerSide;

		[Label("Starter bag item list")]
		[Tooltip("Every item in this list will be in the starter bag when opened")]
		public Dictionary<ItemDefinition, int> StarterBagItems = new Dictionary<ItemDefinition, int>()
		{
			[new ItemDefinition(ItemID.MiningPotion)] = Main.rand.Next(1, 3),
			[new ItemDefinition(ItemID.SpelunkerPotion)] = 1,
			[new ItemDefinition(ItemID.WormholePotion)] = Main.rand.Next(2, 6),
			[new ItemDefinition(ItemID.IronskinPotion)] = Main.rand.Next(1, 3),
			[new ItemDefinition(ItemID.LesserHealingPotion)] = Main.rand.Next(3, 5),
			[new ItemDefinition(ItemID.Torch)] = Main.rand.Next(25, 60),
			[new ItemDefinition(ItemID.SlimeStaff)] = 1,
			[new ItemDefinition(ItemID.AmethystStaff)] = 1,
			[new ItemDefinition(ItemID.CopperBow)] = 1,
			[new ItemDefinition(ItemID.CopperBroadsword)] = 1,
			[new ItemDefinition(ItemID.WoodenArrow)] = Main.rand.Next(100, 200),
			[new ItemDefinition(ItemID.Star)] = Main.rand.Next(3, 7),
			[new ItemDefinition(ItemID.Wood)] = Main.rand.Next(20, 100),
			[new ItemDefinition(ItemID.ThrowingKnife)] = 200,
			[new ItemDefinition(ItemID.RecallPotion)] = 5,
		};

		public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref string message)
		{
			if (PlayerData.IsPlayerServerHost(Main.LocalPlayer, out _))
			{
				message = "You are the server host, config changed.";
				return true;
			}
			else
			{
				message = "You are not the server host, config not changed.";
				return false;
			}
		}
	}
}