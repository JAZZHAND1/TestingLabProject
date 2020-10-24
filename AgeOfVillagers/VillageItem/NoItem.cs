using AgeOfVillagers.Shape.CompositeShapes;
using System.Drawing;

namespace AgeOfVillagers.VillageItem
{
    public class NoItem : IVillageItem
    {
        public int getHeight() => 0;
        public int getWidth() => 0;
        public IShape getItemShape(Point point) => new NoShape();

    }
}
