using System.Collections.Generic;
using System.Drawing;

namespace AgeOfVillagers
{
    public class VillageMap
    {
        public List<Point> house_items, waterResource_items, tree_items;

        internal VillageMap()
        {
            tree_items = new List<Point>();
            house_items = new List<Point>();
            waterResource_items = new List<Point>();
        }

        internal void AddTree(GraphicsWithPen gp, Point point, INation nation)
        {
            var tree = nation.getItemShape(point, "Tree");
            tree.Draw(gp);
            tree_items.Add(point);
        }
        internal void AddHouse(GraphicsWithPen gp, Point point, INation nation)
        {
            var house = nation.getItemShape(point, "House");
            house.Draw(gp);
            house_items.Add(point);
        }
        internal void AddWaterResource(GraphicsWithPen gp, Point point, INation nation)
        {
            var water = nation.getItemShape(point, "Water");
            water.Draw(gp);
            waterResource_items.Add(point);
        }

        public void LoadItemFromMap(INation nation, GraphicsWithPen gp)
        {
            foreach (var point in tree_items)
            {
                var shape = nation.getItemShape(point, "Tree");
                shape.Draw(gp);
            }
            foreach (var point in house_items)
            {
                var shape = nation.getItemShape(point, "House");
                shape.Draw(gp);
            }
            foreach (var point in waterResource_items)
            {
                var shape = nation.getItemShape(point, "Water");
                shape.Draw(gp);
            }
        }
    }
}
