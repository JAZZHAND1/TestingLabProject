using System;

namespace AgeOfVillagers.VillageItem
{
    public class ArabItemFactory
    {
        private String type;
        public ArabItemFactory(String nationItem)
        {
            type = nationItem;
        }

        internal IVillageItem ItemProducer()
        {
            if (type == "House")
                return new ArabHouse();

            else if (type == "Tree")
                return new ArabTree();

            return new NoItem();
        }
    }
}
