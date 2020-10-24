using System;

namespace AgeOfVillagers.VillageItem
{
    public class BangladeshiItemFactory
    {
        private String type;
        public BangladeshiItemFactory(String ItemType)
        {
            type = ItemType;
        }

        internal IVillageItem ItemProducer()
        {
            if (type == "House")
                return new BangladeshiHouse();

            else if (type == "Tree")
                return new BangladeshiTree();

            else if (type == "Water")
                return new BangladeshiWaterResource();

            return new NoItem();
        }
    }
}
