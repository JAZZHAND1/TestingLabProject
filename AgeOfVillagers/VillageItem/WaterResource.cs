using AgeOfVillagers.Shape.CompositeShapes;
using System.Drawing;

namespace AgeOfVillagers
{
    public abstract class WaterResource : IVillageItem
    {
        private int height, width;

        public virtual int getHeight() => height;
        public virtual int getWidth() => width;
        public virtual IShape getItemShape(Point point) => new NoShape();
    }

    public class BangladeshiWaterResource : WaterResource
    {
        private int height = 16, width = 24;

        public override int getHeight() => height;
        public override int getWidth() => width;
        public override IShape getItemShape(Point point) => new BangladeshiWaterSourceShape(point, getWidth(), getHeight());
    }

    public class EgyptianWaterResource : WaterResource
    {
        private int height = 12, width = 12;

        public override int getHeight() => height;
        public override int getWidth() => width;
        public override IShape getItemShape(Point point) => new EgyptianWaterSourceShape(point, getWidth(), getHeight());
    }
}
