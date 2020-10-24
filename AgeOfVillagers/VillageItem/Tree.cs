using AgeOfVillagers.Shape.CompositeShapes;
using System.Drawing;

namespace AgeOfVillagers
{
    public abstract class Tree : IVillageItem
    {
        private int height = 24;
        private int width = 16;

        public int getHeight() => height;
        public int getWidth() => width;
        public virtual IShape getItemShape(Point point) => new NoShape();
    }

    public class ArabTree : Tree
    {
        public override IShape getItemShape(Point point) => new ArabTreeShape(point, getWidth(), getHeight());
    }

    public class BangladeshiTree : Tree
    {
        public override IShape getItemShape(Point point) => new BangladeshiTreeShape(point, getWidth(), getHeight());
    }

    public class EgyptianTree : Tree
    {
        public override IShape getItemShape(Point point) => new EgyptianTreeShape(point, getWidth(), getHeight());
    }

}
