using AgeOfVillagers.VillageItem;
using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public class BangladeshiFarmers : INation
    {
        private readonly Color color = Color.GreenYellow;
        private String nation_name = "Bangladeshi Farmers";

        public string nationName { get => nation_name; set => nation_name = value; }

        public Color getTerrainColor() => color;

        public IShape getItemShape(Point point, String itemType)
        {
            BangladeshiItemFactory factory = new BangladeshiItemFactory(itemType);
            return factory.ItemProducer().getItemShape(point);
        }
    }
}
