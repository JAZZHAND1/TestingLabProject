using System.Drawing;

namespace AgeOfVillagers
{
    public class BangladeshiHouseShape : CompositeShape
    {
        public BangladeshiHouseShape(Point point, int w, int h)
        {
            Point top = point;
            Point baseTopLeft = new Point(top.X - (w / 2), top.Y + (h / 2));
            Point baseBottomRight = new Point(top.X + (w / 2), top.Y + h);

            AddComponent(new VShape(baseTopLeft, top, new Point(baseBottomRight.X, baseTopLeft.Y)));
            AddComponent(new Rectangle(baseTopLeft, baseBottomRight));
        }
    }
}
