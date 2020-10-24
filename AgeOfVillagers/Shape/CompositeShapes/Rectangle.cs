using System.Drawing;

namespace AgeOfVillagers
{
    public class Rectangle : CompositeShape
    {
        public Rectangle(Point topLeft, Point bottomRight)
        {
            var topRight = new Point(bottomRight.X, topLeft.Y);
            var bottomLeft = new Point(topLeft.X, bottomRight.Y);

            AddComponent(new Line(topLeft, topRight));
            AddComponent(new Line(topRight, bottomRight));
            AddComponent(new Line(bottomRight, bottomLeft));
            AddComponent(new Line(bottomLeft, topLeft));
        }
        public Rectangle(Point topLeft, Point topRight, Point bottomRight, Point bottomLeft)
        {
            AddComponent(new Line(topLeft, topRight));
            AddComponent(new Line(topRight, bottomRight));
            AddComponent(new Line(bottomRight, bottomLeft));
            AddComponent(new Line(bottomLeft, topLeft));
        }
    }

}
