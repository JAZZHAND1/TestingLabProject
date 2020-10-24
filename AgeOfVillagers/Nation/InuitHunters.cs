using AgeOfVillagers.VillageItem;
using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public class InuitHunters : INation
    {
        private readonly Color color = Color.White;
        private String nation_name = "Inuit Hunters";

        public string nationName { get => nation_name; set => nation_name = value; }
        public Color getTerrainColor() => color;
        public IShape getItemShape(Point point, String itemType)
        {
            InuitHuntersItemFactory factory = new InuitHuntersItemFactory(itemType);
            return factory.ItemProducer().getItemShape(point);
        }
    }
}
