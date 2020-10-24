using System.Drawing;

namespace AgeOfVillagers
{
    public class EgyptianWaterSourceShape : CompositeShape
    {
        public EgyptianWaterSourceShape(Point center, int w, int h)
        {
            Point Circle_topLeft = new Point(center.X - (w / 2), center.Y - (h / 2));
            Point Circle_bottomRight = new Point(center.X + (w / 2), center.Y + (h / 2));

            AddComponent(new Arc(Circle_topLeft, Circle_bottomRight, 0, 360));
        }
    }
}
