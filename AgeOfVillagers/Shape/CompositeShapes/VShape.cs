using System.Drawing;

namespace AgeOfVillagers
{
    public class VShape : CompositeShape
    {
        public VShape(Point p1, Point mid_p2, Point p3)
        {
            AddComponent(new Line(p1, mid_p2));
            AddComponent(new Line(mid_p2, p3));
        }
    }

}
