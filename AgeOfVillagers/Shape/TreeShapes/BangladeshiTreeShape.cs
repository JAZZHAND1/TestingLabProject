using System.Drawing;

namespace AgeOfVillagers
{
    public class BangladeshiTreeShape : CompositeShape
    {
        public BangladeshiTreeShape(Point point, int w, int h)
        {
            Point TopLeft = new Point(point.X - (w / 16), point.Y + (h / 6));
            Point BottomRight = new Point(point.X + (w / 16), point.Y + (h * 2) / 3);
            Point Circle_topLeft = new Point(point.X - (w / 2), point.Y - (h / 3));
            Point Circle_bottomRight = new Point(point.X + (w / 2), point.Y + (h / 3));

            AddComponent(new Arc(Circle_topLeft, Circle_bottomRight, 0, 360));
            AddComponent(new Rectangle(TopLeft, BottomRight));
        }
    }
}
