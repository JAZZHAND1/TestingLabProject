using System.Drawing;

namespace AgeOfVillagers
{
    public class InuitHuntersHouseShape : CompositeShape
    {
        public InuitHuntersHouseShape(Point center, int w, int h)
        {
            Point innerCircle_topLeft = new Point(center.X - ((w * 3) / 16), center.Y - ((h * 3) / 8));
            Point innerCircle_bottomRight = new Point(center.X + ((w * 3) / 16), center.Y + ((h * 3) / 8));
            Point outerCircle_topLeft = new Point(center.X - (w / 2), center.Y - (h * 7) / 8);
            Point outerCircle_bottomRight = new Point(center.X + (w / 2), center.Y + (h * 7) / 8);

            AddComponent(new Arc(innerCircle_topLeft, innerCircle_bottomRight, 0, -180));
            AddComponent(new Arc(outerCircle_topLeft, outerCircle_bottomRight, 0, -180));
            AddComponent(new Line(new Point(center.X - (w / 2), center.Y), new Point(center.X + (w / 2), center.Y)));
        }
    }
}
