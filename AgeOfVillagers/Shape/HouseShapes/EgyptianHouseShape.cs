using System.Drawing;

namespace AgeOfVillagers
{
    public class EgyptianHouseShape : CompositeShape
    {
        public EgyptianHouseShape(Point point, int w, int h)
        {
            Point top = new Point(point.X - (w / 4), point.Y - ((h * 3) / 8));
            Point base_left = new Point(point.X - ((w * 5) / 8), point.Y + (h / 2));
            Point base_mid = new Point(point.X, point.Y + ((h * 5) / 8));
            Point base_right = new Point(point.X + ((w * 3) / 8), point.Y + (h / 8));

            AddComponent(new VShape(top, base_left, base_mid));
            AddComponent(new VShape(top, base_right, base_mid));
            AddComponent(new Line(top, base_mid));
        }
    }
}
