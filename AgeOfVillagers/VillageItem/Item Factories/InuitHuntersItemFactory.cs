using System;

namespace AgeOfVillagers.VillageItem
{
    public class InuitHuntersItemFactory
    {
        private String type;
        public InuitHuntersItemFactory(String nationItem)
        {
            type = nationItem;
        }

        internal IVillageItem ItemProducer()
        {
            if (type == "House")
                return new InuitHuntersHouse();

            return new NoItem();
        }
    }
}
