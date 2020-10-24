using System;
using System.Collections.Generic;
using System.Drawing;

namespace AgeOfVillagers
{
    public class Village
    {
        private String villageName;
        private INation nation;
        private VillageMap villageMap;

        public Village(string villageName, INation nation)
        {
            this.villageName = villageName;
            this.nation = nation;
            villageMap = new VillageMap();
        }

        public VillageMap GetVillageMap()
        {
            return villageMap;
        }
        public string GetVillageName()
        {
            return villageName;
        }
        public void SetVillageName(string value)
        {
            villageName = value;
        }
        public void SetVillageNation(INation nation)
        {
            this.nation = nation;
        }

        internal void SetState(VillageState state)
        {
            villageName = state.villageName;
            villageMap.tree_items = state.trees;
            villageMap.house_items = state.houses;
            villageMap.waterResource_items = state.watersources;

        }

        public void Initiate(GraphicsWithPen gp)
        {
            gp.GetGraphics().Clear(nation.getTerrainColor());
            villageMap.LoadItemFromMap(nation, gp);
        }

        internal VillageState CreateState()
        {
            return new VillageState(villageName, villageMap.tree_items, villageMap.house_items, villageMap.waterResource_items);
        }
    }


    internal class VillageState
    {
        public String villageName;
        public List<Point> trees, houses, watersources;

        public VillageState(String villageName, List<Point> trees, List<Point> houses, List<Point> watersources)
        {
            this.villageName = villageName;
            this.watersources = watersources;
            this.houses = houses;
            this.trees = trees;
        }
    }
}
