using AgeOfVillagers.Shape.CompositeShapes;
using System.Drawing;

namespace AgeOfVillagers
{
    public abstract class House : IVillageItem
    {
        private int height = 16;
        private int width = 16;

        public int getHeight() => height;
        public int getWidth() => width;
        public virtual IShape getItemShape(Point point) => new NoShape();
    }


    public class ArabHouse : House
    {
        public override IShape getItemShape(Point point) => new ArabHouseShape(point, getWidth(), getHeight());
    }

    public class BangladeshiHouse : House
    {
        public override IShape getItemShape(Point point) => new BangladeshiHouseShape(point, getWidth(), getHeight());
    }

    public class EgyptianHouse : House
    {
        public override IShape getItemShape(Point point) => new EgyptianHouseShape(point, getWidth(), getHeight());
    }

    public class InuitHuntersHouse : House
    {
        public override IShape getItemShape(Point point) => new InuitHuntersHouseShape(point, getWidth(), getHeight());
    }

}
