using System.Drawing;

namespace AgeOfVillagers
{
    public class EgyptianTreeShape : CompositeShape
    {
        public EgyptianTreeShape(Point root, int w, int h)
        {
            Point TopLeft = new Point((root.X - (w * 3) / 8), (root.Y - (h * 5) / 6));
            Point TopRight = new Point((root.X + (w * 5) / 16), (root.Y - (h * 11) / 12));

            Point right_branch_root = new Point((root.X + (w * 5) / 32), (root.Y - (h * 11) / 24));
            Point right_branch_left = new Point((root.X + (w / 16)), root.Y - h);
            Point right_branch_right = new Point((root.X + (w * 9) / 16), (root.Y - (h * 5) / 6));

            Point left_branch_root = new Point((root.X - (w * 39) / 160), (root.Y - (h * 13) / 24));
            Point left_branch_right = new Point((root.X - (w / 8)), (root.Y - (h * 11) / 12));
            Point left_branch_left = new Point((root.X - (w * 9) / 16), (root.Y - (h * 3) / 4));

            AddComponent(new VShape(TopLeft, root, TopRight));
            AddComponent(new VShape(right_branch_left, right_branch_root, right_branch_right));
            AddComponent(new VShape(left_branch_left, left_branch_root, left_branch_right));
        }
    }
}
