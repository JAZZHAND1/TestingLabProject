using AgeOfVillagers.VillageItem;
using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public class ArabBedouin : INation
    {
        private readonly Color color = Color.LightGoldenrodYellow;
        private String nation_name = "Arab Bedouin";

        public string nationName { get => nation_name; set => nation_name = value; }

        public Color getTerrainColor() => color;

        public IShape getItemShape(Point point, String itemType)
        {
            ArabItemFactory factory = new ArabItemFactory(itemType);
            return factory.ItemProducer().getItemShape(point);
        }
    }
}
