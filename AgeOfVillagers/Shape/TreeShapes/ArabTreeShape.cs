using System.Drawing;

namespace AgeOfVillagers
{
    public class ArabTreeShape : CompositeShape
    {
        public ArabTreeShape(Point point, int w, int h)
        {
            Point TopLeft = new Point(point.X - (w / 16), point.Y);
            Point BottomRight = new Point(point.X + (w / 16), point.Y + ((h * 1) / 2));

            AddComponent(new Rectangle(TopLeft, BottomRight));
            AddComponent(new Line(point, new Point(point.X + ((w * 9) / 16), point.Y - ((h * 1) / 6))));
            AddComponent(new Line(point, new Point(point.X - ((w * 9) / 16), point.Y - ((h * 1) / 6))));
            AddComponent(new Line(point, new Point(point.X + ((w * 5) / 16), point.Y - ((h * 5) / 12))));
            AddComponent(new Line(point, new Point(point.X - ((w * 5) / 16), point.Y - ((h * 5) / 12))));
            AddComponent(new Line(point, new Point(point.X, point.Y - ((h * 1) / 2))));
        }
    }
}
