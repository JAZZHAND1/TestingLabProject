using AgeOfVillagers.VillageItem;
using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public class EgyptianKings : INation
    {
        private readonly Color color = Color.Yellow;
        private String nation_name = "Egyptian Kings";

        public string nationName { get => nation_name; set => nation_name = value; }

        public Color getTerrainColor() => color;

        public IShape getItemShape(Point point, String itemType)
        {
            EgyptianItemFactory factory = new EgyptianItemFactory(itemType);
            return factory.ItemProducer().getItemShape(point);
        }
    }
}
