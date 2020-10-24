using System.Drawing;

namespace AgeOfVillagers
{
    public class GraphicsWithPen
    {
        private Graphics g;
        private Pen p;
        public GraphicsWithPen(Graphics graphics, Pen pen)
        {
            g = graphics;
            p = pen;
        }

        public Pen GetPen()
        {
            return p;
        }
        public Graphics GetGraphics()
        {
            return g;
        }

        public void ChangePen(Pen pen)
        {
            this.p = pen;
        }
    }
}
