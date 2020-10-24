using System;

namespace AgeOfVillagers.VillageItem
{
    public class EgyptianItemFactory
    {
        private String type;
        public EgyptianItemFactory(String ItemType)
        {
            type = ItemType;
        }

        internal IVillageItem ItemProducer()
        {
            if (type == "House")
                return new EgyptianHouse();

            else if (type == "Tree")
                return new EgyptianTree();

            else if (type == "Water")
                return new EgyptianWaterResource();

            return new NoItem();
        }
    }
}
