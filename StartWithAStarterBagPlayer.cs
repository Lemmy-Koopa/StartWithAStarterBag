using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using StartWithAStarterBag.Items;

namespace StartWithAStarterBag
{
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
}