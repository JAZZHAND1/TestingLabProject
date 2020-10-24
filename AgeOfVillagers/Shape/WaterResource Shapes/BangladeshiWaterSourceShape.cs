using System.Drawing;

namespace AgeOfVillagers
{
    public class BangladeshiWaterSourceShape : CompositeShape
    {
        public BangladeshiWaterSourceShape(Point point, int w, int h)
        {
            Point one = new Point(point.X - ((w * 13) / 24), point.Y);
            Point two = new Point(point.X - ((w * 7) / 24), point.Y - (h * 5) / 8);
            Point three = new Point(point.X - ((w * 1) / 12), point.Y - (h * 11) / 16);
            Point four = new Point(point.X - ((w * 1) / 12), point.Y - (h * 3) / 8);
            Point five = new Point(point.X + ((w * 1) / 6), point.Y - (h * 3) / 4);
            Point six = new Point(point.X + ((w * 10) / 24), point.Y - (h * 7) / 16);
            Point seven = new Point(point.X + ((w * 7) / 24), point.Y + (h * 3) / 16);
            Point eight = point;
            Point nine = new Point(point.X - ((w * 6) / 24), point.Y + (h * 3) / 8);

            AddComponent(new VShape(one, two, three));
            AddComponent(new VShape(three, four, five));
            AddComponent(new VShape(five, six, seven));
            AddComponent(new VShape(seven, eight, nine));
            AddComponent(new Line(nine, one));
        }
    }
}
