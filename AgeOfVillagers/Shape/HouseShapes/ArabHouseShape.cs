using System.Drawing;

namespace AgeOfVillagers
{
    public class ArabHouseShape : CompositeShape
    {
        public ArabHouseShape(Point point, int w, int h)
        {
            Point FrontTop = new Point(point.X, point.Y + ((h * 3) / 8));
            Point baseFrontLeft = new Point(point.X - (w / 2), point.Y + ((h * 3) / 8));
            Point baseFrontRight = new Point(point.X - ((w * 3) / 8), point.Y - ((h * 3) / 8));
            Point baseBackRight = new Point(point.X + (w / 8), point.Y - ((h * 5) / 8));
            Point baseBackTop = new Point(point.X + (w / 2), point.Y + (h / 8));

            AddComponent(new VShape(FrontTop, baseFrontLeft, baseFrontRight));
            AddComponent(new Rectangle(FrontTop, baseFrontRight, baseBackRight, baseBackTop));
        }
    }
}
